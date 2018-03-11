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
            //разогнаться до скорости , превышающей максимальный предел автомобиля, для выдачи исключения
            try
            {
                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            catch(Exception e)
            {
                Console.WriteLine("**** Error!!!****\n");// Ошибка
                Console.WriteLine("Method: {0}", e.TargetSite);// Метод
                Console.WriteLine("Message: {0}",e.Message);//Сообщение
                Console.WriteLine("Source: {0}", e.Source); //Источник
            }
            //Ошибка была обработана,продолжаетсявыполнение следующегооператора
            Console.WriteLine("\n**** Out of exception logic ****");
            Console.ReadLine();
        }
    }
}
