using System;

namespace FindMaximumTask
{
    /// <summary>
    /// Class for operations with array.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Finds the element of the array with the maximum value recursively.
        /// </summary>
        /// <param name="array"> Source array. </param>
        /// <returns>The element of the array with the maximum value.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        public static int FindMaximum(int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array == Array.Empty<int>())
            {
                throw new ArgumentException($"{nameof(array)} is empty.", nameof(array));
            }

            return GetMaximum(array, 0, array.Length - 1);

            static int GetMaximum(int[] array, int left, int right)
            {
                if (left == right)
                {
                    return array[left];
                }

                int middle = (left + right) / 2;
                int leftMax = GetMaximum(array, left, middle);
                int rightMax = GetMaximum(array, middle + 1, right);
                return leftMax > rightMax ? leftMax : rightMax;
            }
        }
    }
}
