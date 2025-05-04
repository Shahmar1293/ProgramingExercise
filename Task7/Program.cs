using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Birinci rəqəmi daxil edin: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("İkinci rəqəmi daxil edin: ");
                double b = Convert.ToDouble(Console.ReadLine());

                double netice = a / b;
                Console.WriteLine("Nəticə: " + netice);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Xəta: Sıfıra bölmək olmaz!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Xəta: Düzgün rəqəm daxil edilməyib.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Naməlum xəta baş verdi: " + ex.Message);
            }

            Console.WriteLine("Proqram bitdi.");

        }
    }
}
