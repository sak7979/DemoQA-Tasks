using System.IO;
using Newtonsoft.Json.Linq;

namespace demosite.Utils
{
    public static class EnvHelper
    {
        private static JObject _config;

        static EnvHelper()
        {
            var json = File.ReadAllText("Jsons/envConfig.json");
            _config = JObject.Parse(json);
        }

        public static string GetUrl(string env, string page)
        {
            var baseUrl = _config["Environments"]?[env]?["BaseUrl"]?.ToString();
            var path = _config["Environments"]?[env]?["Pages"]?[page]?.ToString();

            return $"{baseUrl}{path}";
        }
    }
}