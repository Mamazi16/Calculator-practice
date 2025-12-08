namespace MathValidatorCalc;


internal class PrimeCalculatorPro : CalculationValidity
{
    public static bool IsValid(int number)
    {
        if (number < 2) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        int i = 3;
        while (i * i <= number)
        {
            if (number % i == 0)
            {
                return false;
            }
            i += 2;
        }
        return true;
    }
}