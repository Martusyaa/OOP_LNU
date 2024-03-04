namespace FibonacciOne
{
  public class Fibonacci
  {
    public List<int> FibonacciSequence {get; set;}

    public Fibonacci(int steps, List<int> fibonacciSequence)
    {
      this.FibonacciSequence = fibonacciSequence;
    }

    public override string ToString()
    {
      string toReturn = "[Ряд: ";

      foreach (int item in FibonacciSequence)
      {
         toReturn += item + " "; 
      }

      toReturn += "Кроків: " + ( this.FibonacciSequence.Count - 2 ) + "]";

      return toReturn;
    }
  }
}
