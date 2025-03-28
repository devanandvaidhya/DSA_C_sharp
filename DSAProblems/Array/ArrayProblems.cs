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

    }


}
