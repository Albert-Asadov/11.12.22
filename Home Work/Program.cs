using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Home_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country country = new Country("Azerbaycan");

            country.allCity.Add(new City("Baki", 4000000));
            country.allCity.Add(new City("Qebele", 35000));
            country.allCity.Add(new City("Shemkir", 80000));
            country.allCity.Add(new City("Quba", 100000));
            country.allCity.Add(new City("Gence", 2000000));
            country.allCity.Add(new City("Sheki", 40000));


            Console.WriteLine(country.TotalPopulation());

            country.FindAllByPopulation(0, 4000000);
            

            


            
        }
  
    }
}