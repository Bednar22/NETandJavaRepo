// https://www.codewars.com/kata/59ca8246d751df55cc00014c/train/csharp
class Kata
{
    public static bool Hero(int bullets, int dragons)
    {
      if(dragons - (bullets/2) <= 0) {return true; }
      return false;
    }
}