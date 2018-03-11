using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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
            //Свойство TargetSite возвращает объект MethodBase
            catch(Exception e)
            {
                // По умолчанию поле данных является пустым, поэтому проверить его на null
                Console.WriteLine("\n-> Custom Data: ");
                if(e.Data !=null)
                {
                    foreach (DictionaryEntry de in e.Data)
                        Console.WriteLine("-> {0} : {1}", de.Key,de.Value);
                }
                Console.WriteLine("**** Error!!!****\n");// Ошибка
                Console.WriteLine("HelpLink: {0}", e.HelpLink);// HelpLink
                Console.WriteLine("Member name: {0}", e.TargetSite);// имя члена
                Console.WriteLine("Class defining member: {0}", e.TargetSite.DeclaringType);// класс, определяющ член
                Console.WriteLine("Member type: {0}", e.TargetSite.MemberType);// тип члена
                Console.WriteLine("Message: {0}",e.Message);//Сообщение
                Console.WriteLine("Source: {0}", e.Source); //Источник
                Console.WriteLine("Stack: {0}", e.StackTrace); //стек

            }
            //Ошибка была обработана,продолжаетсявыполнение следующегооператора
            Console.WriteLine("\n**** Out of exception logic ****");
            Console.ReadLine();
        }
    }
}
