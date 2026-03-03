using System;

namespace SearchAlgorithms
{
    public class BinarySearch
    {
        //binary search algorithm assumes that the array is sorted in ascending order
        public int Search(int key, int[] elemArray)
        {
            int bottom = 0;
            int top = elemArray.Length - 1;
            int mid;
            int index = -1;
            Boolean found = false;

            while (bottom <= top && found == false)
            {
                mid = (top + bottom) / 2;
                if (elemArray[mid] == key)
                {
                    index = mid;
                    found = true;
                    return index;
                }
                else
                {
                    if (elemArray[mid] < key)
                        bottom = mid + 1;
                    else
                        top = mid - 1;
                }
            }
            return index;
        }
    }
}