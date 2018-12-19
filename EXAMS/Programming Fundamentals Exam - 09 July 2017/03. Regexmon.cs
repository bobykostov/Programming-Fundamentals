using System;
using System.Text.RegularExpressions;
				
public class Program
{
	public static void Main()
	{
		string line = Console.ReadLine();
		
		string didiPattern = @"[^-A-Za-z]+";
  		string bojoPattern = @"[A-Za-z]+-[A-Za-z]+";
		
		Regex didiRegex = new Regex(didiPattern);
		Regex bojoRegex = new Regex(bojoPattern);
  
  		while (true)
		{
    			Match didiMatch = didiRegex.Match(line);
  
    			if (didiMatch.Success)
			{
      			Console.WriteLine(didiMatch);
      			line = line.Substring(didiMatch.Index + didiMatch.Length);
    			}
			else break;
			
			Match bojoMatch = bojoRegex.Match(line);
			
			if (bojoMatch.Success)
			{
        		Console.WriteLine(bojoMatch);
       			line = line.Substring(bojoMatch.Index + bojoMatch.Length);
     			}
			else break;
  		}
	}
}