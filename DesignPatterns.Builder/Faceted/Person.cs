namespace DesignPatterns.Builder.Faceted;
public class Person
{
    // Address
    public string StreetAddress = string.Empty, Postcode = string.Empty, City = string.Empty;

    //employment
    public string CompanyName = string.Empty, Position = string.Empty;
    public int AnnualIncome;

    public override string ToString()
    {
        return $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(Postcode)}: {Postcode}, {nameof(City)}: {City}, {nameof(CompanyName)}: {CompanyName}, {nameof(Position)}: {Position}, {nameof(AnnualIncome)}: {AnnualIncome}";
    }
}
