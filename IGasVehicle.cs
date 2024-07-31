public interface IGasVehicle
{
    double FuelCapacity { get; set; }
    double FuelLevel { get; set; }
    double CurrentTankPercentage { get; }
    void RefuelTank();
    void Drive();
}