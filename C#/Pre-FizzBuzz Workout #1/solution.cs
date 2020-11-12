public class Kata
{
  public static int[] PreFizz(int n) 
  {
   int[] output = new int[n];
   for(int i = 0; i < n; i++)
   {
     output[i] = i + 1;
   }
   return output;
  }
}
