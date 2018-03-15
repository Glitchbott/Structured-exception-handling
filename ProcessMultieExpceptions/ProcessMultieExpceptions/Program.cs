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
            myCar.CrankTunes(true);
            try
            {
                myCar.Accelerate(90);
            }
            catch (CarIsDeadException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //Этот блок будет выполнятьсявсегда, вознило исключение или нет
                myCar.CrankTunes(false);
            }

            Console.ReadLine();
            }
        }
    }
