using LeetCodeDaily.Problems;

Console.WriteLine("LeetCode Daily Solutions");

var solver = new NumberOfSubarraysWithOddSum();

int[] example1 = { 1, 3, 5, 7 };
int[] example2 = { 2, 4, 6 };
int[] example3 = { 1, 2, 3, 4 };

Console.WriteLine($"Example 1: {solver.NumberOfSubarrays(example1)}");
Console.WriteLine($"Example 2: {solver.NumberOfSubarrays(example2)}");
Console.WriteLine($"Example 3: {solver.NumberOfSubarrays(example3)}");
