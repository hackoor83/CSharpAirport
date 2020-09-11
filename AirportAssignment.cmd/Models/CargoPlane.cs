using System;
using System.Collections.Generic;
using System.Text;

namespace AirportAssignment.cmd.Models
{
    class CargoPlane : Airplane, IPropeller
    {
        internal new string PlaneId { get; set; }
        internal bool IsFlying { get; set; }
        internal int MaxWeight { get; set; }
        internal int CurrentCargoWeight { get; set; }

        public CargoPlane(string planeId, bool isFlying, int currentCargoWeight)
        {
            PlaneId = planeId;
            IsFlying = isFlying;
            CurrentCargoWeight = currentCargoWeight;
            MaxWeight = 20;
        }

        public void LoadCargo(int weight)
        {
            if (weight > 0 & weight <= MaxWeight)
                CurrentCargoWeight += weight;
            else
                Console.WriteLine($"The available cargo capacity in cargoPlane {PlaneId} is {(MaxWeight - CurrentCargoWeight)} tons only.\n");
        }

        public void DischargeCargo()
        {
            if (CurrentCargoWeight > 0)
            {
                CurrentCargoWeight = 0;
                Console.WriteLine($"All cargo in cargo plane {PlaneId} discharged.\n");
            }
            else Console.WriteLine($"No cargo in this cargo plane.\n");
        }

        public override string ToString()
        {
            return $"Type: Cargo Plane \n Plane ID: {this.PlaneId} \n Status: {(IsFlying? "Flying":"Landed")} \n Current load in tons: {this.CurrentCargoWeight}.\n";
        }


        public override void TakeOff()
        {
            if (IsFlying == false)
            {
                IsFlying = true;
                Console.WriteLine($"Aircraft {PlaneId} took off.\n");
            }
            else Console.WriteLine($"Cannot take off {PlaneId} aircraft while it is flying!\n");
        }

        public override void Land()
        {
            if (IsFlying)
            {
                IsFlying = false;
                Console.WriteLine($"Aircraft {PlaneId} landed.\n");
            }
            else
            {
                Console.WriteLine($"The aircraft {PlaneId} is already on land.\n");
            }
        }

        public void TightenProperllers()
        {
            //Tighten propellers.
        }
        

    }
}
