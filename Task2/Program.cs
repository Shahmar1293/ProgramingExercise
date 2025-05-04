using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2


{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            CarRent myCar = new CarRent
            {
                Brand = "Toyota",
                Model = "Corolla",
                Year = 2020
            };

            myCar.Drive();  // Konsolda: Car is driving
        }
    }
}
