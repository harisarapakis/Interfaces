using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Interfaces;

namespace Interfaces.Models
{
    class Boat : Automobile,IAutoMobileActions, IBoatActions
    {
        public Boat() //default
        {
            //this._isOn = true;
        }

        public Boat(bool ison) // overloaded
        {
            this.IsON = ison;
        }


        public void SteerLeft(bool s) // KANW HIDE TIN METHODO TIS AUTOMOBILE KAI EKTELW TIN PARAKATW 
        //MIA ABSTRACT METHODO TIN YPOXREWNW OPOIA CLASS KANEI INHERITE MIA ABS CLASS ME ABS METHODO NA PREPEI NA EKTELESEI TIN ABSTARCT METHODO
        {
            Console.WriteLine("The boat is sterring left:"+s);
        }
        public void SteerRight(bool s)
        {
            Console.WriteLine("The boat is steering right:" + s);
        }
        public void Steer(bool steerLeft)
        {
            Console.WriteLine("The boat is steering :" + steerLeft);
        }

        public void Break()
        {
            Console.WriteLine("The boat can't break");
        }

          public void Reverse()
        {
            Console.WriteLine("Reverse");
        }
    }
}
