using System.Diagnostics;
using System.Net;

namespace DesignPatterns.SingleResponsibility;

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
}

public class Persistence {
    public void SaveToFile(Journal journal, string filename, bool overwrite = false) {
        if (overwrite || !File.Exists(filename)) {
            File.WriteAllText(filename, journal.ToString());
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var j = new Journal();
        j.AddEntry("I cried today.");
        j.AddEntry("I ate a bug.");
        Console.WriteLine(j);

        if (!Directory.Exists("temp"))
            Directory.CreateDirectory("temp");

        var p = new Persistence();
        var filename = @"temp\journal.txt";
        p.SaveToFile(j, filename, true);

        Process.Start("notepad.exe", filename);
    }
}
