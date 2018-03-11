using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
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
        // Проверка не сдох ли автомобиль
        public void Accelerate(int delta)
        {
            if (carDead)
                Console.WriteLine("{0}  is out of order...", PetName);
            else
            {
                CurrentSpeed += delta;

                if(CurrentSpeed > MaxSpeed)
                {
                    Console.WriteLine("{0}  has over !", PetName);
                    CurrentSpeed = 0;
                    carDead = true;
                }
                else
                    Console.WriteLine("=>  CurrenSpeed = {0}", CurrentSpeed);
            }
        }
            
    }
}
