using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace WebMvc.BAL
{

    public class CutormPartialCacheAttribute : OutputCacheAttribute
    {
        public CutormPartialCacheAttribute(string cacheProfileName) 
        {
            OutputCacheSettingsSection cacheSettings = (OutputCacheSettingsSection)
            WebConfigurationManager.GetSection("system.web/caching/outputCacheSettings");
            OutputCacheProfile cacheProfile = cacheSettings.OutputCacheProfiles[cacheProfileName];
            Duration = cacheProfile.Duration;
            VaryByParam = cacheProfile.VaryByParam;
            VaryByCustom = cacheProfile.VaryByCustom;
        }

    }
}