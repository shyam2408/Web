using System;
using System.Collections.Generic;
using System.Linq;
class Program{
    public static void Main(string[] args)
    {
        List<string> cities =["ABU DHABI","AMSTERDAM","ROME","MADURAI","LONDON","NEW DELHI","MUMBAI","NAIROBI"];
        System.Console.WriteLine("First Letter");
        char startChar=char.ToUpper(Console.ReadLine()[0]);
        System.Console.WriteLine("Last Letter");
        char endChar=char.ToUpper(Console.ReadLine()[0]);
        var resultCities=cities.Where(c=>c.StartsWith(startChar.ToString(),StringComparison.OrdinalIgnoreCase) && c.EndsWith(endChar.ToString(),StringComparison.OrdinalIgnoreCase)).ToList();
        if(resultCities.Count != 0)
        {
            System.Console.WriteLine($"Cities found with startChar-{startChar} and endChar-{endChar}: {string.Join(",",resultCities)}");
        }
        var sortedCities=cities.OrderBy(city=>city.Length).ThenBy(city=>city).ToList();
        if(sortedCities.Count != 0)
        {
            System.Console.WriteLine($"Cities in ascending order: {string.Join(",",sortedCities)}");
        }
    }
}