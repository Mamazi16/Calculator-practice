


namespace Assignments
{
    public class Calculator
    {
        public static object KaprekarCalculator(int number)
        {
            if(number <= 0) { return " number must be positive"; }
         string s = number.ToString("D4");
          
            if(s.Distinct().Count()==1) { $" this programme can not convert {s} to 6174"; }
            int CurrentNumber = number;
            int iteration = 0; 
            while(CurrentNumber!=6174) 
            {
                iteration++;
                string CurrentString = CurrentNumber.ToString("D4");
                char[] DigitDesc=CurrentString.ToCharArray();
                Array.Sort(DigitDesc);
                Array.Reverse(DigitDesc);
                int MaxNum = int.Parse(new string(DigitDesc));
                char[] DigitAsc = CurrentString.ToCharArray();
                Array.Sort(DigitAsc);
                int MinNum=int.Parse(new string(DigitAsc));
                Console.WriteLine($"{MaxNum} - {MinNum} = {CurrentNumber}");
                if(iteration>7) { break; }
            }
            return ($"iteration = {iteration}");
        }
        
    }
}




