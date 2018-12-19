using System;
using System.Collections.Generic;
using System.Linq;

namespace Pr3
{
    class Pr3
    {
        static void Main(string[] args)
        {
            List<string> library = Console.ReadLine()
                .Split(' ')
                .ToList();
            string commands = Console.ReadLine();

            while (commands != "Play!")
            {
                string[] singleComm = commands
                    .Split(' ')
                    .ToArray();

                if (singleComm[0] == "Install")
                {
                    if (!library.Contains(singleComm[1]))
                    {
                        library.Add(singleComm[1]);
                    }
                }
                else if (singleComm[0] == "Uninstall")
                {
                    if (library.Contains(singleComm[1]))
                    {
                        library.Remove(singleComm[1]);
                    }
                }
                else if (singleComm[0] == "Update")
                {
                    if (library.Contains(singleComm[1]))
                    {
                        library.Remove(singleComm[1]);
                        library.Add(singleComm[1]);
                    }
                }
                else if (singleComm[0] == "Expansion")
                {
                    string[] expansion = singleComm[1].Split('-').ToArray();

                    if (library.Contains(expansion[0]))
                    {
                        int index = library.IndexOf(expansion[0]);
                        string expanded = string.Join(":", expansion);
                        library.Insert(index + 1, expanded);
                    }
                }
                
                commands = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", library));
        }
    }
}