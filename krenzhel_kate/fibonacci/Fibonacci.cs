public class Fibonacci
{
    public int counter = 0;
    public Fibonacci() { }
    
    public List<int> CalculateFibonacciBorder(double border, List<int> fibonacci)
    {
        int sum = fibonacci[^1] + fibonacci[^2];
        if (sum < border)
        {
            fibonacci.Add(sum);
            counter += 1;
            return CalculateFibonacciBorder(border, fibonacci);
        }
        else
        {
            Console.WriteLine("Count: " + counter);
            return fibonacci;
        }
    }

    public List<int> CalculateFibonacciSteps(double steps, List<int> fibonacci)
    {
        int sum = fibonacci[^1] + fibonacci[^2];
        if (counter < steps)
        {
            fibonacci.Add(sum);
            counter += 1;
            return CalculateFibonacciSteps(steps, fibonacci);
        }
        else
        {
            return fibonacci;
        }
    }   
}
