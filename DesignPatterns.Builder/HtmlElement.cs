using System.Text;

namespace DesignPatterns.Builder;
public class HtmlElement
{
    public string Name { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;

    public List<HtmlElement> Elements = new();

    private const int IndentSize = 2;

    public HtmlElement() { }
    public HtmlElement(string name, string text)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Text = text ?? throw new ArgumentNullException(nameof(text));
    }

    public override string ToString() => ToStringImpl(0);

    private string ToStringImpl(int indent)
    {
        var sb = new StringBuilder();
        var i = new string(' ', IndentSize * indent);
        sb.AppendLine($"{i}<{Name}>");
        if (!string.IsNullOrWhiteSpace(Text))
        {
            sb.Append(new string(' ', IndentSize * (indent + 1)));
            sb.AppendLine(Text);
        }

        foreach (var e in Elements)
        {
            sb.Append(e.ToStringImpl(indent + 1));
        }

        sb.AppendLine($"{i}</{Name}>");
        return sb.ToString();
    }
}