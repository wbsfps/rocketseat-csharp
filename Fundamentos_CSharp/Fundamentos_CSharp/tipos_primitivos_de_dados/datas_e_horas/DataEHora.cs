using System.Globalization;

namespace Fundamentos_CSharp.tipos_primitivos_de_dados.datas_e_horas;

public class DataEHora
{
    public static void Run()
    {
        DateOnly day = new DateOnly(2023, 12, 1);
        string dayToString = day.ToLongDateString();
        string formatBrazilian = day.ToString(new CultureInfo("pt-br"));
        string anotherFormats = day.ToString("D", new CultureInfo("pt-br"));

        Console.WriteLine(day);
        Console.WriteLine(dayToString);
        Console.WriteLine(formatBrazilian);
        Console.WriteLine(anotherFormats);

        string dates = day.ToString("dd-MM-yyyy", new CultureInfo("fr-fr"));
        
        Console.WriteLine(dates);

        DateTime date = new DateTime(2023, 12, 1, 20, 08, 00);
        Console.WriteLine(date);

        DateTime now = DateTime.Now; // Data e hora no momento da execução da máquina
        DateTime utcNow = DateTime.UtcNow; // Melhor
        DateTime today = DateTime.Today; // Apenas a data
        Console.WriteLine(now);
        Console.WriteLine(utcNow);
        Console.WriteLine(today);

        DateTime newDate = today.AddDays(1);
        Console.WriteLine(newDate);
    }
}
