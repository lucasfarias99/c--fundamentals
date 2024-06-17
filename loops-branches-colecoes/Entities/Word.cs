using System.Net.Mime;
using System.Runtime.InteropServices;

namespace Entities;

class Word
{
    public string Content { private get; set; }
    public List<ColoredLetter> ColoredAnagram { get; private set; }
    public string[] Tips { get; set; } = new string[3];

    public Word(string content, string[] tip)
    {
        Tips = tip;
        Content = content;
        ColoredAnagram = new List<ColoredLetter>();
    }

    public void BuildAnagram()
    {
        char[] chars = Content.ToCharArray();

        Random random = new Random();

        for (int i = 0; i < chars.Length; i++)
        {
            int j = random.Next(chars.Length);

            char temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;
        }

        for (int i = 0; i < chars.Length; i++)
        {
            if (Content[i] == chars[i])
            {
                ColoredAnagram.Add(new(chars[i], ConsoleColor.Green));
            }
            else
            {
                ColoredAnagram.Add(new(chars[i], ConsoleColor.Red));
            }
        }
    }

    public void PrintAnagram()
    {
        foreach (ColoredLetter l in ColoredAnagram)
        {
            Console.ForegroundColor = l.Color;
            Console.Write(l.Letter);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

class ColoredLetter
{
    public char Letter { get; set; }
    public ConsoleColor Color { get; set; }

    public ColoredLetter(char letter, ConsoleColor color)
    {
        Letter = letter;
        Color = color;
    }
}