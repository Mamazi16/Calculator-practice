using ResulPattern;
namespace InOut;


public static class InPutOutPut
{
    public static int GetIntegerNumber()
    {
        bool isValid = false;
        int number = 0;
        do
        {
            string? input = Console.ReadLine();
            isValid = int.TryParse(input, out number);
        }
        while (!isValid);
        return number;

    }
    private static Result<int> GetUnsignedIntegerNumber()
    {
        bool isValid = false;
        int number = 0;

        string? input = Console.ReadLine();
        isValid = input?.All(char.IsDigit) ?? false;
        number = isValid ? int.Parse(input ?? "0") : 0;
        if (isValid)
        {
            return Result<int>.Success(number);
        }
        else
        {
            return Result<int>.Failure();
        }
    }
    private static int GetUnsignedIntegerNumberWithException()
    {
        bool isValid = false;
        int number = 0;

        string? input = Console.ReadLine();
        isValid = input?.All(char.IsDigit) ?? false;
        number = isValid ? int.Parse(input ?? "0") : 0;
        if (isValid)
        {
            return number;
        }
        else
        {
            throw new ArgumentException("Enter a number");
        }
    }
    public static int ForceGetUnsignedIntegerNumber()
    {
        Result<int> result = Result<int>.Failure();
        do
        {
            result = GetUnsignedIntegerNumber();
            if (result.IsFailure)
            {
                Console.WriteLine("Wrong number! Try again");
            }
        }
        while (result.IsFailure);
        return result.Value;
    }
    public static int ForceGetUnsignedIntegerNumberWithException()
    {
        int result = 0;
        bool isValid = false;
        do
        {
            try
            {
                isValid = false;
                result = GetUnsignedIntegerNumberWithException();
            }
            catch (ArgumentException)
            {
                isValid = true;
                Console.WriteLine("Wrong number! Try again");
            }
            catch (Exception ex)
            {
                isValid = true;
                Console.WriteLine("Exception occured " + ex);
            }

        }
        while (isValid);
        return result;
    }

    public static void PrintByValue<T>(T value, string message, bool condition = true)
    {
        Console.Write($"{value}: {message} " + (condition ? "- " : ""));
    }
    public static void PrintByCondition(bool isValid, string message, bool condition = true)
    {
        Console.Write("Is " + (isValid ? " " : "not ") + message + (condition ? " - " : " "));
    }
}