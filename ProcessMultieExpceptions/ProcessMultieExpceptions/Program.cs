using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultieExpceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Handing Multiple Exceptions\n");
            Car myCar = new Car("Rusty", 90);
            try
            {
                myCar.Accelerate(90);
            }
            catch
            {
                Console.WriteLine("Something bad happened  ");
            }
            
            Console.ReadLine();
        }
    }
}
