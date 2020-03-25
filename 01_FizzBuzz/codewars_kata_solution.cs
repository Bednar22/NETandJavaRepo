// https://www.codewars.com/kata/54c27a33fb7da0db0100040e/train/csharp
// 
using System; 

public class Kata
{
  public static bool IsSquare(int n){
            if (n >= 0) {
                double d = Math.Sqrt(n);
                bool is_integer = unchecked(d == (int)d);
            if (is_integer == true) { return true; }
            }
            return false;
    }
}


