namespace Garage
{
    public class Zero : Vehicle , IElectricVehicle
    {
        public double BatteryKWh { get; set; } = 0;
        public double FullChargeKWh { get; set; } = 14.4;

        public double CurrentChargePercentage {get => (BatteryKWh / FullChargeKWh) * 100; }
        public void ChargeBattery()
        {
            BatteryKWh = 14.4;
        }
        public void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you, Yeeeeeeeeeeooooooowww!");
        }
        public void Turn(string direction) 
        {
            Console.WriteLine($"The {MainColor} Zero carefully turns {direction}.");
        }
        public void Stop() 
        {
            Console.WriteLine($"The {MainColor} Zero gently rolls to a stop.");
        }
    }
}