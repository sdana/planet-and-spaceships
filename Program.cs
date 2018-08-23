using System;
using System.Collections.Generic;

namespace PlanetAndSpaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> outerPlanets = new List<string>(){"Uranus", "Neptune"};
            planetList.AddRange(outerPlanets);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            List<string> rockyPlanets = new List<string>();
            rockyPlanets = planetList.GetRange(0,4);
            planetList.Remove("Pluto");

            List<Dictionary<string, string>> visitedPlanets = new List<Dictionary<string, string>>();
                Dictionary<string, string> Mercury = new Dictionary<string, string>() {
                    {"Mercury","Mariner 10"}, 
                };
                
                Dictionary<string, string> Venus = new Dictionary<string, string>() {
                    {"Venus", "Mariner 10"},
                };

                Dictionary<string, string> Mars = new Dictionary<string, string>() {
                    {"Mars", "Mariner 3"},
                };

                Dictionary<string, string> Jupiter = new Dictionary<string, string>(){
                    {"Jupiter", "Gallileo"},
                };

                Dictionary<string, string> Saturn = new Dictionary<string, string>() {
                    {"Saturn", "Cassini"},
                };

                Dictionary<string, string> Uranus = new Dictionary<string, string>() {
                    {"Uranus", "Voyager 2"},
                };

                Dictionary<string, string> Neptune = new Dictionary<string, string>(){
                    {"Neptune", "Voyager 2"}
                };
                visitedPlanets.Add(Mercury);
                visitedPlanets.Add(Venus);
                visitedPlanets.Add(Mars);
                visitedPlanets.Add(Jupiter);
                visitedPlanets.Add(Saturn);
                visitedPlanets.Add(Uranus);
                visitedPlanets.Add(Neptune);

                foreach (string planet in planetList)
                {
                    List<string> probeNames = new List<string>();
                    foreach (Dictionary<string, string> probe in visitedPlanets)
                    {
                        if (probe.ContainsKey(planet))
                        {
                            probeNames.Add(probe[planet]);
                        }
                    }
                    System.Console.WriteLine($"{planet} has been visited by: {String.Join(",", probeNames)}");
                }

        }
    }
}
