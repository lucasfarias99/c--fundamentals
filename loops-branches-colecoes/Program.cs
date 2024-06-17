// palavra embaralhada

using Entities;

string[] tips = new string[] { "Eh um animal", "Um animal muito grande", "Maior mamifero terrestre" };

Word word = new Word("ELEFANTE", tips);

Console.WriteLine(word.Tips[0]);

word.BuildAnagram();

word.PrintAnagram();