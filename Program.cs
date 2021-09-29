using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dogs dog1 = new Dogs() {breed = "Beagle",name ="Charli"  };
            Dogs dog2 = new Dogs() { breed = "Bulldog", name = "Rich" };
            Dogs dog3 = new Dogs() { breed = "Spaniel", name = "Alf" };
            Dogs dog4 = new Dogs() { breed = "English setter", name = "Viliam" };
            List<Dogs> dogs = new List<Dogs>();
            dogs.Add(dog1);
            dogs.Add(dog2);
            dogs.Add(dog3);
            dogs.Add(dog4);
           
            foreach (var Dogs in dogs) 
            {if (Dogs.breed == "English setter")
                {
                    Console.WriteLine("Yep, we have English sette, his name is {0}", Dogs.name);
                }
            }

        }
    }
}
 