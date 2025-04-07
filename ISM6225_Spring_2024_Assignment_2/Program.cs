using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                HashSet<int> set = new HashSet<int>(nums);
                List<int> result = new List<int>();

                for (int i = 1; i <= nums.Length; i++)
                {
                    if (!set.Contains(i))
                        result.Add(i);
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        // Edge Case: Empty array => return full list from 1 to n (which is 0 in this case, so returns empty list)
        // Edge Case: All numbers present => return empty list

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                int[] result = new int[nums.Length];
                int start = 0, end = nums.Length - 1;

                foreach (int num in nums)
                {
                    if (num % 2 == 0)
                        result[start++] = num;
                    else
                        result[end--] = num;
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        // Edge Case: All even or all odd => maintains order of even-first or odd-last
        // Edge Case: Empty array => returns empty

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                Dictionary<int, int> map = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    int complement = target - nums[i];
                    if (map.ContainsKey(complement))
                        return new int[] { map[complement], i };
                    if (!map.ContainsKey(nums[i]))
                        map[nums[i]] = i;
                }
                return new int[0];
            }
            catch (Exception)
            {
                throw;
            }
        }
        // Edge Case: No solution => return empty array
        // Edge Case: Duplicates allowed if they lead to the solution

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                Array.Sort(nums);
                int n = nums.Length;
                return Math.Max(nums[0] * nums[1] * nums[n - 1],
                                nums[n - 1] * nums[n - 2] * nums[n - 3]);
            }
            catch (Exception)
            {
                throw;
            }
        }
        // Edge Case: Negative numbers in array => product may include them
        // Edge Case: Less than 3 elements => invalid case, not handled here

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                if (decimalNumber == 0) return "0";
                string binary = "";
                while (decimalNumber > 0)
                {
                    binary = (decimalNumber % 2) + binary;
                    decimalNumber /= 2;
                }
                return binary;
            }
            catch (Exception)
            {
                throw;
            }
        }
        // Edge Case: Input 0 => output should be "0"
        // Edge Case: Negative input => not handled here

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                int left = 0, right = nums.Length - 1;

                while (left < right)
                {
                    int mid = left + (right - left) / 2;
                    if (nums[mid] > nums[right])
                        left = mid + 1;
                    else
                        right = mid;
                }
                return nums[left];
            }
            catch (Exception)
            {
                throw;
            }
        }
        // Edge Case: Not rotated => first element is min
        // Edge Case: One element => that’s the min

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                if (x < 0) return false;
                string s = x.ToString();
                int left = 0, right = s.Length - 1;

                while (left < right)
                {
                    if (s[left++] != s[right--])
                        return false;
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        // Edge Case: Negative number => false
        // Edge Case: Single digit => true

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                if (n <= 1) return n;
                int a = 0, b = 1;

                for (int i = 2; i <= n; i++)
                {
                    int temp = a + b;
                    a = b;
                    b = temp;
                }
                return b;
            }
            catch (Exception)
            {
                throw;
            }
        }
        // Edge Case: n = 0 or 1 => return directly
    }
}
