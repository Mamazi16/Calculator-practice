namespace MathValidatorCalc;


internal class OddCalculator : CalculationValidity
{
    public static bool IsValid(int number) => number % 2 != 0;
}