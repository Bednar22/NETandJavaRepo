using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    
    public class NumberCheck
    {
        public static bool CheckIfNear(int number)
        {
            
            List<int> listOfInts = new List<int>();
            int digit=0;
            int i = 0;
            while (number > 0)
            {
                digit = number % 10;
             if((digit==5) || (digit == 3)){
                    if (listOfInts.Count>0) {
                        if ((listOfInts[i - 1] == 5) || (listOfInts[i - 1] == 3))
                        {
                            return true;
                        }
                    }
                }
                listOfInts.Add(digit);
                number = number / 10;
                i = i + 1;
            }
            return false;
        }
    
        public static bool CheckIfFive(int number)
        {
            int digit = 0;
            while (number > 0)
            {
                digit = number % 10;
                if (digit == 5)
                {
                    return true;
                }
                number = number / 10;
            }
            return false;
        }
    }
    public class FizzBuzzer
    {
        public static List<string> MillNumbers(List<int> numbers)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 7 == 0)
                {
                    result.Add("Buzzinga");
                }
                 else if (((numbers[i] % 3 == 0) && (numbers[i] % 5 == 0))
                         ||(NumberCheck.CheckIfNear(numbers[i])==true))
                {
                    result.Add("FizzBuzz");
                }
                else if ((numbers[i] % 5 == 0) || (NumberCheck.CheckIfFive(numbers[i]) == true))
                {
                    result.Add("Buzz");
                }else if (numbers[i] % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else
                {
                    result.Add(numbers[i].ToString());
                }
            }
            return result;
        }
    }
}
