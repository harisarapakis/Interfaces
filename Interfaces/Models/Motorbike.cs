using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Interfaces;

namespace Interfaces.Models
{
    class Motorbike : Automobile, IAutoMobileActions, IMotorBikeActions//inherite
    {
        public Motorbike()
        {

        }
        public Motorbike(bool ison)
        {
            this.IsON = ison;
        }
        public void SteerLeft(bool steer) // KANW HIDE TIN METHODO TIS AUTOMOBILE KAI EKTELW TIN PARAKATW 
        //MIA ABSTRACT METHODO TIN YPOXREWNW OPOIA CLASS KANEI INHERITE MIA ABS CLASS ME ABS METHODO NA PREPEI NA EKTELESEI TIN ABSTARCT METHODO
        {
            Console.WriteLine("The motorbike is sterring left:" + steer);
        }
        public void SteerRight(bool steer)
        {
            Console.WriteLine("The motorbike is steering right:"+steer);
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
    

