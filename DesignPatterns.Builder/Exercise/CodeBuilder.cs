using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Exercise
{
    public class CodeBuilder
    {
        private readonly string _className;

        private readonly Dictionary<string, string> _fields = new();

        public CodeBuilder(string className)
        {
            _className = className;
        }

        public CodeBuilder AddField(string name, string type)
        {
            _fields[name] = type;
            return this;
        }

        public override string ToString()
        {
            return _fields.Any()
                ? $"public class {_className}\n{{\n{string.Join("\n", _fields.Select(f => $"    public {f.Value} {f.Key};"))}\n}}"
                : $"public class {_className}\n{{\n}}";
        }
    }

    public static class CodeBuilderProgram
    {
        public static void Run()
        {
            Console.WriteLine("Exercise");
            var cb = new CodeBuilder("Person")
                .AddField("Name", "string")
                .AddField("Age", "int");

            Console.WriteLine(cb);
        }
    }
}