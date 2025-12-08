
namespace MathValidatorCalc;


public static class AgreeGetCalculator
{
    public static bool IsOdd(int number) => number % 2 != 0;
    public static bool IsEven(int number) => !IsOdd(number);
    public static bool IsPrime(int number)
    {
        if (number < 1000)
            return PrimeCalculator.IsValid(number);
        else
            return PrimeCalculatorPro.IsValid(number);
    }
    public static bool IsPalindrom(int number) =>
        PalindromCalculator.IsValid(number);
    public static bool IsCompleteNumber(int number) =>
        CompleteNumberCalculator.IsValid(number);

}