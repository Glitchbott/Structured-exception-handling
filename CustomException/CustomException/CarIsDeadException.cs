using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
       public class CarIsDeadException : ApplicationException
    {
        private string messageDetails = String.Empty;
        public DateTime ErrorTimesStamp { get; set; }
        public string CauseOfError { get; set; }
        public string PetName { get; set; }

        public CarIsDeadException() { }
        public CarIsDeadException(string message, string cause,DateTime time ) : base(message)
        {
            
            CauseOfError = cause;
            ErrorTimesStamp = time;
          
        }
        //Переопределение свойства
        public override string Message
        {
            get
            {
                return String.Format("Car Error Message: {0}", messageDetails);
            }
        }
        //Сгенерировать специальное исключение 
        public void Accelarete(int delta)
        {
            CarIsDeadException ex = new CarIsDeadException(string.Format("{0} has over!", PetName), "You have a foot", DateTime.Now);
            ex.HelpLink = "http://www.CarsRUs.com";
            throw ex;
        }
        
    }
}
