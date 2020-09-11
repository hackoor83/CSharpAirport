using System;
using System.Collections.Generic;
using System.Text;

namespace AirportAssignment.cmd.Models
{
    abstract class Airplane
    {
        public string PlaneId { get; set; }

        public abstract void TakeOff();
        public abstract void Land();
    }
}
