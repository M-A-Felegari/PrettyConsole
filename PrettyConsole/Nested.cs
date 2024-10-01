namespace PrettyConsole;

public class Nested
{
    public static string SimpleNested(short order, string text)
    {
        string output = String.Empty;
        int distance = (order - 1) * 5;
        for (int i = 0; i < distance; i++)
        {
            output += " ";
        }
        output += $"■ {text}";
        return output;
    }
    public static string DashedNested1(short order, string text)
    {
        string output = String.Empty;
        int distance = (order - 2) * 5;
        for (int i = 0; i < distance; i++)
        {
            output += " ";
        }
        if (order > 1)
        {
            output += "█====";
        }
        output += $"■ {text}";
        return output;
    }
}