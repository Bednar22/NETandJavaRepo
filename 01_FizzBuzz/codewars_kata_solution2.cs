// https://www.codewars.com/kata/5861d28f124b35723e00005e/train/csharp 

using System;

public static class Kata
{
  public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
  {
  uint d = distanceToPump - (mpg*fuelLeft);
    if(d <= 0) {return true;}
    else{ return false; }
  }
}