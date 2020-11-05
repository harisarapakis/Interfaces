using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Interfaces;

namespace Interfaces.Models
{
     class Automobile
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

        //abstract public void SteerLeft();
        //abstract public void SteerRight();
        //abstract public void Steer(bool steerLeft);

        //{
        //    Console.WriteLine($"The {message} is sterring left");
        //}
    }
    
}
