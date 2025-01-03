using trisatenergy_api_rawdataprovider.SmartMeterSimulation.EnergySources;

namespace trisatenergy_api_rawdataprovider.SmartMeterSimulation;

public class SmartMeterResultPayload
{
    public DateTime Timestamp { get; set; }
    public double TotalProduction { get; set; }
    public Dictionary<EnergySourceType, double> ProductionBySource { get; set; }
    public double TotalConsumption { get; set; }
    public bool MaintenanceMode { get; set; }
}