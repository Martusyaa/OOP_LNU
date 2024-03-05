using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    public sealed class Fibonacci
    {
        private Fibonacci() { }

        public static List<double> steps(int step, List<double> sequance)
        {
            if (step == 0)
            {
                return sequance;
            }
            var length = sequance.Count;
            var next = sequance[length - 1] + sequance[length - 2];
            sequance.Add(next);
            return steps(step - 1, sequance);
        }
        public static List<double> limit(int limite, int steps, List<double> sequance)
        {
            var length = sequance.Count;
            var next = sequance[length - 1] + sequance[length - 2];

            if (limite < next)
            {

                return sequance;
            }

            sequance.Add(next);
            steps++;
            return limit(limite, steps, sequance);
        }
    }
}
