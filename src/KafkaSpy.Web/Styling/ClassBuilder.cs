using System.Text;

namespace KafkaSpy.Web.Styling;

public class ClassBuilder
{
    private readonly StringBuilder builder = new();

    public static ClassBuilder Default()
    {
        return new ClassBuilder();
    }

    public ClassBuilder With(string value, bool? when = true)
    {
        if (when == null || when == true)
        {
            AddClass(value);
        }

        return this;
    }

    public ClassBuilder With(bool condition, string trueValue, string falseValue)
    {
        var className = condition
            ? trueValue
            : falseValue;

        AddClass(className);

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

    private void AddClass(string value)
    {
        if (builder.Length > 0)
        {
            builder.Append(' ');
        }

        builder.Append(value);
    }
}