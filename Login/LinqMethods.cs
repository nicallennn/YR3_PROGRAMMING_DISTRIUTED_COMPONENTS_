using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopNetworkEditor 
{
    class LinqMethods : ILinqMethods
    {
        DBClassesDataContext db = new DBClassesDataContext();


        /***************** ADD METHODS ********************/

        public bool AddLine(string name)
        {
            var line = new line { line_name = name };

            try
            {
                db.lines.InsertOnSubmit(line);
                db.SubmitChanges();
                Console.WriteLine("Inserted line Successfully");
                //MainForm.UpdateLists();
                return true;
            }
            catch (Exception eX)
            {
                Console.WriteLine("Failed to insert line : " + eX);
                return false;
            }

        }

        public bool AddStation(string name)
        {
            var station = new station { station_name = name };

            try
            {
                db.stations.InsertOnSubmit(station);
                db.SubmitChanges();
                Console.WriteLine("Inserted station Successfully");
               // MainForm.UpdateLists();
                return true;
            }
            catch (Exception eX)
            {
                Console.WriteLine("Failed to insert station : " + eX);
                return false;
            }
        }

        /***************** REMOVE METHODS ********************/

        public bool RemoveLine(int id)
        {
            //query to find line with id matching passed id
            var removeQuery =
                from line in db.lines
                where line.line_id == id
                select line;

            //delete line with matching id
            foreach (var line in removeQuery)
            {
                //remove from lines table
                db.lines.DeleteOnSubmit(line);
            }

            //try submit the changes
            try
            {
                db.SubmitChanges();
                Console.WriteLine("Deleted line Successfully");
                //MainForm.UpdateLists();
                return true;
            }
            catch (Exception eX)
            {
                //if an exception is throw, log to console and return false
                Console.WriteLine("Failed to delete line : " + eX);
                
                return false;
            }
        }

        public bool RemoveStation(int id)
        {
            //query to find station with id matching passed id
            var removeQuery =
                from station in db.stations
                where station.station_id == id
                select station;

            //delete station with matching id
            foreach (var stn in removeQuery)
            {
                //remove from stations table
                db.stations.DeleteOnSubmit(stn);
            }

            //try submit the changes
            try
            {
                //submit the changes to the database
                db.SubmitChanges();
                Console.WriteLine("Removed station Successfully");
                //MainForm.UpdateLists();
                return true;
            }
            catch(Exception eX)
            {
                //if an exception is thrown, log to console and return false
                Console.WriteLine("Failed to remove line : " + eX);
                
                return false;
            }
        }

        /***************** EDIT METHODS ********************/

        public bool EditStation(int id, string newName)
        {
            //generate update query string
            var updateStationQuery =
                from station in db.stations
                where station.station_id == id
                select station;

                if(updateStationQuery.Count() == 0)
                {
                    Console.WriteLine("Station Id not recognised");
                    return false;
                }
                
                foreach(var stn in updateStationQuery)
                {
                    stn.station_name = newName;
                }

            try
            {
                db.SubmitChanges();
                Console.WriteLine("Updated station successfully.");
                return true;
            }
            catch(Exception eX)
            {
                Console.WriteLine("Failed to update station : " + eX);
                return false;
            }
            
        }

        public bool EditLine(int id, string newName)
        {
            //generate update query string
            var updateLineQuery =
                from ln in db.lines
                where ln.line_id == id
                select ln;

                if (updateLineQuery.Count() == 0)
                {
                    Console.WriteLine("Line Id not recognised");
                    return false;
                }

                foreach (var ln in updateLineQuery)
                {
                    ln.line_name = newName;
                }
            
            
            try
            {
                db.SubmitChanges();
                Console.WriteLine("Updated line successfully.");
                //MainForm.UpdateLists();
                return true;
            }
            catch (Exception eX)
            {
                Console.WriteLine("Failed to update line : " + eX);
                return false;
            }

        }

        /***************** LINE EDITOR METHODS ********************/

        public bool AddToLine(int lineId, int stationId, int position, decimal distanceToNext, decimal timeToNext)
        {
            //check station is not already on line
            var alreadyOnLineQuery =
                (from stn in db.line_informations
                 where stn.line_id == lineId && stn.station_id ==stationId
                 select stn
                
                ).SingleOrDefault();

            //if the station is already on the line return false
            if(alreadyOnLineQuery != null)
            {
                return false;
            }

            
            //create query
            var lineInfo = new line_information {
                line_id = lineId,
                station_id = stationId,
                position = position,
                distance_to_next = distanceToNext,
                time_to_next = timeToNext,
                delay_to_next = 0
            };

            //insert values and submit changes
            try
            {
                db.line_informations.InsertOnSubmit(lineInfo);
                db.SubmitChanges();
                Console.WriteLine("Inserted line info Successfully");

                //check for and add intersections
                AddIntersection(lineId, stationId);

                return true;
            }
            catch (Exception eX)
            {
                Console.WriteLine("Failed to insert line info : " + eX);
                return false;
            }


        }

        public bool RemoveFromLine(int lineId, int stationId)
        {
            //query to find station with id matching passed id
            var removeQuery =
                from stn in db.line_informations
                where stn.line_id == lineId && stn.station_id == stationId
                select stn;

            //delete station with matching id
            foreach (var stn in removeQuery)
            {
                //remove from stations table
                db.line_informations.DeleteOnSubmit(stn);
            }

            //try submit the changes
            try
            {
                //submit the changes to the database
                db.SubmitChanges();
                Console.WriteLine("Removed station Successfully");

                //remove line2 id, as FK constraint
                RemoveIntersection(lineId, stationId);
                
            }
            catch (Exception eX)
            {
                //if an exception is thrown, log to console and return false
                Console.WriteLine("Failed to remove station from line : " + eX);

                return false;
            }

            
            return true;

        }

        /***************** INTERSECTION METHODS ********************/

        public bool AddIntersection(int lineId, int stationId)
        {
            //check if station exists on other lines
            var intersectQuery =
                from stn in db.line_informations
                where stn.line_id != lineId && stn.station_id == stationId
                select stn;

            //run query and store line id's where station already exists
            List<int> ids = new List<int>();
            foreach(var stn in intersectQuery)
            {
                ids.Add(stn.line_id);
            }

            //if the station exists on another line
            if(ids.Count > 0)
            {
                Console.WriteLine("Adding Intersections");
                //iterate through ids list and run linq query to add intersections
                for(int i = 0; i < ids.Count; i++)
                {
                    //add intersection
                    var addIntersectQuery = new intersection {
                        station_id = stationId,
                        line1_id = lineId,
                        line2_id = ids[i]
                    };

                    //submit the changes
                    try
                    {
                        db.intersections.InsertOnSubmit(addIntersectQuery);
                        db.SubmitChanges();
                        Console.WriteLine("Inserted intersection info Successfully");
                        
                    }
                    catch (Exception eX)
                    {
                        Console.WriteLine("Failed to insert intersection info : " + eX);
                        return false;
                    }
                }

                return true;
            }

            Console.WriteLine("No intersections to add!");
            return false;
        }

        public bool RemoveIntersection(int lineId)
        {
            //find intersections
            var removeIntersectionQuery =
                from intersect in db.intersections
                where intersect.line1_id == lineId || intersect.line2_id == lineId
                select intersect;

            //remove intersections
            foreach (var intersect in removeIntersectionQuery)
            {
                db.intersections.DeleteOnSubmit(intersect);
            }

            //try submit the changes
            try
            {

                db.SubmitChanges();
                Console.WriteLine("Removed intersection Successfully");
                return true;
            }
            catch (Exception eX)
            {
                //if an exception is thrown, log to console and return false
                Console.WriteLine("Failed to remove intersection from line : " + eX);

                return false;
            }

        }

        public bool RemoveIntersection(int lineId, int stationId)
        {
            //find intersections
            var removeIntersectionQuery =
                from intersect in db.intersections
                where intersect.station_id == stationId
                select intersect;

            //remove intersections
            foreach(var intersect in removeIntersectionQuery)
            {
                db.intersections.DeleteOnSubmit(intersect);
            }

            //try submit the changes
            try
            {
                
                db.SubmitChanges();
                Console.WriteLine("Removed intersection Successfully");
                return true;
            }
            catch (Exception eX)
            {
                //if an exception is thrown, log to console and return false
                Console.WriteLine("Failed to remove intersection from line : " + eX);

                return false;
            }

        }

        

        /***************** SORTING METHODS ********************/

        public void SortLineOrder(int lineId)
        {
            //get all stations on the line and order by position
            var sortQuery =
                from stn in db.line_informations
                where stn.line_id == lineId
                orderby stn.position
                select stn;

            //update the position
            int positionCounter = 1;
            foreach(var stn in sortQuery)
            {
                stn.position = positionCounter;
                positionCounter++;
    
            }

            //submit the changes
            try
            {
                db.SubmitChanges();
                Console.WriteLine("Sorted line order Successfully");
                return;

            }
            catch (Exception eX)
            {
                Console.WriteLine("Failed to sort line : " + eX);
                return;
            }

        }

        /***************** DELAY METHODS ********************/

        public bool AddDelayToLine(int lineId, int stationId, decimal delayTime)
        {
            //generate add delay query string
            var addDelayQuery =
                from station in db.line_informations
                where station.line_id == lineId && station.station_id == stationId
                select station;

            //check a result was found
            if (addDelayQuery.Count() == 0)
            {
                Console.WriteLine("Station Id not recognised");
                return false;
            }

            //write the changes
            foreach (var stn in addDelayQuery)
            {
                stn.delay_to_next = delayTime;
            }

            //submit the changes
            try
            {
                db.SubmitChanges();
                Console.WriteLine("Added delay successfully");
                return true;

            }
            catch (Exception eX)
            {
                Console.WriteLine("Failed to add delay : " + eX);
                return false;
            }
      
        }

        public bool RemoveDelayFromLine(int lineId, int stationId)
        {
            //find intersections
            var removeDelayQuery =
                from delay in db.line_informations
                where delay.line_id == lineId && delay.station_id == stationId
                select delay;

            //remove intersections
            foreach (var delay in removeDelayQuery)
            {
                delay.delay_to_next = 0;
                
            }

            //submit the changes
            try
            {
                db.SubmitChanges();
                Console.WriteLine("Removed delay successfully");
                return true;

            }
            catch (Exception eX)
            {
                Console.WriteLine("Failed to remove delay : " + eX);
                return false;
            }
        }


        /********************* match id to name *************************/
        public string GetLineName(int id)
        {
            string getName =
                (from name in db.lines
                 where name.line_id == id
                 select name.line_name).SingleOrDefault();

            return getName;
        }
    }
}
