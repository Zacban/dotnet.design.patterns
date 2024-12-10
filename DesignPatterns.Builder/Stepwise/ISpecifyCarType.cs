namespace DesignPatterns.Builder.Stepwise;

public interface ISpecifyCarType
{
    ISpecifyWheelSize OfType(CarTypes carType);
}
