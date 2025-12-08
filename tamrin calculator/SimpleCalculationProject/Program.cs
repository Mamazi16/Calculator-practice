// Calculator Practice
// MohamadReza Panahandeh
using InOut;
using MathValidatorCalc;

Console.Write("Enter first number: ");
int number1 = InPutOutPut.ForceGetUnsignedIntegerNumber();
Console.Write("Enter second number: ");
int number2 = InPutOutPut.ForceGetUnsignedIntegerNumber();

int maxNumber = Math.Max(number1, number2);
for (int i = Math.Min(number1, number2); i < maxNumber; i++)
{
    InPutOutPut.PrintByValue<int>(i, AgreeGetCalculator.IsOdd(i) ? "Is Odd" : "Is Even");
    InPutOutPut.PrintByCondition(AgreeGetCalculator.IsPalindrom(i), "Palindrom");
    InPutOutPut.PrintByCondition(AgreeGetCalculator.IsPrime(i), "Prime");
    InPutOutPut.PrintByCondition(AgreeGetCalculator.IsCompleteNumber(i), "Complete", false);

    Console.WriteLine();
}




