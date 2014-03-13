using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepAlive
{
    public class KeepAliveSection : ConfigurationSection
    {
        [ConfigurationProperty("interval", DefaultValue = "1800", IsRequired = true)]
        public int Interval
        {
            get { return (int)this["interval"]; }
            set { this["interval"] = value; }
        }

        [ConfigurationProperty("site", IsRequired = false)]
        public SiteElement Site
        {
            get { return (SiteElement)this["site"]; }
            set { this["site"] = value; }
        }
    }

    public class SiteElement : ConfigurationElement
    {
        [ConfigurationProperty("active", DefaultValue = "false", IsRequired = true)]
        public bool Active
        {
            get { return (bool)this["active"]; }
            set { this["active"] = value; }
        }

        [ConfigurationProperty("name", DefaultValue = "", IsRequired = true)]
        public string Name { get; set; }

        [ConfigurationProperty("url", DefaultValue = "", IsRequired = true)]
        public string Url { get; set; }
    }
}
