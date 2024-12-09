﻿using System.Text;

using static System.Console;

namespace DesignPatterns.Builder;



class Program
{
    static void Main(string[] args)
    {
        var hello = "hello";
        var sb = new StringBuilder();
        sb.Append("<p>");
        sb.Append(hello);
        sb.Append("</p>");

        WriteLine(sb);

        var words = new[] { "hello", "world" };
        sb.Clear();
        sb.Append("<ul>");
        foreach (var word in words)
        {
            sb.AppendFormat("<li>{0}</li>", word);
        }
        sb.Append("</ul>");

        WriteLine(sb);

        var builder = new HtmlBuilder("ul");
        builder.AddChild("li", "hello");
        builder.AddChild("li", "world");
        WriteLine(builder);
    }
}
