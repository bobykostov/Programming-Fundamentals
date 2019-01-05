using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var forecast = new Dictionary<string, Dictionary<string, string>>();

            string pattern = @"([A-Z]{2})(\d+\.\d{1,2})([A-Za-z]+)(?=\|)";
            Regex regex = new Regex(pattern);

            string input = string.Empty;
            while (!"end".Equals(input = Console.ReadLine()))
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string city = match.Groups[1].Value;
                    string temp = match.Groups[2].Value;
                    string weather = match.Groups[3].Value;

                    if (!forecast.ContainsKey(city))
                    {
                        forecast[city] = new Dictionary<string, string>();
                    }
                    forecast[city]["temperature"] = temp;
                    forecast[city]["weather"] = weather;
                }
            }

            foreach (var fc in forecast
                .OrderBy(kv => double.Parse(kv.Value["temperature"])))
            {
                Console.WriteLine($"{fc.Key} => " +
                    $"{double.Parse(fc.Value["temperature"]):F2} => " +
                    $"{fc.Value["weather"]}");
            }
        }
    }
}
