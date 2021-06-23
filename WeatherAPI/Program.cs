using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace WeatherAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            //my api key c6763f07c9d69173c7abdec01698487d

            var Client = new HttpClient();
            Console.WriteLine("API Key.");
            var apiKey = Console.ReadLine();
            Console.WriteLine("What City?");
            var cityResponse = Console.ReadLine();
            var weather = $"http://api.openweathermap.org/data/2.5/weather?q={cityResponse}&units=imperial&appid={apiKey}";
            


            var response = Client.GetStringAsync(weather).Result;
            //Above gives basically unreadable, below gives more formatted info
            var formattedResponse = JObject.Parse(response).GetValue("main").ToString();
            Console.WriteLine(formattedResponse);
            Console.WriteLine();
            



        }
    }
}
