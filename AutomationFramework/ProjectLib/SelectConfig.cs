using Microsoft.Extensions.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AutomationFramework.ProjectLib

{
    public class SelectConfig
    {
        public static SelectConfig selectConfig;
        private static IConfigurationRoot _configuration;
        public string path;
        public static SelectConfig get()
        {

            if (selectConfig == null)
            {
                selectConfig = new SelectConfig();
            }
            return selectConfig;
        }
        public IConfigurationRoot getConfiguration()
        {
            string env = Environment.GetEnvironmentVariable("Environment");
            path = Directory.GetCurrentDirectory() + "\\Resources\\" + env;

            var settingsFiles = Directory.GetFiles(path, "BaseConfig.json");
            if (settingsFiles.Length != 1) throw new Exception($"Expect to have exactly only one configuration-specfic settings file, but found {string.Join(", ", settingsFiles)}.");
            var settingsFile = settingsFiles.First();


            //Environment.SetEnvironmentVariable("AccountPassword","ABCD1234");

            var builder = new ConfigurationBuilder()
                .AddJsonFile("BaseConfig.json", optional: true, reloadOnChange: true)
                .AddJsonFile(settingsFile)
                .AddEnvironmentVariables();

            


            var configuration = builder.Build();
            _configuration = configuration;
            
            /*Console.WriteLine("Config Account Password :"+_configuration["AccountPassword"]);
            Console.WriteLine("Env var Account Password : "+Environment.GetEnvironmentVariable("AccountPassword"));*/

            var keys = builder.Build().AsEnumerable().ToList();

            /*foreach (var key in keys)
            {
                Console.WriteLine("Key is ==>" + key);
                Console.WriteLine("Key Key is ==>" + key.Key);
                Console.WriteLine("Key Value is ==>" + key.Value);
                if (Environment.GetEnvironmentVariable(key.Key) == "" || Environment.GetEnvironmentVariable(key.Key) == null)
                {
                    Environment.SetEnvironmentVariable(key.Key, key.Value);
                }
                Console.WriteLine("Environment Value is ==>" + Environment.GetEnvironmentVariable(key.Key));
            }*/


           /* Console.WriteLine("<=======================================>");
            Console.WriteLine("GetEnvironmentVariables: ");
            foreach (DictionaryEntry de in Environment.GetEnvironmentVariables())
                Console.WriteLine("Global Env Vars :  {0} = {1}", de.Key, de.Value);*/

            return configuration;

        }
    }
}
