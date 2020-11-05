using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Interfaces;

namespace Interfaces.Models
{
    class Automobile : IAutoMobileActions, ICarActions
    {
        private bool _isOn;

        public bool IsON
        {
            get { return _isOn; }
            private protected set { _isOn = value; }
        }
        public Automobile() //default
        {
            //this._isOn = true;
        }

        public Automobile(bool Ison) // overloaded
        {
            this._isOn = Ison;
        }

        public void Start()
        {
            this._isOn = true;

        }
        public void Stop()
        {
            this._isOn = false;
        }

        public void SteerLeft(bool s) // KANW HIDE TIN METHODO TIS AUTOMOBILE KAI EKTELW TIN PARAKATW 
        //MIA ABSTRACT METHODO TIN YPOXREWNW OPOIA CLASS KANEI INHERITE MIA ABS CLASS ME ABS METHODO NA PREPEI NA EKTELESEI TIN ABSTARCT METHODO
        {
            Console.WriteLine("The motorbike is sterring left:" + s);
        }
        public void SteerRight(bool s)
        {
            Console.WriteLine("The motorbike is steering right:" + s);
        }
            public void Steer(bool steerLeft)
            {
                Console.WriteLine("The motorbike is steering :" + steerLeft);
            }

            public void Break()
            {
                Console.WriteLine("The motorbike is breaking");
            }

            public void Reverse()
            {
                Console.WriteLine("Reverse");
            }

        }
    }

