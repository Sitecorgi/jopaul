using Jo.Models.Regions;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;

namespace Jo.Models.SiteTypes
{
    [SiteType(Title = "Demo site")]
    public class DemoSite : SiteContent<DemoSite>
    {
        [Region(Title = "Footer", Display = RegionDisplayMode.Setting)]
        public Footer FooterContents { get; set; }
    }
}