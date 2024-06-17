// palavra embaralhada

using Entities;

List<Word> words = new List<Word> {
    new Word("ELEFANTE", new string[] {"Aparece frequentemente em histórias infantis e é símbolo de força e memória","É um animal terrestre de grande porte", "Gravemente ameaçado de extinção"}),
    new Word("GENGIBRE", new string[] {"Planta herbácea da família das Zingiberaceae","Ingrediente típico de Chá", "Nome científico: Zingiber officinale"}),
    new Word("FEITIÇO", new string[] {"Habilidade cultivada por Magos, Bruxos e Xamãs","Também conhecido como Magia Negra", "Avada Kedavra !!!"}),
    new Word("FILOSOFIA", new string[] {"Nasceu na Grécia Antiga","Formula-se teses que se defendem por meio de Argumentos", "Sócrates"}),
    new Word("CONFEITEIRO", new string[] {"É uma profissão","Responsável por analisar dados atmosféricos", "Estudam o clima e o tempo"})
};

WordGuessGame word = new WordGuessGame(words[2]);

word.BuildAnagram();

word.PrintAnagram();