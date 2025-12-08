namespace MathValidatorCalc;


internal class PalindromCalculator : CalculationValidity
{
    public static bool IsValid(int number)
    {
        string s = number.ToString();
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        string rev = new string(arr);

        return s == rev;
    }
}