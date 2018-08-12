using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopNetworkEditor
{
    interface ILinqMethods
    {
        //add station / line
        bool AddStation(string name);

        bool AddLine(string name);


        //remove station / line
        bool RemoveStation(int id);

        bool RemoveLine(int id);


        //edit station / line
        bool EditStation(int id, string newName);

        bool EditLine(int id, string newName);


        //add station to line
        bool AddToLine(int lineId, int stationId, int position, decimal distanceToNext, decimal timeToNext);

        
        //remove station from line
        bool RemoveFromLine(int lineId, int stationId);

        //add intersection
        bool AddIntersection(int lineId, int stationId);

        //remove intersection
        bool RemoveIntersection(int lineId, int staitonId);


        //sort order of stations on line
        void SortLineOrder(int lineId);


        //add delay to line
        bool AddDelayToLine(int lineId, int stationId, decimal delayTime);


        //remove delay from line
        bool RemoveDelayFromLine(int lineId, int stationId);


    }
}
