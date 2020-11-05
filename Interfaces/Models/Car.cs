using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Interfaces;

namespace Interfaces.Models
{
    class Car:Automobile,IAutoMobileActions,ICarActions
    {
        public Car()
        { }
        public Car(bool Ison)
        {
            this.IsON = Ison;
        }
        public void SteerLeft(bool steer) // KANW HIDE TIN METHODO TIS AUTOMOBILE KAI EKTELW TIN PARAKATW 
        //MIA ABSTRACT METHODO TIN YPOXREWNW OPOIA CLASS KANEI INHERITE MIA ABS CLASS ME ABS METHODO NA PREPEI NA EKTELESEI TIN ABSTARCT METHODO
        {
            Console.WriteLine("The motorbike is sterring left:" + steer);
        }
        public void SteerRight(bool steer)
        {
            Console.WriteLine("The motorbike is steering right:" + steer);
        }
        public void Steer(bool steerLeft)
        {
            Console.WriteLine("The car is steering :"+ steerLeft);
        }


        public void Break()
        {
            Console.WriteLine("The car is breaking");
        }

        public void Reverse()
        {
            Console.WriteLine("Reverse");
        }
    }


}
