using LinqInManhattan.Class;
using Newtonsoft.Json;
using System;
using System.IO;

namespace LinqInManhattan
{
    class Program
    {
        public static Root JsonData { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GetJsonData();
            OutputInformation();
        }

        public static void GetJsonData()
        {
            string jsonString = File.ReadAllText("../../../../data.json");
            JsonData = JsonConvert.DeserializeObject<Root>(jsonString);
        }

        public static void OutputInformation()
        {
            foreach (var item in JsonData.features)
            {
                Console.WriteLine(item.properties.neighborhood);
            }
        }
    }
}
