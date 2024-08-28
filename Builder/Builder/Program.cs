namespace Builder;

class Program
{
    static void Main(string[] args)
    {
        IComputerBuilder officeComputerBuilder = new OfficeComputerBuilder();
        officeComputerBuilder.BuildCPU();
        officeComputerBuilder.BuildRAM();
        officeComputerBuilder.BuildStorage();
        officeComputerBuilder.BuildMortherboard();
        officeComputerBuilder.BuildPowerSupply();
        officeComputerBuilder.BuildCase();
        officeComputerBuilder.BuildPeripherals();

        Computer officeComputer = officeComputerBuilder.GetComputer();
        Console.WriteLine("CPU: " + officeComputer.CPU);
        Console.WriteLine("RAM: " + officeComputer.RAM);
        Console.WriteLine("Storage: " + officeComputer.Storage);
        Console.WriteLine("Motherboard: " + officeComputer.Motherboard);
        Console.WriteLine("Power Supply: " + officeComputer.PowerSupply);
        Console.WriteLine("Case: " + officeComputer.Case);
        Console.WriteLine("Peripherals: " + string.Join(", ", officeComputer.Peripherals));

        IComputerBuilder gamingComputerBuilder = new GamingComputerBuilder();
        gamingComputerBuilder.BuildCPU();
        gamingComputerBuilder.BuildRAM();
        gamingComputerBuilder.BuildStorage();
        gamingComputerBuilder.BuildMortherboard();
        gamingComputerBuilder.BuildPowerSupply();
        gamingComputerBuilder.BuildCase();
        gamingComputerBuilder.BuildPeripherals();

        Computer gamingComputer = gamingComputerBuilder.GetComputer();
        Console.WriteLine("CPU: " + gamingComputer.CPU);
        Console.WriteLine("RAM: " + gamingComputer.RAM);
        Console.WriteLine("Storage: " + gamingComputer.Storage);
        Console.WriteLine("Motherboard: " + gamingComputer.Motherboard);
        Console.WriteLine("Power Supply: " + gamingComputer.PowerSupply);
        Console.WriteLine("Case: " + gamingComputer.Case);
        Console.WriteLine("Peripherals: " + string.Join(", ", gamingComputer.Peripherals));
    }
}