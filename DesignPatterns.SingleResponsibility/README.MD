# Section 1 : SOLID Design Principles
## Single Responsibility

## Breaking the Single Responsibility

A class must have a single responsibility. The following class violates that principle.

```cs
public class Journal {
    private readonly List<string> entries = new List<string>();
    private static int count = 0;

    public int AddEntry(string text) {
        entries.Add($"{++count}: {text}");
        return count;
    }

    public void RemoveEntry(int index) {
        entries.RemoveAt(index);
    }

    public override string ToString() {
        return string.Join(Environment.NewLine, entries);
    }


    public void Save(string filename, bool overwrite = false) {
        File.WriteAllText(filename, ToString());
    }

    public static Journal Load(string filename) {
        var journal = new Journal();
        foreach (var line in File.ReadAllLines(filename)) {
            journal.AddEntry(line);
        }
        return journal;
    }

    public void Load(Uri uri) {
        
    }
```

The methods `Save(string filename, bool overwrite)` and `Load(string filename)` are not meant to be part of the Journal class as they handle persistance