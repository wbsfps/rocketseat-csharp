namespace Fundamentos_CSharp.tipos_primitivos_de_dados.tipos_de_texto;

public class TiposDeTexto
{
    public static void Run()
    {
        // Variáveis do tipo TEXTO
        // char
        // string

        char letter = 'a';
        char number = '1';
        char character = '@';
        char space = ' ';

        string text = "Este curso é muito bom";
        char firstLetterInText = text[0];

        Console.WriteLine(firstLetterInText);

        string myName = "   William   ";
        string nameWithoutSpaces = myName.Trim();

        bool startsWithLetterWi = nameWithoutSpaces.StartsWith("Wi");
        bool endsWithLetterE = nameWithoutSpaces.EndsWith('e');

        string usingReplace = nameWithoutSpaces.Replace('l', 'u');

        Console.WriteLine(myName);
        Console.WriteLine(nameWithoutSpaces);
        Console.WriteLine(endsWithLetterE);
        Console.WriteLine(startsWithLetterWi);
        Console.WriteLine(usingReplace);

        bool existContains = text.Contains("curso");
        bool existEquals = text.Equals("Este curso é muito bom");

        Console.WriteLine(existContains);
        Console.WriteLine(existEquals);
    }
}
