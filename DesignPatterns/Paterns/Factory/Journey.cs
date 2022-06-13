using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Paterns.Factory
{
    public class Journey
    {
        public IVehicle rentedVehicle;
        public Journey(string customerID)
        {
            VehicleType vType = Customer.GetVehicleType(customerID);
            
            rentedVehicle = VehicleSupplier.GetVehicle((VehicleSupplier.VehicleType)vType);
        }
       
        public void BeginJourney()
        {
            if (rentedVehicle != null)
            {
                rentedVehicle.Drive();
            }
        }
  
        public void ParkTheVehicle()
        {
            if (rentedVehicle != null)
            {
                rentedVehicle.Park();
            }
        }
    }

    internal class Customer
    {
        internal static VehicleType GetVehicleType(string customerID)
        {
            throw new NotImplementedException();
        }
    }
}
