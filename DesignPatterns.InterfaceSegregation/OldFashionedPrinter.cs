namespace DesignPatterns.InterfaceSegregation;

public class OldFashionedPrinter : IMachine {
    public void Print(Document d)
    {
        // Print
    }

    public void Scan(Document d)
    {
        throw new System.NotImplementedException();
    }

    public void Fax(Document d)
    {
        throw new System.NotImplementedException();
    }
}
