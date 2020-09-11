using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace AirportAssignment.cmd.Models
{
    class PeoplePlane : Airplane, IJet
    {
        internal new string PlaneId { get; set; }
        internal int MaxSeats { get; set; }
        internal int NumPassengers { get; set; } 
        internal bool IsFlying { get; set; }
        internal double CruiseSpeed { get; set; }

            
        public PeoplePlane(string planeId, int maxSeats, int numPassengers, bool isFlying, double cruiseSpeed)
        {
            this.PlaneId = planeId;
            this.MaxSeats = maxSeats;
            this.NumPassengers = numPassengers;
            this.IsFlying = isFlying;
            this.CruiseSpeed = cruiseSpeed;
        }

        public void LoadPassengers(int newPassengers)
        {
            if ((MaxSeats - NumPassengers) >= newPassengers)
                NumPassengers += newPassengers;
            else
                Console.WriteLine($"The aircraft {PlaneId} has only {(MaxSeats - NumPassengers)} vacant seats. Therefore, {(newPassengers - (MaxSeats - NumPassengers))} do not fit.\n");
        }

        public void UnloadPassengers(int offPassengers)
        {
            if (NumPassengers == 0)
                Console.WriteLine($"No passengers in the airplane.\n");
            else
                NumPassengers -= offPassengers;
        }


        public override string ToString()
        {
            return $"Type: Passenger Plane \n Plane ID: {this.PlaneId} \n Status: {(IsFlying ? "Flying" : "Landed")} \n Current number of passengers: {this.NumPassengers}.\n";
            
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

        public void StartStarterMotor()
        {
            //
        }


    }
}
