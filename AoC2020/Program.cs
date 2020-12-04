using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AoC2020
{
    class Program
    {
        static void Main(string[] args)
        {

            var dayOneInput = File.ReadLines("Inputs/Day1Input.txt").Select(line => int.Parse(line)).ToList();
            Console.WriteLine($"Day One Part One: {Day1.PartOne(dayOneInput)}");
            Console.WriteLine($"Day One Part Two: {Day1.PartTwo(dayOneInput)}");

            var dayTwoInput = File.ReadAllLines("Inputs/Day2Input.txt");
            var dayTwoInputList = new List<string>(dayTwoInput);

            Console.WriteLine($"Day Two Part One: {Day2.PartOne(dayTwoInputList)}");
            Console.WriteLine($"Day Two Part Two: {Day2.PartTwo(dayTwoInputList)}");

            var dayThreeInput = File.ReadAllLines("Inputs/Day3Input.txt");
            var dayThreeInputList = new List<string>(dayThreeInput);

            Console.WriteLine($"Day Three Part One: {Day3.PartOne(dayThreeInputList)}");
            Console.WriteLine($"Day Three Part Two: {Day3.PartTwo(dayThreeInputList)}");
        }
    }
}
