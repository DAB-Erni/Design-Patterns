namespace Builder;

public class Computer
{
    public string CPU { get; set; } = string.Empty;
    public string RAM { get; set; } = string.Empty;
    public string Storage { get; set; } = string.Empty;
    public string Motherboard { get; set; } = string.Empty;
    public string PowerSupply { get; set; } = string.Empty;
    public string Case { get; set; } = string.Empty;
    public List<string> Peripherals { get; set; } = new List<string>();

    public override string ToString()
    {
        return $"Computer Specification:\nCPU: {CPU}\nRAM: {RAM}\nStorage: {Storage}\nMotherboard: {Motherboard}\nPower Supply: {PowerSupply}\nCase: {Case}\nPeripherals: {Peripherals}";
    }

}
