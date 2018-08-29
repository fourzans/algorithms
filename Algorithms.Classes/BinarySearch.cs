using System;

namespace Algorithms.Classes
{
    public class BinarySearch
    {
        public static bool SearchRecursive(int[] array, int x, int left, int right)
        {
            if (left > right)
            {
                return false;
            }

            int midPoint = left + (left + right) / 2;
            if (array[midPoint] == x)
            {
                return true;
            }
            else if (x < array[midPoint])
            {
                return SearchRecursive(array, x, left, midPoint - 1);
            }
            else
            {
                return SearchRecursive(array, x, midPoint + 1, right);
            }
        }

        public static bool SarchIterative(int[] array, int x)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int midPoint = left + (left + right) / 2;

                if (array[midPoint] == x)
                {
                    return true;
                }
                else if (x < array[midPoint])
                {
                    right = midPoint - 1;
                }
                else
                {
                    left = midPoint + 1;
                }
            }

            return false;
        }
    }
}
