using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Home_Work
{
    internal class Country
    {
       public string Name;

        public static int count;

       public  List<City> allCity = new List<City>();

        static Country()
        {
            count = 0;
        }


        public Country(string name)
        {
            Name = name;            
        }


        public int TotalPopulation()
        {
            foreach (var x in allCity)
            {
               count += x.Population;

            }
            Console.WriteLine($"{Name}");
            return count;
          
        }

        public void FindAllByPopulation(int min, int max)
        {
            List<City> newCity = new List<City>();

            foreach (var x in allCity)
            {
                if (x.Population > min  && x.Population < max)
                {
                    newCity.Add(x);

                    Console.WriteLine($"{x.Name} {x.Population}");
                }

            }

        }

      
    }
}
