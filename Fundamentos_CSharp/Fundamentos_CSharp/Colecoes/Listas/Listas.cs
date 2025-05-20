namespace Fundamentos_CSharp.Colecoes.Listas;

public class Listas
{
    public static void Run()
    {
        List<int> ints = new List<int>();
        ints.Add(1);
        ints.Add(2);
        ints.Add(3);

        Console.WriteLine(ints[0]);
        Console.WriteLine(ints[1]);
        // Console.WriteLine(ints[2]); OutRange
        Console.WriteLine(ints.Count);

        ints.RemoveAt(1); // Remover elemento da posição 0
        int elementAt = ints.ElementAt(0); // Pegar elemento da posição 0

        int firstElement = ints.First();
        int lastElement = ints.Last();
        Console.WriteLine(firstElement);
        Console.WriteLine(lastElement);

        ints.Remove(1);
        ints.Remove(2);
        Console.WriteLine(ints.Count);

        ints.Clear(); // Remover todos os elementos
    }
}
