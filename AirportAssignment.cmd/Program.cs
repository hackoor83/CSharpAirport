using AirportAssignment.cmd.Models;
using System;

namespace AirportAssignment.cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Airplanes controller: \n");
            Console.Beep();

            var ABC123 = new PeoplePlane("ABC123", 50, 0, false, 350);
            var DDD888 = new PeoplePlane("DDD888", 35, 0, false, 450);
            var SSS777 = new PeoplePlane("SSS777", 70, 0, false, 250);

            //Operations on ABC123:
            Console.WriteLine($"Operations on {ABC123.PlaneId}: \n");
            Console.Beep(3000, 300);
            ABC123.LoadPassengers(43);
            ABC123.TakeOff();
            ABC123.Land();
            ABC123.UnloadPassengers(43);


            //Operations on DDD888
            Console.WriteLine($"Operations on {DDD888.PlaneId}: \n");
            DDD888.LoadPassengers(23);
            DDD888.TakeOff();
            DDD888.Land();
            DDD888.UnloadPassengers(23);

            //Creating airport with airplanes
            var eindhovenAirport = new Airport("Eindhoven",ABC123, DDD888, SSS777);

            //Operations on the airport:
            eindhovenAirport.ListAirplanes();
            eindhovenAirport.RequestPlaneDetails();
            eindhovenAirport.LoadPassengersInto(ABC123, 55);

            //Instantiating cargo planes
            var FF2134 = new CargoPlane("FF2134", false, 0);
            var PLA166 = new CargoPlane("PLA166", false, 0);
            
            //Adding the two cargo planes to the airport Eindhoven:
            eindhovenAirport.AddCargoPlane(FF2134);
            eindhovenAirport.AddCargoPlane(PLA166);

            //Operations on the cargo planes
            eindhovenAirport.LoadCargoInto(FF2134, 17);

            //Calling the overriden ToString method
            Console.WriteLine(FF2134);
            Console.WriteLine(PLA166);

            Console.WriteLine(ABC123);
            Console.WriteLine(DDD888);
            Console.WriteLine(SSS777);

            Console.Beep();

            //The spaceship
            var SPACE123 = new SpacePlane("SPACE123", false);
            SPACE123.LoadMissles();
            SPACE123.StartStarterMotor();

                        
        }
    }
}
