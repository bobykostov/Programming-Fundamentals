using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string surfaceReg = @"[^A-Za-z0-9]+$";
            string mantleReg = @"[0-9_]+$";
            string coreReg = @"([^A-Za-z0-9]+)([0-9_]+)([A-Za-z]+)([0-9_]+)([^A-Za-z0-9]+)$";
            int core = 0;
            bool isValid = true;

            for (int i = 1; i <= 5; i++)
            {
                input = Console.ReadLine();
                string currentLayer = string.Empty;

                if (i == 1 || i == 5)
                {
                    currentLayer = surfaceReg;
                }
                else if (i == 2 || i == 4)
                {
                    currentLayer = mantleReg;
                }
                else
                {
                    currentLayer = coreReg;
                }

                Match m = Regex.Match(input, currentLayer);

                if (currentLayer == coreReg && m.Success)
                {
                    core = m.Groups[3].ToString().Length;
                }

                if (!m.Success)
                    isValid = false;
            }

            if (!isValid)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine($"Valid\n{core}");
            }
        }
    }
}