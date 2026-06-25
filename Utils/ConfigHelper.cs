using Microsoft.Extensions.Configuration;

namespace demosite.Utils
{
    public static class ConfigHelper
    {
        private static readonly IConfiguration _config =
            new ConfigurationBuilder()
            .AddJsonFile("envConfig.json", optional: false, reloadOnChange: true)
            .Build();

        public static string GetUrl(string pageName)
        {
            string env = Environment.GetEnvironmentVariable("TEST_ENV") ?? "QA";

            return _config[$"Environments:{env}:{pageName}"]
                ?? throw new Exception(
                    $"URL not found for Environment '{env}' and Page '{pageName}'");
        }
    }
}