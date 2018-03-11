using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Simple Expection Example****\n");
            Console.WriteLine("=>  Creating a car and stepping on it!");
            Car myCar = new Car("Zip", 10);
            myCar.CrankTunes(true);
            for (int i = 0; i < 10; i++)
                myCar.Accelerate(10);
            Console.ReadLine();
        }
    }
}
