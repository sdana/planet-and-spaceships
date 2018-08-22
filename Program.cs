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
                    {"Mariner 10", "Mercury"}, 
                    {"MESSENGER", "Mercury"},
                };
                
                Dictionary<string, string> Venus = new Dictionary<string, string>() {
                    {"Mariner 2", "Venus"}, 
                    {"Mariner 5", "Venus"},
                };

                Dictionary<string, string> Earth = new Dictionary<string, string>(){
                    {"Pioneer 10", "Earth"}, 
                    {"Pioneer 11", "Earth"}, 
                    {"Voyager", "Earth"},
                };

                Dictionary<string, string> Mars = new Dictionary<string, string>() {
                    {"Mariner 3", "Mars"},
                    {"Mariner 4", "Mars"}, 
                    {"Mariner 6", "Mars"},
                    {"Mariner 7", "Mars"},
                };

                Dictionary<string, string> Jupiter = new Dictionary<string, string>(){
                    {"Pioneer 10","Jupiter"}, 
                    {"Pioneer 11", "Jupiter"}, 
                    {"Gallileo","Jupiter"},
                };

                Dictionary<string, string> Saturn = new Dictionary<string, string>() {
                    {"Cassini", "Saturn"},
                };

                Dictionary<string, string> Uranus = new Dictionary<string, string>() {
                    {"Voyager 2", "Uranus"},
                };

                Dictionary<string, string> Neptune = new Dictionary<string, string>(){
                    {"Voyager 2", "Neptune"}
                };
                visitedPlanets.Add(Mercury);
                visitedPlanets.Add(Venus);
                visitedPlanets.Add(Earth);
                visitedPlanets.Add(Mars);
                visitedPlanets.Add(Jupiter);
                visitedPlanets.Add(Saturn);
                visitedPlanets.Add(Uranus);
                visitedPlanets.Add(Neptune);

                foreach (string planet in planetList)
                {
                    System.Console.WriteLine($"Visitors to {planet}:");
                    foreach (Dictionary<string, string> probeList in visitedPlanets)
                    {
                        foreach (KeyValuePair<string, string> probePlanet in probeList)
                        {
                           if (probePlanet.Value == planet)
                           {
                               System.Console.WriteLine(probePlanet.Key);
                           }
                        }
                    }
                }

        }
    }
}
