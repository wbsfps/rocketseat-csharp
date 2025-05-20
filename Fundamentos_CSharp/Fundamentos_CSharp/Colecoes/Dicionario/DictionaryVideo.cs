namespace Fundamentos_CSharp.Colecoes.Dicionario;

public class DictionaryVideo
{
    public static void Run()
    {
        Dictionary<string, string> user = new Dictionary<string, string>();

        user.Add("username", "wbs");
        user.Add("name", "William");
        user.Add("email", "william@gmail.com");

        string value = user["username"];

        Console.WriteLine(value);
        Dictionary<int, string> names = new Dictionary<int, string>();
        names.Add(1, "Romeu");
        names.Add(2, "Bob");

        value = names[1];

        Console.WriteLine(value);

        foreach (var pair in user)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }

        foreach (var pair in names)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }

        bool exist = user.ContainsKey("username");
        Console.WriteLine(exist);
    }
}
