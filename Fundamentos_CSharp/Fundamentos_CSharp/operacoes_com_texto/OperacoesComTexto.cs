using System.Text;

namespace Fundamentos_CSharp.operacoes_com_texto;

public class OperacoesComTexto
{
    public static void Run()
    {
        string firstText = "A primeira frase";
        string secondText = " Segunda frase";
        string paragraph = firstText + secondText;

        string path = @"C:\teste\outra\pasta\outra";

        string paragraph2 = $"{firstText} {secondText}";

        Console.WriteLine(paragraph);
        Console.WriteLine(path);
        Console.WriteLine(paragraph2);

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(paragraph);
        stringBuilder.Append(paragraph2);

        string result = stringBuilder.ToString();

        Console.WriteLine(result);

        
        string text = "The {0} like number {1}";
        string newText = string.Format(text, "Dracula", 10);

        Console.WriteLine(newText);
    }
}
