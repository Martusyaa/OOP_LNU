using System.Collections.Generic;

namespace recursion
{
    internal sealed class Fibonacci
    {
        public static List<double> steps(int step, List<double> sequence)
        {
            if (step > 0)
            {
                int count = sequence.Count;
                double next = sequence[count - 1] + sequence[count - 2];
                sequence.Add(next);

                return steps(step - 1, sequence);

            }

            return sequence;
        }

        public static Duo border(double bound, List<double> sequence)
        {
            return border(bound, sequence, 0);
        }

        private static Duo border(double bound, List<double> sequence, int steps) 
        {
            
            int count = sequence.Count;
            double next = sequence[count - 1] + sequence[count - 2];
            if (next < bound)
            {
                steps++;
                sequence.Add(next);
                return border(bound, sequence, steps);
            }
            return new Duo(steps, sequence);
        }
    }
}
