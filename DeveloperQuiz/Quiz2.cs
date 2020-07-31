using System;
using System.Collections.Generic;
using System.Linq;

namespace DeveloperQuiz
{
    public class Quiz2
    {
        public Tuple<int, int> GetMaxTwo(IEnumerable<int> values)
        {
            int maxValue1 = values.Max();
            int maxValue2 = values.Where(it => it != maxValue1).Max();

            return new Tuple<int, int>(maxValue1, maxValue2);
        }
    }
}
