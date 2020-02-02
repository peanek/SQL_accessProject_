using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_LearnCSharpWithWF
{
    static class MathMethods
    {
        public static void Summarize(decimal[] values, out decimal max, out decimal min, out decimal average, out decimal sum)
        {
            var list = values.ToList();
            max = values.Max();
            min = values.Min();
            average = (Math.Round(values.Average(),2));
            sum = values.Max();


        }
    }
}
