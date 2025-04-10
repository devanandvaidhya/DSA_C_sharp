using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAProblems.Array
{


    public class ArrayProblems
    {

     

        // Find largest element in the array

        public void LargestElement() // o(n)
        {
            int[] arr = { 2, 5, 3, 9, 7, 6, 0 };
            int largest = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }
            Console.WriteLine("Largest element from the array is : "+ largest);
        }

        // Second Largest lement in te array without sorting

        public void SecondLargest() // o(n)
        {
            int[] arr = { 2, 5, 3, 9, 7, 9, 8 };

            int largest = arr[0];
            int secondLargest = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    secondLargest = largest;
                    largest = arr[i];
                }
                else if (arr[i] < largest && arr[i] > secondLargest)
                {
                    secondLargest = arr[i];
                }
            }

         
            Console.WriteLine("Second largest element from array is : " + secondLargest);
        }

        // Second smallest element from array

        public void SecondSamllest()
        {
            int[] arr = { 3, 5, 2, 8, 4, 1 };
            int smallest = arr[0];
            int ssmallest = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    ssmallest = smallest;
                    smallest = arr[i];
                }
                else if (arr[i] != smallest && arr[i] < ssmallest )
                {
                    ssmallest = arr[i];
                }
            }
            Console.WriteLine("Second smallest element from array is : " + ssmallest);
        }

        // Check the array is sorted or not
        public void chkIsSort()
        {
            //int[] arr = { 5, 3, 8, 2, 0, 6, 1, 8 };
            int[] arr = { 2, 3, 5, 7, 9, 10, 15 };
            bool IsSorted = true;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] <= arr[i + 1])
                {
                }
                else
                {
                    IsSorted = false;
                    break;
                }
            }
            if (IsSorted)
            {
                Console.WriteLine("Array is sorted");
            }
            else
            {
                Console.WriteLine("Array is not sorted");
            }
            
        }

        // Remove duplicate in place from sorted array
        // also calculate lenght
        public void Removeduplicate()
        {
            int[] arr = { 1, 1, 1, 2, 2, 3, 3, 3, 4, 4, };
            int[] uniquearr = new  int[arr.Length];
            ArrayList unique = new ArrayList();
            int i = 0;
            unique.Add(arr[i]); 
            for (int j = 1; j < arr.Length; j++)
            {
                if (arr[i] != arr[j])
                {
                    arr[i+1] = arr[j];
                    unique.Add(arr[j]);
                    i++;
                }
            }
            Console.WriteLine("Array lenght is : "+ (i+1));

            foreach (var value in unique)
            {
                Console.WriteLine("Unique array is " + value);
            }
        }

        // Left rotate an array by one place

        public void LeftRotatebyOne()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            int temp = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[arr.Length - 1] = temp;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Array is look like" + arr[i]);
            }
        }

        // Left rotate an array by D place
        public void LeftRotateByDPlace()
        {
            // D = 8
            // array size is 7
            // int rotate = D % arraysize
            // Now D =3
            int D = 8;
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int[] temp = new int[D];
            D = D % arr.Length;
            

            for (int i = 0; i < D; i++)
            {
                temp[i] = arr[i];
            }

            for (int i = D; i < arr.Length; i++)
            {
                arr[i-D] = arr[i];
            }

            int k = 0;
            for (int i = arr.Length-D; i < arr.Length; i++)
            {
                arr[i] = temp[k];
                k++;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }


        // Move all zero to end

        public void MoveZeroToEnd()
        {
            int[] arr = { 3, 0, 4, 0, 1, 3, 0, 8, 3 };
            int j = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    j = i;
                    break;
                }
            }
            if (j == -1)
            {
                Console.WriteLine("Array is non zero");
            }

            for (int i = j + 1; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    j++;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Now array is : "+ arr[i]);
            }
        }

        // linear search in array

        public void LSearch()
        {
            int[] arr = { 2, 3, 5, 7, 9, 10, 15 };
            int value = 5;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    Console.WriteLine("value is :" + arr[i] + " and located at " + i);
                }
            }
        }

        // Union of two sorted array
        public void UnionTwoArray()
        {
            int[] arr = {1,1,2,3,3,4,5 };
            int[] arr1 = {1,2,4,5 ,6};
            List<int> union = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!union.Contains(arr[i]))
                {
                    union.Add(arr[i]);
                }
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                if (!union.Contains(arr1[i]))
                {
                    union.Add(arr1[i]);
                }
            }

            for (int i = 0; i < union.Count; i++)
            {
                Console.WriteLine("Union array is : "+ union[i]);
            }
        }


        // Intersection of two sorted array

        public void IntersectTwoArray()
        { 
        
        }

        // Finding missing number in an array

        public void MissingNumber()
        {
            int[] arr = { 1, 2, 4, 5 };
            int sum = 0;
            int n = arr.Length + 1; // because one missing number
            sum = n * (n + 1) / 2;
            //sum = arr.Length * (arr.Length + 1) / 2;
            int actualSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                actualSum += arr[i];
            }
            int missingNumber =   sum- actualSum;
            Console.WriteLine("Missing number is " + missingNumber);
        }

        // Maximum consecutive ones

        public void MaxConsecutiveOnes()
        {
            int[] arr = { 1, 1, 0, 1, 1, 1, 0, 1, 1 };  // 1,1,1 max consecutive one is three

            int count = 0;
            int maxones = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    count++;
                    maxones = maxones > count ? maxones : count;
                }
                else
                {
                    count = 0;
                }
            }

            Console.WriteLine("Maximum consecutive one's in the array is : "+ maxones);
        }

        // Find the number that appears once and other number twice
        // uing xor preoperty
        // 0^0=0, 1^1=0,3^3=0 but 1^2=2 right hand element will be return
        public void findAppearsOnce()
        {
            int[] arr = { 1, 1, 2,2,  3, 4, 4, 5, 5 };
            int xor = 0;
            for (int i = 0; i < arr.Length; i++)
            { 
                xor=xor^ arr[i];
            }

            Console.WriteLine("Element which is appears once is : " + xor);
        }

        // Longest subarray with given sum(Positive)
        // means longest subarray with sum k positive
        // subarray means contigious part of the array
        //Longest Sub-Array with Sum K 

        public void LongestSubArraySumK()
        {
            int[] arr = { 1, 2, 3, -1, 1, 1, 1 };
            int k = 5;
            Dictionary<int, int> prefixsumMap = new Dictionary<int, int>();
            int maxlenght = 0;
            int prefixSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                prefixSum += arr[i];

                if (prefixSum == k)
                {
                    maxlenght = i + 1;
                }
                if (prefixsumMap.ContainsKey(prefixSum - k))
                { 
                    int prevIndex= prefixsumMap[prefixSum - k];
                    maxlenght = Math.Max(maxlenght, i - prevIndex);
                }

                if (!prefixsumMap.ContainsKey(prefixSum))
                {
                    prefixsumMap[prefixSum] = i;
                }
            }
            Console.WriteLine("Longest Sub-Array with Sum K lenght is  : " + maxlenght);

        }

        // 2 sum problem

        public void twoSum()
        {
            //int[] arr = { 2, 7, 11, 15 };
            List<int> arr = new List<int> { 2, 7, 11, 15 };
            arr.Sort();
            int target = 9;
            int left = 0;
            int right = arr.Count - 1;
         

            while(left<right)
            {
                int sum = arr[left] + arr[right];
                if (sum == target)
                {
                    Console.WriteLine("Sum of two number is : " + sum + " and location at " +left + " " +right);
                    break;
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }

            }
        }

        // Sort an array 0's , 1's and 2's 

        public void Sortzersoonestwos()
        {
            int[] arr = { 0, 1, 2, 0, 1, 2, 1, 2, 0, 0, 0, 1 };
            int low = 0, mid = 0, high = arr.Length - 1;
            while (mid <= high) 
            {
                if (arr[mid] == 0)
                {
                    Swap(arr, low, mid);
                      low++;
                    mid++;
                }
                else if (arr[mid] == 1)
                {
                    mid++;
                }
                else
                {
                    Swap(arr, mid, high);
                    high--;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("sorted : " + arr[i]);
            }
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        // Majority element N/2

        public void MajorityElement()
        {
            int[] arr = { 2, 2, 3, 3, 1, 2, 2 };
            Dictionary<int,int> count = new Dictionary<int, int>();
            int majorityCount = arr.Length / 2;
            bool flag = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!count.ContainsKey(arr[i]))
                {
                    count[arr[i]] = 0;
                }
                count[arr[i]]++;
                if (count[arr[i]] > majorityCount)
                {
                    flag = true;
                    Console.WriteLine("Majority element is : " + arr[i]);
                    break;
                }
            }
            if (!flag)
            { 
            Console.WriteLine("No majority element");
            }
        }


        // Maximum subarray sum using kadane's algorithm
        // if sam <0 then make the sum zero
        public void MaxSubarray()
        {
            int[] arr = { -2, -3, 4, -1, -2, 1, 5, -3 };
            int sum = 0;
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
                if (sum > max)
                {
                    max = sum;
                }

                if(sum<0)
                {
                    sum = 0;
                }
            }
            Console.WriteLine("Maximum subarray sum is : "+ (max>sum?max:sum));
        }

    }


}
