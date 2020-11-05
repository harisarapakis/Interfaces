﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    interface IMotorBikeActions
    {
        void SteerLeft(bool s);
        void SteerRight(bool s);
        void Steer(bool steerLeft);
        void Break();
        void Reverse();
    }
}
