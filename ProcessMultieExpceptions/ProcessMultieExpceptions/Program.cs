using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            catch (CarIsDeadException e)
            {
                try
                {
                    FileStream fs = File.Open(@"C:carErrors.txt", FileMode.Open);

                }
                catch (Exception e2)
                {
                    throw new CarIsDeadException(e.Message, e2);
                }

                Console.ReadLine();
            }
        }
    }
}