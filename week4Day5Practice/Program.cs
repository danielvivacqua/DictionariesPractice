using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4Day5Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, int> studentScores = new Dictionary<string, int>();
            //studentScores.Add("StudentA", 89);
            //studentScores.Add("StudentB", 75);
            //studentScores.Add("StudentC", 94);
            //studentScores.Add("StudentD", 98);

            //Console.WriteLine(studentScores["StudentC"]);

            //Dictionary<int,string> coatCheck = new Dictionary<int,string>();
            //coatCheck.Add(1,"Peacoat");
            //coatCheck.Add(2,"Trenchcoat");
            //coatCheck.Add(3, "Bomber");
            //coatCheck.Add(4, "Blazer");
            //coatCheck.Add(5, "Denim Jacket");
            //coatCheck.Add(6, "Members Only");
            //coatCheck.Add(7, "Anorak");
            //coatCheck.Add(8, "Rain coat");
            //coatCheck.Add(9, "Tweed coat");
            //coatCheck.Add(10, "Motorcycle Jacket");

            //foreach(KeyValuePair<int,string> coat in coatCheck)
            //{
            //    Console.WriteLine(coat);
            //}

            //Dictionary<string, string> carValet = new Dictionary<string, string>();
            //carValet.Add("Jones", "BMW");
            //carValet.Add("Bond", "Audi");
            //carValet.Add("Wayne", "Batmobile");
            //carValet.Add("Kent", "Cape");
            //carValet.Add("Prince", "Invisible Jet");
            //carValet.Add("Prince2", "Corvette");
            //carValet.Add("Potter", "FireBolt");
            //carValet.Add("Aladdin", "Magic Carpet");
            //carValet.Add("Lightyear", "Space Ship");
            //carValet.Add("Solo", "Millenium Falcon");

            //foreach(KeyValuePair<string,string> vehicle in carValet)
            //{
            //    Console.WriteLine(vehicle);
            //}

            Dictionary<string, int> zooAnimals = new Dictionary<string, int>();
            zooAnimals.Add("Pangolin", 2);
            zooAnimals.Add("Tamarin", 3);
            zooAnimals.Add("Tapier", 10);
            zooAnimals.Add("Armadillo", 6);
            zooAnimals.Add("Capabara", 8);
            zooAnimals.Add("Honey Badger", 1);
            zooAnimals.Add("Red Panda", 14);
            zooAnimals.Add("Orangutan", 8);
            zooAnimals.Add("Ring-tailed Lemur", 4);
            zooAnimals.Add("Bald Eagle", 1);

           
            //var valueForMaxAnimals = zooAnimals.FirstOrDefault(x => x.Value == zooAnimals.Values.Max()).Key;
            //Console.WriteLine(valueForMaxAnimals);

            int holder = 0;

            foreach (var amount in zooAnimals)
            {
                if (amount.Value > holder)
                {
                    holder = amount.Value;
                }
            }
            
            foreach (var find in zooAnimals)
            {
                if (holder == find.Value)
                {
                    Console.WriteLine(find.Key);
                }
            }

            //create a variable to hold the highest int value in the dictionary
            //loop through the dictionary and test each element's value against the holder variable
            //if the element's value is greater than the holder variable, replace the value
            //after the loop, holder variale has the highest value found in the dictionary
            //loop through the dictionary again
            //this time check each element's value against the holder variable
            //if they match, print that element's key
        }
    }
}
