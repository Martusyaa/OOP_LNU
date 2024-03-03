
    class Fibonacci
    {
        private int firstNumber;
        private int secondNumber;

        private List<int> fibonacciValues = new List<int>();

        public Fibonacci(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            fibonacciValues.Add(firstNumber);
            fibonacciValues.Add(secondNumber);
        }

        public void CalculateFibonacciWithLimit(int limit)
        {
            int step = 0;
            while (true)
            {
                int value = CalculateFibonacci(step);
                if (value > limit)
                    break;

                Console.WriteLine($"{step + 1}: {value}");
                step++;
            }
        }

        public void CalculateFibonacciWithSteps(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                int value = CalculateFibonacci(i);
                Console.WriteLine($"{i + 1}: {value}");
            }
        }

        private int CalculateFibonacci(int n)
        {
             while (fibonacciValues.Count <= n)
            {
                int newValue = fibonacciValues[fibonacciValues.Count - 1] + fibonacciValues[fibonacciValues.Count - 2];
                fibonacciValues.Add(newValue);
            }
            return fibonacciValues[n];
        } 
    }