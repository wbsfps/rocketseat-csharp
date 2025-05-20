namespace Fundamentos_CSharp.Colecoes.Hashset;

public class HashSets
{
    public static void Run()
    {
        HashSet<int> set = new HashSet<int>();
        set.Add(1);
        set.Add(2);
        set.Add(3);
        set.Add(1);

        Console.WriteLine(set.Count);
    }
}
