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

        public void SteerLeft()
        {
            Console.WriteLine("The car is steering left");
        }

        public void SteerRight()
        {
            Console.WriteLine("The car is steering right");
        }
        public void Steer(bool steerLeft)
        {
            Console.WriteLine("The car is steering :"+ steerLeft);
        }


        public void Break()
        {
            Console.WriteLine("The car is breaking");
        }
    }


}
