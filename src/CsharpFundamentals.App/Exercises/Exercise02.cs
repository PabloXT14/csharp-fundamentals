namespace CsharpFundamentals.App.Exercises;

public class Exercise02
{
    public void Execute()
    {
        Console.Write("Digite o nome: ");
        var firstName = Console.ReadLine();

        Console.Write("Digite o sobrenome: ");
        var lastName = Console.ReadLine();

        var fullName = $"{firstName} {lastName}";

        Console.WriteLine($"Nome completo: {fullName}");
    }
}