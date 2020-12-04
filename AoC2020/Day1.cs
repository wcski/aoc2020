using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    public static class Day1
    {
        public static int PartOne(List<int> inputs)
        {
            var hash = new HashSet<int>();

            foreach (var line in inputs)
            {
                var counterpart = 2020 - line;
                if (hash.Contains(counterpart))
                    return line * counterpart;
                else
                    hash.Add(line);
            }
            return 0;
        }

        public static int PartTwo(List<int> inputs)
        {
            var hash = new HashSet<int>();

            for (var i = 0; i < inputs.Count; i++)
            {
                for (int j = i + 1; j < inputs.Count; j++)
                {
                    var pair = inputs[i] + inputs[j];
                    var counterpart = 2020 - pair;

                    if (hash.Contains(counterpart))
                        return inputs[i] * inputs[j] * counterpart;
                    else
                    {
                        if (!hash.Contains(inputs[i]))
                            hash.Add(inputs[i]);
                        if (!hash.Contains(inputs[j]))
                            hash.Add(inputs[j]);
                    }
                }
            }
            return 0;
        }
    }
}
