namespace CsharpFundamentals.App.Exercises;

public class Exercise04
{
    public void Execute()
    {
        Console.Write("Digite uma palavra ou frase: ");
        var input = Console.ReadLine()?.Trim() ?? string.Empty;

        Console.WriteLine(new string('-', 80));

        int characterCount = 0;

        foreach (var word in input.Split(' '))
        {
            var wordLength = word.Length;
            characterCount += wordLength;
        }

        Console.WriteLine($"Total de caracteres: {characterCount}");
    }
}