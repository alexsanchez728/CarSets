using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an empty HashSet named Showroom that will contain strings.
            var Showroom = new HashSet<string>();

            //Add four of your favorite car model names to the set.
            Showroom.Add("Golf GT");
            Showroom.Add("Outlander");
            Showroom.Add("Aventador");
            Showroom.Add("FJ Cruiser");

            //Print to the console how many cars are in your show room.
            Console.WriteLine($"{Showroom.Count()} cars in the showroom");

            //Pick one of the items in your show room and add it to the set again.
            Showroom.Add("Outlander");

            //Print your showroom again, and notice how there's still only one representation of that model in there.
            Console.WriteLine($"{Showroom.Count()} cars in the showroom even after adding 1 car twice");

            //Create another set named UsedLot and add two more car model strings to it.
            var UsedLot = new HashSet<string>()
            {
                "Accord",
                "Sonata"
            };

            //Use the UnionWith() method on Showroom to add in the two models you added to UsedLot.
            Showroom.UnionWith(UsedLot);
            Console.WriteLine($"{Showroom.Count()} cars in the showroom AND the used lot");

            //You've sold one of your cars. Remove it from the set with the Remove() method.
            Showroom.Remove("Aventador");

            //Acquiring more cars

            //Now create another HashSet of cars in a variable Junkyard. Someone who owns a junkyard full of old cars has approached you about buying the entire inventory. In the new set, add some different cars, but also add a few that are the same as in the Showroom set.
            var Junkyard = new HashSet<string>()
            {
                "CR-V",
                "Grand Cherokee",
                "Golf GT",
                "Outlander"
            };
            //Use the IntersectWith() method to see which cars exist in both the show room and the junkyard.
            // ExceptWith() method leaves the cars that match the Showroom out of the junkyard HashSet.
            Junkyard.ExceptWith(Showroom);
            //^ items that intersect are removed

            //Now you're ready to buy the cars in the junkyard. Use the UnionWith() method to combine the junkyard into your showroom.
            Showroom.UnionWith(Junkyard);

            //Use the Remove() method to remove any cars that you acquired from the junkyard that you don't want in your showroom.
            Junkyard.Remove("CR-v");

            foreach (var car in Showroom)
            {
                Console.WriteLine($"in showroom: {car}");
            };

            Console.ReadKey();
        }
    }
}
