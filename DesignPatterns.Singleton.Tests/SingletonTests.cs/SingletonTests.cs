using Autofac;
using DesignPatterns.Singleton.Basic;

namespace DesignPatterns.Singleton.Tests;

[TestFixture]
public class SingletonTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void IsSingletonTest()
    {
        var db = SingletonDatabase.Instance;
        var db2 = SingletonDatabase.Instance;
        Assert.That(db, Is.SameAs(db2));
        Assert.That(SingletonDatabase.Count, Is.EqualTo(1), "Count should be 1!. It's a singleton!");
    }


    /// <summary>
    /// This test is not a good test because it depends on the data in the capitals.txt file.
    /// Which is not a good practice for unit tests.
    /// And why singleton is bad for testing.
    /// </summary>
    [Test]
    public void SingletonTotalPopulationTest()
    {
        var rf = new SingletonRecordFinder();
        var names = new[] { "Seoul", "Mexico City" };
        int tp = rf.TotalPopulation(names);
        Assert.That(tp, Is.EqualTo(9776000 + 21581000));
    }

    [Test]
    public void ConfigurableTotalPopulationTest()
    {
        var rf = new ConfigurableRecordFinder(new DummyDatabase());
        var names = new[] { "alpha", "beta" };
        int tp = rf.TotalPopulation(names);
        Assert.That(tp, Is.EqualTo(3));
    }

    [Test]
    public void DependencyInjectionTotalPopulationTest()
    {
        var cb = new ContainerBuilder();
        cb.RegisterType<DummyDatabase>().As<IDatabase>().SingleInstance();
        cb.RegisterType<ConfigurableRecordFinder>();
        
        var names = new[] { "alpha", "beta" };
        using (var c = cb.Build())
        {
            var rf = c.Resolve<ConfigurableRecordFinder>();
            int tp = rf.TotalPopulation(names);
            Assert.That(tp, Is.EqualTo(3), "Dependency Injection Total Population Test Failed!");
        }
    }
}

