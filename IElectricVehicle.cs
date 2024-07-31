public interface IElectricVehicle
{
    double BatteryKWh { get; set; }
    double FullChargeKWh { get; set; }
    double CurrentChargePercentage { get; }
    void ChargeBattery();
    void Drive();
}