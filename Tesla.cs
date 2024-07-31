namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; } = 0;
        public double FullChargeKWh { get; set; } = 100;

        public double CurrentChargePercentage {get => (BatteryKWh / FullChargeKWh) * 100; }
        public void ChargeBattery()
        {
            BatteryKWh = 100;
        }
        public void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla blazes by you, MMmmmmmmmm!");
        }
        public void Turn(string direction) 
        {
            Console.WriteLine($"The {MainColor} Tesla squeals around a {direction} turn.");
        }
        public void Stop() 
        {
            Console.WriteLine($"The {MainColor} Tesla silently stops as if it never moved.");
        }
    }
}