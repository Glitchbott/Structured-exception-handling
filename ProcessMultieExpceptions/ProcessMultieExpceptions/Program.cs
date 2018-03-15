﻿using System;
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
                myCar.Accelerate(-10);
            }
            catch(CarIsDeadException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
