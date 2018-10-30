using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LeetCodeSolutionsLib
{
    public class TwoSums : Solution
    {
        #region Two Sums
         /** Problem: Two Sum
          *  Given an array of integers (int[] nums)
          *  Return: the indices of two numbers such that they equal the target number
          *
          *  EXAMPLE:
          *  Given nums = [2, 7, 11, 15], target = 9,
          *  nums[0] + nums[1]
          *  2 + 7 = 9,
          *  Return: [0, 1]
          */
        private int[] nums;
        private int target;
        public TwoSums(int[] nums, int target)
        {
            this.nums = nums;
            this.target = target;
        }
        private int[] TwoSumBruteForce(int[] nums, int target)
        {
            //Loop through all numbers and see if i + j == target
            //Time Complexity: O(n^2)
            //Space Complexity:O(1)
            int[] answer = {0, 0};
            for (int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; i++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        answer[0] = i;
                        answer[1] = j;
                        Console.Write($"{answer[0]} + {answer[1]} == {target}");
                    }
                }
            }
            return answer;
        }

        private int[] TwoSumWithDictionary2Pass(int[] nums, int target)
        {
            //Loop through array once and store value and index into a dictionary (hashtable), then check if complement exists
            //  IE: nums = [2, 7, 11, 15] and target = 9
            //  Check target - num[0] = Complement
            //  9 - 2 = Complement
            //  7 = Complement
            //  Search for 7 in the dictionary, which has a lookup of constant time
            //Time Complexity: O(n)
            //Space Complexity:O(n)
            //Dictionary<int, int> dictionary = new Dictionary<int, int>();
            Hashtable hashTable = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                //Store nums array into dictionary 
                //dictionary.Add(nums[i], i);          //Storing as <arrValue, arrIndex>
                hashTable[nums[i]] = i;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (hashTable.ContainsKey(complement) && (int)hashTable[complement] != i) //Check if dictionary contains key, also check that we don't count same num 2x dictionary[key] != i
                {
                    return new int[] {i, (int)hashTable[complement]}; 
                }
            }
            throw new Exception("No Answers Found");
        }

        private int[] TwoSumWithDictionary1Pass(int[] nums, int target)
        {
            //Instead of 1 loop to create the hashtable and another loop to go through the numsArray. We can create the hashTable while going through the nums Array.
            //  At each iteration, check if the hashTable contains the complement, if true, then return the indices
            //IE nums = [2, 7, 11, 15] target = 9
            Hashtable hashTable = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];      //complement = 9 - 2 ==> 7
                if (hashTable.ContainsKey(complement))  //if hashTable has key = 7, then return the current index (i) and the value of the hashTable, when passing the the complement as a key
                {
                    return new int[] { i, (int)hashTable[complement] };
                }
                hashTable[nums[i]] = i;                 //if the hashTable does not contain the key, then add a new entry to the hashTable where value = array index.
            }
            throw new Exception("No Answers Found");
        }
        #endregion

        public override void PrintExample()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var results = TwoSumWithDictionary1Pass(this.nums, this.target);
            watch.Stop();
            Console.WriteLine($"1. Two Sums = ");
            Console.Write($"int[] nums = [");
            foreach (int num in this.nums)
            {
                Console.Write($"{num}, ");
            }
            Console.Write($"]");
            Console.WriteLine($"Target = {this.target} \n" +
                              $"Results: [{results[0]}, {results[1]}] \n" +
                              $"Execution Speed: {watch.ElapsedMilliseconds}ms \n");
        }
    }
}
