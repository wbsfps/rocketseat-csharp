namespace Fundamentos_CSharp.outros_tipos_de_dados.Null;

public class Null
{
    public static void Run()
    {
        int? age = null; // o ? tem como função caso o usuário por exemplo não informe a idade atribua null

        int myAge = age.Value;
        bool hasValue = age.HasValue;
    }
}
