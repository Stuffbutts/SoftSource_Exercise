namespace SoftSource_Exercise;

public class TriangleGenerator
{
    private readonly int _max;
    private int _length = 1;

    const char character = '*';
    const string secondsTemplate = "{0} seconds";

    public TriangleGenerator(int max)
    {
        _max = max;
    }

    public void Run()
    {
        while (_length <= _max)
        {
            var rows = GenerateTriangle(_length);
            Console.WriteLine(secondsTemplate, _length);
            foreach (var t1 in rows)
            {
                Console.WriteLine(t1);
            }

            Console.WriteLine();
            _length++;
            Thread.Sleep(TimeSpan.FromSeconds(1));
        }
    }

    private static string RepeatChar(char c, int times)
    {
        var outString = "";
        for (var i = 0; i < times; i++)
        {
            outString += c;
        }

        return outString;
    }


    public static List<string> GenerateTriangle(int length)
    {
        var rows = new List<string>();
        var width = length * 2 - 1;

        for (var i = 0; i < length; i++)
        {
            var spaces = (int)Math.Floor(width / 2.0);
            var row = "";
            if (length > 1)
            {
                if (i == length - 1)
                {
                    var chars = new List<char>();
                    for (var f = 0; f < i + 1; f++)
                    {
                        chars.Add(character);
                    }

                    rows.Add(string.Join(' ', chars));
                    continue;
                }

                row = RepeatChar(' ', spaces - i) + character;
                if (i > 0)
                {
                    row += RepeatChar(' ', i * 2 - 1) + character;
                }

                row += RepeatChar(' ', spaces - i);
            }
            else
            {
                row += character;
            }

            rows.Add(row);
        }

        return rows;
    }
}