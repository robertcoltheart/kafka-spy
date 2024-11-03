using System.Text;

namespace KafkaSpy.Web.Styling;

public class StyleBuilder
{
    private readonly StringBuilder builder = new();

    public static StyleBuilder Default()
    {
        return new StyleBuilder();
    }

    public StyleBuilder With(string name, string value, bool? when = true)
    {
        if (when == null || when == true)
        {
            builder.Append($"name: {value};{Environment.NewLine}");
        }

        return this;
    }

    public string Build()
    {
        return builder.ToString();
    }

    public override string ToString()
    {
        return builder.ToString();
    }
}
