using System;
using System.Collections.Generic;
using System.Text;

namespace AirportAssignment.cmd.Models
{
    class SpacePlane : Airplane, IJet, IMissle
    {
        public SpacePlane(string planeId, bool isFlying)
        {
            PlaneId = planeId;
            IsFlying = isFlying;
        }

        public new string PlaneId { get; set; }
        public bool IsFlying { get; set; }

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
            Console.WriteLine($"The space craft: {PlaneId} started the motor!");
        }

        public void LoadMissles()
        {
            Console.WriteLine($"The space craft: {PlaneId} Loaded the missles!");
        }

    }
}
