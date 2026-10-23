using System.Globalization;

namespace CsharpFundamentals.App.Exercises;

public class Exercise06
{
    public void Execute()
    {
        Console.WriteLine("Opções de exibição da data atual:");
        Console.WriteLine("1. Formato completo (ex: quarta-feira, 12 de junho de 2024 às 14:30:00)");
        Console.WriteLine("2. Apenas a data (ex: 12/06/2024)");
        Console.WriteLine("3. Hora no formato 24h (ex: 14:30)");
        Console.WriteLine("4. Data com mês por extenso (ex: 12 de junho de 2024)");

        Console.Write("Digite a opção desejada: ");
        var option = Console.ReadLine();

        var currentDateTime = DateTime.Now;
        var culture = new CultureInfo("pt-BR");

        Console.WriteLine(new string('-', 80));

        switch (option)
        {
            case "1":
                Console.WriteLine($"Formato completo: {currentDateTime.ToString("F", culture)}");
                break;
            case "2":
                Console.WriteLine($"Apenas a data: {currentDateTime.ToString("d", culture)}");
                break;
            case "3":
                Console.WriteLine($"Hora atual (formato 24h): {currentDateTime.ToString("HH:mm:ss", culture)}");
                break;
            case "4":
                Console.WriteLine($"Data com mês por extenso: {currentDateTime.ToString("dd 'de' MMMM 'de' yyyy", culture)}");
                break;
            default:
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção de 1 a 4.");
                break;
        }
    }
}