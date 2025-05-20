namespace Fundamentos_CSharp.Colecoes.Arrays;

public class ArraysVideo
{
    public static void Run()
    {
        int[] integers = new int[10];
        integers[0] = 1;
        integers[1] = 11;
        integers[2] = 7;

        Console.WriteLine(integers[0]);
        Console.WriteLine(integers[1]);
        Console.WriteLine(integers[2]);
        Console.WriteLine(integers.Length);
        
        Console.WriteLine();

        int[] inteiros = [1, 2, 3];
        Console.WriteLine(inteiros[1]);
        Console.WriteLine(inteiros[2]);
        Console.WriteLine(inteiros[0]);
        Console.WriteLine(inteiros.Length);

        Console.WriteLine();
        
        int[,] matrix = new int[10, 10];
        matrix[0, 0] = 1;
        matrix[0, 3] = 2;
        Console.WriteLine(matrix[0, 0]);
        Console.WriteLine(matrix[0, 1]);
        Console.WriteLine(matrix[0, 2]);
        Console.WriteLine(matrix[0, 3]);
    }
}
