using DesignPatterns.Singleton.Basic;

namespace DesignPatterns.Singleton;

public class ConfigurableRecordFinder
{
    private IDatabase database;

    public ConfigurableRecordFinder(IDatabase database)
    {
        this.database = database ?? throw new ArgumentNullException(nameof(database));
    }


    public int TotalPopulation(IEnumerable<string> names)
    {
        int result = 0;
        foreach (var name in names)
        {
            result += database.GetPopulation(name);
        }
        return result;
    }
}
