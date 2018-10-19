using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverResearchTool
{
    interface INasa
    {
        //https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?earth_date=2015-6-3&api_key=DEMO_KEY
        /// <summary>
        /// 
        /// </summary>
        /// <param name="date">this matches the date in the url to query the appropriate date entered by the user</param>
        /// <returns></returns>
        [Get("/mars-photos/api/v1/rovers/curiosity/photos?earth_date={date}&api_key=DEMO_KEY")]
        Task<Photos> GetImages(string date);
        
    }
}
