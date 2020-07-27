using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Piranha.Extend;
using Piranha.Extend.Fields;

namespace Jo.Models.Regions
{
    public class Footer
    {
        [Field(Title = "Footer logo")]
        public ImageField Logo { get; set; }

        [Field(Title = "Copyright text")]
        public HtmlField CopyrightText { get; set; }
    }
}
