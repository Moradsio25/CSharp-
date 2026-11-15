namespace LeetCodeDaily.Problems;

public class NumberOfSubarraysWithOddSum
{
    private const int Mod = 1_000_000_007;

    // LeetCode 1524: Number of Sub-arrays With Odd Sum
    // Count subarrays whose sum is odd.
    public int NumberOfSubarrays(int[] nums)
    {
        long evenCount = 1; // prefix sum 0 is considered even
        long oddCount = 0;
        long prefixSum = 0;
        long answer = 0;

        foreach (var num in nums)
        {
            prefixSum += num;

            if (prefixSum % 2 == 0)
            {
                evenCount++;
                answer = (answer + oddCount) % Mod;
            }
            else
            {
                oddCount++;
                answer = (answer + evenCount) % Mod;
            }
        }

        return (int)answer;
    }
}
