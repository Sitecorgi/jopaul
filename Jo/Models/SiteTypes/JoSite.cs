using Jo.Models.Regions;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;

namespace Jo.Models.SiteTypes
{
    [SiteType(Title = "Dr Joanne Paul")]
    public class JoSite : SiteContent<JoSite>
    {
        [Region(Title = "Footer", Display = RegionDisplayMode.Setting)]
        public Footer FooterContents { get; set; }
    }
}
