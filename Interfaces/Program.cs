using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Models;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {


            //Car car1 = new Car(true);
            //car1.IsON = false;

            Console.WriteLine("CAR");
            Car car = new Car(true);
            Console.WriteLine(car.IsON);
            car.Stop();
            car.SteerLeft();
            car.SteerRight();
            car.Steer(true);
            Console.WriteLine(car.IsON);

            Console.WriteLine("Moto");
            Motorbike moto = new Motorbike();
            moto.Stop();
            Console.WriteLine(moto.IsON);
            moto.SteerLeft();

            Console.WriteLine();
            Motorbike motorbike = new Motorbike(true);
            Console.WriteLine(motorbike.IsON);
            motorbike.SteerLeft();

        }
    }
}
