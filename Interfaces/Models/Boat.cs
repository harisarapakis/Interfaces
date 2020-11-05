using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Interfaces;

namespace Interfaces.Models
{
    class Boat : Automobile,IAutoMobileActions
    {
        public Boat() //default
        {
            //this._isOn = true;
        }

        public Boat(bool ison) // overloaded
        {
            this.IsON = ison;
        }
        public void Steer(bool steerLeft)
        {
            throw new NotImplementedException();
        }

        public void SteerLeft()
        {
            throw new NotImplementedException();
        }

        public void SteerRight()
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            Console.WriteLine("The boat is reversing");
        }
    }
}
