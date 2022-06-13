namespace DesignPatterns.Paterns.Factory
{
    public enum VehicleType { CAR = 1, TRUCK, BIKE };
    public class VehicleSupplier
    {
        public enum VehicleType { CAR = 1, TRUCK, BIKE };
        public static IVehicle GetVehicle(VehicleType vType)
        {
            switch (vType)
            {
                case VehicleType.CAR:
                    return new Car();
                case VehicleType.TRUCK:
                    return new Truck();
                case VehicleType.BIKE:
                    return new Bike();
            }
            return null;
        }
    }

    public class Bike : IVehicle
    {
    }

    internal class Truck : IVehicle
    {
    }

    internal class Car : IVehicle
    {
    }
}