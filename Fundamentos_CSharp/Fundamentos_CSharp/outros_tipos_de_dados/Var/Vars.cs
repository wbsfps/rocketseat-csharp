namespace Fundamentos_CSharp.outros_tipos_de_dados.Var;

public class Vars
{
    public static void Run()
    {
        string name = "William";
        int number = 2;

        var nome = "William"; // Deixa o compilador selecionar o tipo.

        //var surname; erro
        string surname; // Pode

        var date = DateTime.Now;
    }
}
