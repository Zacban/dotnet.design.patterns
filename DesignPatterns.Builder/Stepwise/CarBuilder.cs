namespace DesignPatterns.Builder.Stepwise;

public static class CarBuilder
{
    private class CarBuilderImpl : ISpecifyCarType, ISpecifyWheelSize, IBuildCar
    {
        private Car car = new Car();

        public Car Build()
        {
            return car;
        }

        public ISpecifyWheelSize OfType(CarTypes carType)
        {
            car.CarType = carType;
            return this;
        }

        public IBuildCar WithWheelSize(int size)
        {
            car.WheelSize = size;
            return this;
        }
    }

    public static ISpecifyCarType Create() {
        return new CarBuilderImpl();
    }
}