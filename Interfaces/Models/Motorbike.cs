using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Interfaces;

namespace Interfaces.Models
{
    class Motorbike : Automobile,IAutoMobileActions//inherite
    {
        public Motorbike()
        {

        }
        public Motorbike(bool ison)
        {
            this.IsON = ison;
        }
        public void SteerLeft() // KANW HIDE TIN METHODO TIS AUTOMOBILE KAI EKTELW TIN PARAKATW 
        //MIA ABSTRACT METHODO TIN YPOXREWNW OPOIA CLASS KANEI INHERITE MIA ABS CLASS ME ABS METHODO NA PREPEI NA EKTELESEI TIN ABSTARCT METHODO
        {
            Console.WriteLine("The motorbike is sterring left");
        }
        public void SteerRight()
        {
            Console.WriteLine("The motorbike is steering right");
        }
        public void Steer(bool steerLeft)
        {
            Console.WriteLine("The motorbike is steering :" + steerLeft);
        }

        public void Break()
        {
            Console.WriteLine("The motorbike is breaking");
        }
    }
}
    

