using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static Dictionary<char, string> keypad = new()
    {
        { '2', "ABC" },
        { '3', "DEF" },
        { '4', "GHI" },
        { '5', "JKL" },
        { '6', "MNO" },
        { '7', "PQRS" },
        { '8', "TUV" },
        { '9', "WXYZ" }
    };

    static void Main()
    {
        string input = "8 88777444666*664#";
        string result = ConvertKeypadInput(input);
        // Console.WriteLine(result);
    }

    static string ConvertKeypadInput(string input)
    {
        StringBuilder output = new();
        StringBuilder buffer = new();

        foreach (char c in input)
        {
            //validate digit
            if (!char.IsDigit(c))
                continue;

            //separator
            if (c == ' ')
            {
                Commit(buffer, output);
                continue;
            }

            // Group the letter when the digit changes
            if (buffer.Length == 0 || buffer[0] == c)
            {
                buffer.Append(c);
            }
            else
            {
                Commit(buffer, output);
                buffer.Append(c);
            }

            if (c == '#')
                break;

            // DELETE last letter for *
            if (c == '*')
            {   
                Commit(buffer, output);

                if (output.Length > 0)
                    output.Length--; // backspace
                continue;
            }
        }

        Commit(buffer, output);
        return output.ToString();
    }

    static void Commit(StringBuilder buffer, StringBuilder output)
    {
        if (buffer.Length == 0) return;

        char key = buffer[0];
        
        int pressCount = buffer.Length;

        if (keypad.TryGetValue(key, out var letters))
        {
            int index = (pressCount - 1) % letters.Length;
            output.Append(letters[index]);
        }

        buffer.Clear();
    }
}
