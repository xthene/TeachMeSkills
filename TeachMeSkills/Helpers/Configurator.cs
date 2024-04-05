﻿using System.Reflection;
using Newtonsoft.Json;

namespace TeachMeSkills.Helpers
{
    public class Configurator
    {
        public static AppSettings ReadConfiguration()
        {
            var appSettingsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "appsettings.json");
            var appSettingsText = File.ReadAllText(appSettingsPath);

            return JsonConvert.DeserializeObject<AppSettings>(appSettingsText) ?? throw new FileNotFoundException();
        }
    }
}
