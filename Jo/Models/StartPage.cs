using Jo.Models.Regions;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;
using System.Collections.Generic;

namespace Jo.Models
{
    [PageType(Title = "Start page")]
    [PageTypeRoute(Title = "Default", Route = "/start")]
    public class StartPage : Page<StartPage>
    {
 

        /// <summary>
        /// Default constructor.
        /// </summary>
        public StartPage() {

           
        }
    }
}