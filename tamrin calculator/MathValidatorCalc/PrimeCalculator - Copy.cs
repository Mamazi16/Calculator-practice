namespace MathValidatorCalc;


internal class PrimeCalculator : CalculationValidity
{
    public static bool IsValid(int number)
    {
        if (number <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}