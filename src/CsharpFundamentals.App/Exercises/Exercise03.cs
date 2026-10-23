namespace CsharpFundamentals.App.Exercises;

public class Exercise03
{

    public void Execute()
    {
        Console.WriteLine("Números: ");
        Console.Write("* Digite o número 1: ");
        var number1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("* Digite o número 2: ");
        var number2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(new string('-', 80));

        var sum = Sum(number1, number2);
        var subtract = Subtract(number1, number2);
        var multiply = Multiply(number1, number2);
        var (divide, message) = Divide(number1, number2);
        var average = Average(number1, number2);

        Console.WriteLine($"* Soma: {sum}");
        Console.WriteLine($"* Subtração: {subtract}");
        Console.WriteLine($"* Multiplicação: {multiply}");
        Console.WriteLine($"* Divisão: {(divide.HasValue ? divide.Value.ToString() : message)}");
        Console.WriteLine($"* Média: {average}");
    }

    private double Sum(double number1, double number2)
    {
        return number1 + number2;
    }

    private double Subtract(double number1, double number2)
    {
        return number1 - number2;
    }

    private double Multiply(double number1, double number2)
    {
        return number1 * number2;
    }

    private (double?, string) Divide(double number1, double number2)
    {
        if (number2 == 0)
        {
            return (null, "Divisão por zero não é permitida.");
        }

        return (number1 / number2, string.Empty);
    }

    private double Average(double number1, double number2)
    {
        return (number1 + number2) / 2;
    }
}