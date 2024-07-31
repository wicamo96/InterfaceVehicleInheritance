namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; } = 742;
        public double FuelLevel { get; set; } = 0;
        public double CurrentTankPercentage { get => (FuelLevel / FuelCapacity) * 100; }
        public void RefuelTank()
        {
            FuelLevel = 742;
        }
        public void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flashes by you like a hurricane, Zzzzoooooommmm!");
        }
        public void Turn(string direction) 
        {
            Console.WriteLine($"The {MainColor} Cessna carefully turns {direction}.");
        }
        public void Stop() 
        {
            Console.WriteLine($"The {MainColor} Cessna rolls down the runway for a mile and stops.");
        }
    }
}