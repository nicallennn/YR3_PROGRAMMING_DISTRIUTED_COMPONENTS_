using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteDistanceLibrary
{
    public partial class RouteDistanceComponent : Component
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        

        public RouteDistanceComponent()
        {
            InitializeComponent();
        }

        public RouteDistanceComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public string[] CalculateDistanceAndTime(string stationOne, string stationTwo)
        {
            //array to return strings
            string[] returnStrings = new string[3];

            //array to store station ids's
            int[] stationIds;

           
            //get station ids's
            stationIds = GetStationIds(stationOne, stationTwo);

            //check stations exist
            if(stationIds[0] == 0 || stationIds[1] == 0)
            {
                returnStrings[0] = "0";
                return returnStrings;
            }
            
            
            //check if stations are on the same line, get line id
            int sameLine = StationsOnSameLine(stationIds[0], stationIds[1]);

            //if on the same line
            if (sameLine != 0)
            {
                Console.WriteLine("Same Line");
                //get distance and time
                returnStrings = GetSameLineDistance(sameLine, stationIds[0], stationIds[1]);
            }
            else
            {
                Console.WriteLine("Different Line");
                //get distance, time, change station
                returnStrings = GetDifferentLineDistance(stationIds[0], stationIds[1]);
            }



            //return value
            return returnStrings;
        }

 
        


        //method to get different line distance
        private string[] GetDifferentLineDistance(int stn1, int stn2)
        {
            //results array
            string[] results = new string[3];

            //get a list of lines stations appear on
            List<int> stationOneLineList = new List<int>();
            List<int> stationTwoLineList = new List<int>();

            //arrays to store leg1, and leg2 journey results
            string[] leg1;
            string[] leg2;

            //ids for change station and lines 
            int changeStation = 0;
            int line1 = 0;
            int line2 = 0;

            //get lines station 1 is on
            var stnOneQuery =
                from line in db.line_informations
                where line.station_id == stn1
                select line;

            foreach (var line in stnOneQuery)
            {
                stationOneLineList.Add(line.line_id);
            }

            //get lines station 2 is on
            var stnTwoQuery =
                from line in db.line_informations
                where line.station_id == stn2
                select line;

            foreach (var line in stnTwoQuery)
            {
                stationTwoLineList.Add(line.line_id);
            }

            //compare lines -> embedded for loop
            for (int i = 0; i < stationOneLineList.Count; i++)
            {
                for (int j = 0; j < stationTwoLineList.Count; j++)
                {
                    try
                    {
                        //look for intersection
                        var intersectQuery =
                            (from junc in db.intersections
                             where (junc.line1_id == stationOneLineList[i] && junc.line2_id == stationTwoLineList[j])
                         || (junc.line2_id == stationOneLineList[i] && junc.line1_id == stationTwoLineList[j])
                             select junc).SingleOrDefault();

                        changeStation = intersectQuery.station_id;

                        //store the lines the stations are on
                        line1 = stationOneLineList[i];
                        line2 = stationTwoLineList[j];
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("More than one intersection for journey! -> limited due to algorithm");

                        
                    }                    
            
                }

                //if an intersection is not found
                if (changeStation != 0)
                {
                    
                    break;
                }
            }

            Console.WriteLine("Station to change at " + changeStation);

            //call samelinesdistance(), for each part of the journey
            leg1 = GetSameLineDistance(line1, stn1, changeStation);
            leg2 = GetSameLineDistance(line2, stn2, changeStation);

            //get distance and times
            decimal distance1 = Decimal.Parse(leg1[0]);
            decimal distance2 = Decimal.Parse(leg2[0]);
            decimal time1 = Decimal.Parse(leg1[1]);
            decimal time2 = Decimal.Parse(leg2[1]);

            Console.WriteLine("Distance 1: " + distance1);
            Console.WriteLine("Distance 2: " + distance2);
            Console.WriteLine("Time 1: " + time1);
            Console.WriteLine("Time 2: " + time2);

            results[0] = (distance1 + distance2).ToString();
            results[1] = ((time1 + time2) + 15).ToString();    //add 15 mins to journey time
            results[2] = GetStationName(changeStation);

            Console.WriteLine("Distance: " + results[0]);
            Console.WriteLine("Time: " + results[1]);
            Console.WriteLine("Change at: " + results[2]);

            //return the results array
            return results;
        }

        private string[] GetSameLineDistance(int line, int stn1, int stn2)
        {
            decimal distance = 0;
            decimal time = 0;
            decimal delay = 0;
            string[] results = new string[3];

            //get positions
            var positionQuery =
                (from position in db.line_informations
                where position.line_id == line  && position.station_id == stn1
                select position).SingleOrDefault();

            int stnPosition1 = positionQuery.position;

            Console.WriteLine(stnPosition1);

            var positionQuery2 =
                (from position in db.line_informations
                 where position.line_id == line && position.station_id == stn2
                 select position).SingleOrDefault();

            int stnPosition2 = positionQuery2.position;

            Console.WriteLine(stnPosition2);


            //check which station appears first on the line
            if (stnPosition1 < stnPosition2)
            {
                var distanceQuery =
                    from dist in db.line_informations
                    where dist.line_id == line && (dist.position >= stnPosition1 && dist.position < stnPosition2)
                    orderby dist.position
                    select dist;
              
                //calculate distance
                foreach (var dist in distanceQuery)
                {
                    
                    distance += dist.distance_to_next;
                    time += dist.time_to_next;

                    //check for delays
                    if (dist.delay_to_next != null)
                    {
                        delay += (decimal)dist.delay_to_next;
                    }

                }
                
            }
            else
            {
                var distanceQuery =
                    from dist in db.line_informations
                    where dist.line_id == line && (dist.position >= stnPosition2 && dist.position < stnPosition1)
                    orderby dist.position
                    select dist;
                
                //calculate distance
                foreach (var dist in distanceQuery)
                {
                    distance += dist.distance_to_next;
                    time += dist.time_to_next;

                    //check for delays
                    if (dist.delay_to_next != null)
                    {
                        delay += (decimal)dist.delay_to_next;
                    }

                }
                
            }

            Console.WriteLine("Time before delay " + time);

            time = time + delay;

            Console.WriteLine("Time after delay " + time);


            results[0] = distance.ToString();
            results[1] = time.ToString();

            //return the results array
            return results;
        }

        private string GetStationName(int stnId)
        {
            string stnName;

            //station 1 id
            var stnIdOne =
                (from stn in db.stations
                 where stn.station_id == stnId
                 select stn).SingleOrDefault(); ;

            stnName = stnIdOne.station_name;


            return stnName;
        }

        private int[] GetStationIds(string stn1, string stn2)
        {
            int[] ids = new int[2];

            //station 1 id
            var stnIdOne =
                (from stn in db.stations
                 where stn.station_name.Contains(stn1)
                 select stn).SingleOrDefault(); ;

            if(stnIdOne == null)
            {
                ids[0] = 0;
                return ids;
            }

            ids[0] = stnIdOne.station_id;

            //station 2 id
            var stnIdTwo =
               (from stn in db.stations
                where stn.station_name.Contains(stn2)
                select stn).SingleOrDefault();

            if (stnIdTwo == null)
            {
                ids[1] = 0;
                return ids;
            }

            ids[1] = stnIdTwo.station_id;

            //test output
            Console.WriteLine(ids[0]);
            Console.WriteLine(ids[1]);

            return ids;
        }

        private int StationsOnSameLine(int stn1, int stn2)
        {
            //int lists 
            List<int> stationOneLineList = new List<int>();
            List<int> stationTwoLineList = new List<int>();

            //get lines station one is on
            var stnOneQuery =
                from line in db.line_informations
                where line.station_id == stn1
                select line;

            foreach(var line in stnOneQuery)
            {
                stationOneLineList.Add(line.line_id);
            }

            //get lines station 2 is on
            var stnTwoQuery =
                from line in db.line_informations
                where line.station_id == stn2
                select line;

            foreach (var line in stnTwoQuery)
            {
                stationTwoLineList.Add(line.line_id);
            }

            //compare lines -> embedded for loop
            for(int i = 0; i < stationOneLineList.Count; i++)
            {
                for(int j = 0; j < stationTwoLineList.Count; j++)
                {
                    if (stationOneLineList[i] == stationTwoLineList[j])
                    {
                        //if matched, return line no.
                        return stationOneLineList[i];
                    }
                }
            }

            //if not matched
            return 0;
        }
    }
}
