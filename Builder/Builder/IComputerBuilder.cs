namespace Builder;

public interface IComputerBuilder
{
    void BuildCPU();
    void BuildRAM();
    void BuildStorage();
    void BuildMortherboard();
    void BuildPowerSupply();
    void BuildCase();
    void BuildPeripherals();
    Computer GetComputer();
}