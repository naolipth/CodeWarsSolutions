public class Kata
{
  public static double NbaExtrap(double ppg, double mpg)
  {
    double solution = 0.0;
     
    if (ppg != 0  && mpg != 0)
      {
      solution = (double)decimal.Round((decimal)ppg / (decimal)mpg * 48,1);
      }
    
    return solution;
  }
}
