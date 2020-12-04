using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    public static class Day3
    {

        public static long PartOne(List<string> input)
        {
            // Sample input:
            // ......#...........#...#........   
            // .#.O...#...##.......#.....##...

            // [a, b, c, d, e]
            // [0, 1, 2, 3, 4, 5, 6, 7] <- index
            // [1, 2, 3, 4, 5, 6, 7, 8] <- length
            // []
            //int index = 0;

            return calculateSlope(3, 1, input);
        }

        private static int wrapSlope(int index, int length)
        {
            return index > length - 1 ? index - length : index;
        }

        private static long calculateSlope(int right, int down, List<string> input)
        {
            int index = 0;

            int lineNumber = 0;

            int treesEncountered = 0;

            foreach (var line in input)
            {
                char charAtIndex = input[lineNumber][index];

                if (charAtIndex == '#')
                {
                    treesEncountered++;
                }

                lineNumber += down;

                if (lineNumber > input.Count)
                {
                    return treesEncountered;
                }

                index = index += right;

                index = wrapSlope(index, line.Length);
            }

            return treesEncountered;
        }

        public static long PartTwo(List<string> input)
        {
            // slopes: 
            // Right 1, down 1.
            // Right 3, down 1. (This is the slope you already checked.)
            // Right 5, down 1.
            // Right 7, down 1.
            // Right 1, down 2.

            return (calculateSlope(1, 1, input) * calculateSlope(3, 1, input) * calculateSlope(5, 1, input) * calculateSlope(7, 1, input) * calculateSlope(1, 2, input));
        }
    }
}
