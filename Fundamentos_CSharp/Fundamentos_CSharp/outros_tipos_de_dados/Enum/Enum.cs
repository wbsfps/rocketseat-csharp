namespace Fundamentos_CSharp.outros_tipos_de_dados.Enum;

public class EnumVideo
{
    enum DifficultyLevel 
    { 
        Easy = 0,
        Medium = 1,
        High = 2,
    };
    public static void Run()
    {
        DifficultyLevel difficultyLevel = DifficultyLevel.High;

        int level = (int) difficultyLevel;
        
        Console.WriteLine(difficultyLevel);
        Console.WriteLine(level);
    }
}
