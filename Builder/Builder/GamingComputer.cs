namespace Builder;

public class GamingComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public GamingComputerBuilder()
    {
        Initialize();

    }

    public void Initialize()
    {
        Console.WriteLine("Complete Setup:");
        _computer = new Computer
        {
            CPU = "Default CPU",
            RAM = "Default RAM",
            Storage = "Default Storage",
            Motherboard = "Default Motherboard",
            PowerSupply = "Default Power Supply",
            Case = "Default Case",
            Peripherals = new List<string> { "Default Peripheral" }
        };
    }

    public void BuildCPU()
    {
        _computer.CPU = "AMD Ryzen 9 5900X";
    }

    public void BuildRAM()
    {
        _computer.RAM = "32GB DDR4 3600MHz";
    }

    public void BuildStorage()
    {
        _computer.Storage = "1TB NVMe SSD + 2TB HDD";
    }

    public void BuildMortherboard()
    {
        _computer.Motherboard = "ASUS ROG Strix X570-E";
    }

    public void BuildPowerSupply()
    {
        _computer.PowerSupply = "Corsair RM850x 850W";
    }

    public void BuildCase()
    {
        _computer.Case = "NZXT H510 Elite";
    }

    public void BuildPeripherals()
    {
        _computer.Peripherals = new List<string>
        {
            "Razer DeathAdder V2 Gaming Mouse",
            "Razer BlackWidow Elite Mechanical Gaming Keyboard",
            "ASUS ROG Swift PG279Q 27\" Gaming Monitor",
            "SteelSeries Arctis Pro Wireless Gaming Headset"
        };
    }

    public Computer GetComputer()
    {
        return _computer;
    }
}