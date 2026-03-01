using System;

namespace SearchAlgorithms
{
    public class JumpSearch
    {
        public int Search(int key, int[] elemArray)
        {
            int n = elemArray.Length;
            int step = (int)Math.Floor(Math.Sqrt(n));
            int prev = 0;

            while (prev < n && elemArray[Math.Min(step, n) - 1] < key)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n)
                    return -1;
            }

            while (prev < n && elemArray[prev] < key)
            {
                prev++;
                if (prev == Math.Min(step, n))
                    return -1;
            }

            if (prev < n && elemArray[prev] == key)
                return prev;

            return -1;
        }
    }
}