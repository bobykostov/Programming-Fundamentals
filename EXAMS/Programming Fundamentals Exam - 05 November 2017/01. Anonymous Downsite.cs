using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ConsoleApp1
{
    class DictLab1
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            byte securityKey = byte.Parse(Console.ReadLine());

            decimal totalLoss = 0;
            List<string> sites = new List<string>();

            while (n-- > 0)
            {
                string[] info = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                string siteName = info[0];
                uint siteVisits = uint.Parse(info[1]);
                decimal sitePricePerVisit = decimal.Parse(info[2]);

                sites.Add(siteName);
                totalLoss += siteVisits * sitePricePerVisit;
            }

            foreach (string site in sites)
            {
                Console.WriteLine(site);
            }
            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(new BigInteger(securityKey), sites.Count())}");
        }
    }
}