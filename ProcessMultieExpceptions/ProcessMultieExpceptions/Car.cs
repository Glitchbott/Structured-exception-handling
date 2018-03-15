using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultieExpceptions
{
    class Car
    {
        // максимальн скорость
        public const int MaxSpeed = 100;
        // св-ва автомобиля
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }
        // не вышел ли автомобильиз стоя?
        public bool carDead;
        // автомобиль имеет радиоприемник
        private Radio MusicBox = new Radio();
        //конструкторы
        public Car() {}
        public Car(string name, int speed)
        {
            PetName = name;
            CurrentSpeed = speed;
        }
        public void CrankTunes(bool state)
        {
            // делегировать запрос внутреннему объекту
            MusicBox.TurnOn(state);
        }
        // Проверить аргумент на предмет допустимости перед продолжение
        public void Accelerate(int delta)
        {
            if (delta < 0)
                throw new
                    ArgumentOutOfRangeException("delta", "Speed must be greater than zero!");
            if (carDead)
                Console.WriteLine("{0}  is out of order...", PetName);
            else
            {
                CurrentSpeed += delta;

                if(CurrentSpeed >= MaxSpeed)
                {
                    Console.WriteLine("{0}  has over !", PetName);
                    CurrentSpeed = 0;
                    carDead = true;
                    // Создаем локальную переменную перед генерац Exeption объекта чтобы можно былообращ к св-ву HelpLink
                    Exception ex = new Exception(string.Format("{0} has over!", PetName));
                    ex.HelpLink = "http://www.CarsRUs.com";
                    
                    //Указать специальные данные , касающиеся ошибки.
                    ex.Data.Add("TimesStamp",string.Format("The car exploed at {0}",DateTime.Now));//метка времени
                    ex.Data.Add( "Cause","You have a lead foot");//причина
                    throw ex;
                    // Ключевое слово throw для генерации исключения
                    // throw new Exception(string.Format("{0} has over speed ! ", PetName));
                }
                else
                    Console.WriteLine("=>  CurrenSpeed = {0}", CurrentSpeed);
            }
        }
            
    }
}
