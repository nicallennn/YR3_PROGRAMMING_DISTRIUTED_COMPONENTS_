using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Web;
using System.Web.Services;
using RouteDistanceLibrary;

namespace JourneyService
{
    /// <summary>
    /// Summary description for JourneySearch
    /// </summary>
    [WebService(Namespace = "http://www.gre.ac.uk/pdc/na2880g/Quoter")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class JourneySearch : System.Web.Services.WebService
    {
        private RouteDistanceComponent distanceComp;

        public JourneySearch() {

            distanceComp = new RouteDistanceComponent();

        }


        [WebMethod]
        public string[] GetDistance(string stn1, string stn2)
        {
            

            return distanceComp.CalculateDistanceAndTime(stn1, stn2);
        }
    }
}
