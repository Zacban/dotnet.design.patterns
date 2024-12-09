namespace DesignPatterns.InterfaceSegregation;

public class MultiFunctionPrinter : IMachine {
    public void Print(Document d)
    {
        // Print
    }

    public void Scan(Document d)
    {
        // Scan
    }

    public void Fax(Document d)
    {
        // Fax
    }
}
