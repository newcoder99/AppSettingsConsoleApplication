using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ConsoleApp1
{
    public class Sample
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot _IConfig = config.Build();
            
            var sample = new Sample();
            _IConfig.GetSection("Sample").Bind(sample);
            Sample _sObj = sample;
            Console.WriteLine("The ID {0} and Name is {1}",_sObj.ID,_sObj.Name);
        }
    }
}
