namespace CsharpFundamentals.App.Exercises;

public class Exercise01
{
    public void Execute()
    {
        Console.Write("Digite seu nome: ");

        var name = Console.ReadLine();

        Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
    }
}