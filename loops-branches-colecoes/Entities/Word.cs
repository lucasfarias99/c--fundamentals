namespace Entities;

class WordGuessGame
{
    private Word _word;
    public List<ColoredLetter> ColoredAnagram { get; private set; }

    public WordGuessGame(Word word)
    {
        _word = word;
        ColoredAnagram = new List<ColoredLetter>();
    }

    public void BuildAnagram()
    {
        char[] chars = _word.Content.ToCharArray();

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
            if (_word.Content[i] == chars[i])
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

class Word
{
    public string Content { get; set; }
    public string[] Tips { get; set; }

    public Word(string content, string[] tips)
    {
        Content = content;
        Tips = tips;
    }

}