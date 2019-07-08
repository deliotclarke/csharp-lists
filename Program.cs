using System;
using System.Collections.Generic;

namespace lists
{
  class Program
  {
    static void Main(string[] args)
    {

      List<string> planetList = new List<string>() { "Mercury", "Mars" };

      List<string> morePlanetList = new List<string>() { "Jupiter", "Saturn" };

      planetList.AddRange(morePlanetList);

      planetList.ForEach(planet => Console.WriteLine(planet));

      List<string> lastTwoPlanetsList = new List<string>() { "Uranus", "Neptune" };

      planetList.AddRange(lastTwoPlanetsList);

      Console.WriteLine("after last two added: ");
      planetList.ForEach(planet => Console.WriteLine(planet));

      List<string> twoMorePlanets = new List<string>() { "Venus", "Earth" };

      planetList.InsertRange(1, twoMorePlanets);

      Console.WriteLine("after venus and earth: ");
      planetList.ForEach(planet => Console.WriteLine(planet));

      List<string> rockyPlanets = planetList.GetRange(0, 4);
      Console.WriteLine("Rocky Planets: ");
      rockyPlanets.ForEach(planet => Console.WriteLine(planet));

      Console.WriteLine("Planet list after GetRange(): ");
      planetList.ForEach(planet => Console.WriteLine(planet));

      //interestingly, planet list still contains all planets despite using get range to remove all the rocky planets
      Console.WriteLine("End of planets exercise");

      //start of Random Numbers exercise

      Random random = new Random();
      List<int> numbers = new List<int> {
        random.Next(6),
        random.Next(6),
        random.Next(6),
        random.Next(6),
        random.Next(6),
        random.Next(6),
      };

      Console.WriteLine("Using Contains with if/else: ");
      for (int i = 0; i < numbers.Count; i++)
      {
        if (numbers.Contains(i))
        {
          Console.WriteLine($"List does contain {i}");
        }
        else
        {
          Console.WriteLine($"List does not contain {i}");
        }
      }

      Console.WriteLine("Using Contains with Ternary: ");
      for (int i = 0; i < numbers.Count; i++)
      {
        string output = numbers.Contains(i) ? $"List does contain {i}" : $"List does not contain {i}";
        Console.WriteLine(output);
      }

      // try to use .exists
      Console.WriteLine("Using Exists: ");
      for (int i = 0; i < numbers.Count; i++)
      {
        if (numbers.Exists(x => x == i))
        {
          Console.WriteLine($"{i} exists in our List");
        }
        else
        {
          Console.WriteLine($"{i} does not exist in our List");
        }
      }

    }
  }
}
