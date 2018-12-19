using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine()
                .Split(' ')
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "3:1")
            {
                if (input.Contains("merge"))
                {
                    string[] split = input.Split(' ').ToArray();
                    int startIndex = int.Parse(split[1]);
                    int endIndex = int.Parse(split[2]);
                    startIndex = startIndex < 0 || startIndex > data.Count - 1 ?
                        0 : startIndex;
                    endIndex = endIndex > data.Count - 1 || endIndex < 0 ?
                        data.Count - 1 : endIndex;

                    int range = endIndex - startIndex + 1;
                    string merged = string.Join("", data.GetRange(startIndex, range));
                    data.RemoveRange(startIndex, range);
                    data.Insert(startIndex, merged);
                }
                else if (input.Contains("divide"))
                {
                    string[] split = input.Split(' ').ToArray();
                    int index = int.Parse(split[1]);
                    int divisions = int.Parse(split[2]);

                    string chosen = data[index];
                    int chunks = chosen.Length / divisions;

                    List<string> divided = new List<string>();
                    for (int i = 0; i < divisions; i++)
                    {
                        if (i == divisions - 1)
                        {
                            divided.Add(chosen.Substring(i * chunks));
                        }
                        else
                        {
                            divided.Add(chosen.Substring(i * chunks, chunks));
                        }
                    }

                    data.RemoveAt(index);
                    data.InsertRange(index, divided);
                }
            }

            Console.WriteLine(string.Join(" ", data));
        }
    }
}