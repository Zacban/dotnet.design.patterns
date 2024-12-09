using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Builder;
public class HtmlBuilder
{
    private readonly string _rootName;
    private readonly HtmlElement _root = new();

    public HtmlBuilder(string rootName)
    {
        _rootName = rootName ?? throw new ArgumentNullException(nameof(rootName));
        _root.Name = rootName;
    }

    public void AddChild(string childName, string childText)
    {
        var e = new HtmlElement(childName, childText);
        _root.Elements.Add(e);
    }

    public override string ToString() => _root.ToString();

    public void Clear() => _root.Elements.Clear();
}