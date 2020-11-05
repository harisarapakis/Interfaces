﻿using System;
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
            car.SteerLeft(true);
            car.SteerRight(false);
            car.Steer(true);
            Console.WriteLine(car.IsON);

            Console.WriteLine("Moto");
            Motorbike moto = new Motorbike();
            moto.Stop();
            Console.WriteLine(moto.IsON);
            moto.SteerLeft(true);
            moto.SteerRight(false);
            moto.Steer(true);

            Console.WriteLine("Boat");
            Boat boat = new Boat();
            boat.Stop();
            Console.WriteLine(moto.IsON);
            //boat.SteerLeft(true);
            //boat.SteerRight(false);
            boat.Steer(true);

            Console.WriteLine();
          

        }
    }
}
