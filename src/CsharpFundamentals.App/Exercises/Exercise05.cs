namespace CsharpFundamentals.App.Exercises;

public class Exercise05
{
    public void Execute()
    {
        Console.Write("Digite a placa do veículo: ");
        var licensePlate = Console.ReadLine()?.Trim().ToUpper() ?? string.Empty;

        var isPlateValid = IsValidLicensePlate(licensePlate);

        Console.WriteLine(new string('-', 80));

        if (isPlateValid)
        {
            Console.WriteLine("Placa válida!");
        }
        else
        {
            Console.WriteLine("Placa inválida!");
        }
    }

    private bool IsValidLicensePlate(string licensePlate)
    {
        // Verifica se a placa tem o formato correto (3 letras e 4 números)
        if (licensePlate.Length != 7)
            return false;

        for (int i = 0; i < 3; i++)
        {
            if (!char.IsLetter(licensePlate[i]))
                return false;
        }

        for (int i = 3; i < 7; i++)
        {
            if (!char.IsDigit(licensePlate[i]))
                return false;
        }

        return true;
    }
}