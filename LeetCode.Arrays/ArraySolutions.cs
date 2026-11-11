using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.Arrays
{
    public class ArraySolutions
    {
        // 1st
        public static int[] TwoSums1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; i < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }


        public static int[] TwoSums2(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int need = target - nums[i];
                if (map.ContainsKey(need))
                {
                    return new int[] { map[need], i };

                }
                map.Add(nums[i], i);
            }
            return null;
        }


        public static string CommonPrefix(string[] strs)
        {
            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (!strs[i].StartsWith(prefix))
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (string.IsNullOrEmpty(prefix))
                    {
                        return "";
                    }
                }
            }
            return prefix;
        }

        //26 Unique numbers count in the Array 
        //If the array is sorted, if not sort it and do the same. or(using HashSet)
        public static int RemoveDuplicates(int[] nums)
        {
            int j = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[j] = nums[i];
                    j++;
                }
            }
            return j;
        }

        //Remove the given element from the array and give the Count without that element
        //27 Leet code 27 th question
        public static int RemoveElement(int[] nums, int val)
        {
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[j] = nums[i];
                    j++;
                }
            }
            return j;
        }

        //35. Search Insert Position
        // Return the target position and if doesnt exist return where it would insert
        public static int SearchInsert(int[] nums, int target)
        {
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    j = i;
                    return j;
                }
                else if (target > nums[i])
                {
                    j = i + 1;
                }
            }
            return j;
        }

        // 66. Plus One
        public static int[] PlusOne(int[] digits)
        {

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                else
                {
                    digits[i] = 0;
                }
            }
            //if Everything is 9 we will alter to 0 and increase the size of array and put 1 at the beginning
            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }

        //88. Merge Sorted Array
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }
            Array.Sort(nums1);
            Console.WriteLine(string.Join(",", nums1));
        }

        //136. Single Number
        // Need to return the Non repeated value (will be only one)
        public static int SingleNumber(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i += 2)
            {
                if (nums[i] != nums[i + 1])
                {
                    return nums[i];
                }
            }
            return nums[nums.Length - 1];
        }

        // majority number which repeated more than n/2
        public static int MajorityElement(int[] nums)
        {
            Array.Sort(nums);
            int count = 0, Number = nums[0];
            //for(int i=0;i<nums.Length;i++)
            //{
            //    if(Number==nums[i])
            //    {
            //        count++;
            //    }
            //    else
            //    {
            //        Number = nums[i];
            //        count=1;
            //    }
            //    if(count>nums.Length/2)
            //    {
            //        return nums[i];
            //    }
            //}
            foreach (int i in nums)
            {
                if (Number == i)
                {
                    count++;
                }
                else
                {
                    Number = i;
                    count = 1;
                }
                if(count>nums.Length/2)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
