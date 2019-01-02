using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, long>>();
            var cache = new Dictionary<string, Dictionary<string, long>>();

            string input = string.Empty;
            while (!"thetinggoesskrra".Equals(input = Console.ReadLine()))
            {
                string[] info = input
                .Split(new char[] { ' ', '-', '>', '|' },
                StringSplitOptions.RemoveEmptyEntries);

                if (info.Length == 1)
                {
                    if (!data.ContainsKey(info[0]))
                    {
                        data[info[0]] = new Dictionary<string, long>();
                        data[info[0]]["totalSize"] = 0;

                        if (cache.ContainsKey(info[0]))
                        {
                            foreach (var keySize in cache[info[0]])
                            {
                                data[info[0]].Add(keySize.Key, keySize.Value);
                                data[info[0]]["totalSize"] += keySize.Value;
                            }
                        }
                    }
                }
                else if (info.Length == 3)
                {
                    string dataKey = info[0];
                    long dataSize = long.Parse(info[1]);
                    string dataSet = info[2];

                    if (data.ContainsKey(dataSet))
                    {
                        data[dataSet][dataKey] = dataSize;
                        data[dataSet]["totalSize"] += dataSize;
                        continue;
                    }
                    else if (!cache.ContainsKey(dataSet))
                    {
                        cache[dataSet] = new Dictionary<string, long>();
                    }
                    cache[dataSet][dataKey] = dataSize;
                }
            }

            if (data.Keys.Any())
            {
                string highestSum = data.Keys
                    .OrderByDescending(s => data[s]["totalSize"]).First();

                Console.WriteLine($"Data Set: {highestSum}, Total Size: {data[highestSum]["totalSize"]}");
                foreach (string dataKey in data[highestSum].Keys
                    .Where(k => k != "totalSize"))
                {
                    Console.WriteLine($"$.{dataKey}");
                }
            }
        }
    }
}
