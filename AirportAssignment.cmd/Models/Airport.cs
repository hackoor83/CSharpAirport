using System;
using System.Collections.Generic;
using System.Text;

namespace AirportAssignment.cmd.Models
{
    class Airport
    {
        private string AirportName { get; set; }
        private List<Airplane> airplanesList = new List<Airplane>();
        
        public Airport(string name, PeoplePlane ap1, PeoplePlane ap2, PeoplePlane ap3)
        {
            AirportName = name;
            airplanesList.Add(ap1);
            airplanesList.Add(ap2);
            airplanesList.Add(ap3);
        }

        //List all airplanes: 
        public void ListAirplanes()
        {
            Console.WriteLine($"{AirportName} airport has the following airplanes: \n");
            foreach(var airplane in airplanesList)
            {
                if(airplane is PeoplePlane)
                {
                    var peopleplane = airplane as PeoplePlane;   //Used this instead of direct casting. Can explicit casting work in the code below?
                    Console.WriteLine($"Type: Passenger plane, ID: {peopleplane.PlaneId}, Vacant seats: {peopleplane.MaxSeats - (peopleplane.NumPassengers)}.\n");
                }
                else if(airplane is CargoPlane)
                {
                    var cargoplane = airplane as CargoPlane;
                    Console.WriteLine($"Type: Cargo plane, ID: {cargoplane.PlaneId}, Vacant capacity: {cargoplane.MaxWeight - cargoplane.CurrentCargoWeight}.\n");
                }
            }
        }


        //Request list of landed planes with vacant capacity/seats:
        public void RequestPlaneDetails()
        {
            Console.WriteLine($"The following airplanes are landed: \n");
            foreach(var airplane in airplanesList)
            {
                if(airplane is PeoplePlane)
                {
                    var peopleplane = airplane as PeoplePlane;
                    if (peopleplane.IsFlying == false & (peopleplane.MaxSeats - peopleplane.NumPassengers) >= 0)
                    {
                        Console.WriteLine($"{peopleplane.PlaneId} with {(peopleplane.MaxSeats) - (peopleplane.NumPassengers)} vacant seats.\n");
                    }
                }
                else if(airplane is CargoPlane)
                {
                    var cargoplane = airplane as CargoPlane;
                    if (cargoplane.IsFlying == false & (cargoplane.MaxWeight - cargoplane.CurrentCargoWeight) >= 0)
                    {
                        Console.WriteLine($"{cargoplane.PlaneId} with {(cargoplane.MaxWeight) - (cargoplane.CurrentCargoWeight)} available capacity.\n");
                    }
                }                
            }
        }

        public void LoadPassengersInto(PeoplePlane intoAirplane, int newPassengers)
        {
            foreach(var airplane in airplanesList)
            {
                if (intoAirplane.PlaneId.Equals(airplane.PlaneId))
                {
                    intoAirplane.LoadPassengers(newPassengers);
                }
                
            }
        }

        //Operations on Cargo planes:

        public void AddCargoPlane(CargoPlane newCargoPlane)
        {
            airplanesList.Add(newCargoPlane);
            Console.WriteLine(value: $"The cargo plane with ID: {newCargoPlane.PlaneId} has been added to the {AirportName} airport.\n");
        }

        
        public void LoadCargoInto(CargoPlane intoCargoplane, int newCargo)
        {
            foreach (var airplane in airplanesList)
            {
                if(airplane is CargoPlane)
                {
                    //var cargoplane = airplane as CargoPlane;
                    var cargoplane = (CargoPlane)airplane;
                    if (intoCargoplane.PlaneId.Equals(cargoplane.PlaneId))
                    {
                        intoCargoplane.LoadCargo(newCargo);
                    }
                }

            }
        }



    }
}
