namespace Garage
{
    public class Ram : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; } = 26;
        public double FuelLevel { get; set; } = 0;
        public double CurrentTankPercentage { get => (FuelLevel / FuelCapacity) * 100; }
        public void RefuelTank()
        {
            FuelLevel = 26;
        }
        public void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives past, RRRuuuuummmmmbbblllee!");
        }
        public void Turn(string direction) 
        {
            Console.WriteLine($"The {MainColor} Ram carefully turns {direction}.");
        }
        public void Stop() 
        {
            Console.WriteLine($"The {MainColor} Ram gently rolls to a stop.");
        }
    }
}