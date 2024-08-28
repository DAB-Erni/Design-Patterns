namespace Builder;

public class OfficeComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public OfficeComputerBuilder()
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
        _computer.CPU = "Intel Core i5-11400";
    }

    public void BuildRAM()
    {
        _computer.RAM = "16GB DDR4 2666MHz";
    }

    public void BuildStorage()
    {
        _computer.Storage = "512GB NVMe SSD";
    }

    public void BuildMortherboard()
    {
        _computer.Motherboard = "ASUS Prime B560M-A";
    }

    public void BuildPowerSupply()
    {
        _computer.PowerSupply = "Seasonic S12III 500W";
    }

    public void BuildCase()
    {
        _computer.Case = "Fractal Design Define Mini C";
    }

    public void BuildPeripherals()
    {
        _computer.Peripherals = new List<string>
        {
            "Logitech MX Master 3 Wireless Mouse",
            "Logitech MX Keys Advanced Wireless Illuminated Keyboard",
            "Dell UltraSharp U2419H 24\" Monitor",
            "Jabra Evolve 75 Wireless Headset"
        };
    }

    public Computer GetComputer()
    {
        return _computer;
    }
}