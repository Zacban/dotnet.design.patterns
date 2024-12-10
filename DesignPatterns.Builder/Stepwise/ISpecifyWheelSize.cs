namespace DesignPatterns.Builder.Stepwise;

public interface ISpecifyWheelSize
{
    IBuildCar WithWheelSize(int size);
}
