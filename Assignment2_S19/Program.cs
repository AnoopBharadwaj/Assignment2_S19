using System;
using System.Collections.Generic;

namespace Assignment2_S19
{
    class Program
    {
        static void Main(string[] args)
        {
            // left rotation
            Console.WriteLine("Left Rotation");
            int d = 4;
            int[] a = { 1, 2, 3, 4, 5 };
            int[] r = RotLeft(a, d);
            DisplayArray(r);

            // Maximum toys
            Console.WriteLine("\n\nMaximum toys");
            int k = 50;
            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            Console.WriteLine(MaximumToys(prices, k));

            // Balanced sums
            Console.WriteLine("\n\nBalanced sums");
            List<int> arr = new List<int> { 1, 2, 3 };
            Console.WriteLine(BalancedSums(arr));

            // Missing numbers
            Console.WriteLine("\n\nMissing numbers");
            int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206};
            int[] brr = {203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204};
            int[] r2 = MissingNumbers(arr1, brr);
            DisplayArray(r2);

            // grading students
            Console.WriteLine("\n\nGrading students");
            int[] grades = { 73, 67, 38, 33 };
            int[] r3 = GradingStudents(grades);
            DisplayArray(r3);

            // find the median
            Console.WriteLine("\n\nFind the median");
            int[] arr2 = {8, 10, 2, 6, 3};
            Console.WriteLine(FindMedian(arr2));
            Console.ReadLine();

            // closest numbers
            Console.WriteLine("\n\nClosest numbers");
            int[] arr3 = { 5, 4, 3, 2 };
            int[] r4 = ClosestNumbers(arr3);
            DisplayArray(r4);

            // Day of programmer
            Console.WriteLine("\n\nDay of Programmer");
            int yr = 2018;
            Console.WriteLine(DayOfProgrammer(yr));
            Console.ReadLine();
        }

        static void DisplayArray(int []arr) {
            Console.WriteLine();
            foreach(int n in arr) {
                Console.Write(n + " ");
            }
        }

        // Complete the rotLeft function below.
        static int[] RotLeft(int[] a, int d)
        {
            return new int[] {};
        }

        // Complete the maximumToys function below.
        static int MaximumToys(int[] prices, int k)
        {
            return 0;
        }

        // Complete the balancedSums function below.
        static string BalancedSums(List<int> arr)
        {
            return "";
        }

        // Complete the missingNumbers function below.
        static int[] MissingNumbers(int[] arr, int[] brr)
        {
            return new int[] { };
        }


        // Complete the gradingStudents function below.
        static int[] GradingStudents(int[] grades)
        {
            return new int[] { };
        }

        // Complete the findMedian function below.
        static int[] SorArr(int[] arr) //method defined to sort the array

        {

            for (int i = 0; i < arr.Length-1; i++)      //for loop declared to define i as 0 

            {

                for (int j = i + 1; j < arr.Length; j++)    //to compare numbers and swap according to the ascending order to sort array

                {

                    if (arr[j] < arr[i])      

                    {

                        int mov = arr[i]; //defined variable mov to set as value of ith element

                        arr[i] = arr[j]; //if ith element is same as jth element

                        arr[j] = mov;  //then mov will take the value of the jth element as well

                    }

                }

            }

            return arr; //return the array

        }
        static int FindMedian(int[] arr2)
        {
             int median = 0;

            try

            {

                arr2 = SorArr(arr2);    //defining SorArr method for input array arr2

                int len = arr2.Length; //converting array length into integer 



                if (arr2 == null || len == 0 ) //if array is null or length of array is null or length is divisible by 2

                {

                    Console.WriteLine("Array cannot be empty or have no integers");

                }

                else

                {

                    median = arr2[(len) / 2];  //median is length of array divided by 2  

                }

            }

            catch

            {

                Console.WriteLine("Exception occured");

            }

            Console.ReadKey();

            return median; //return median output 
        }

        private static int[] SortArray(int[] arr2)
        {
            throw new NotImplementedException();
        }

        // Complete the closestNumbers function below.
        static int[] ClosestNumbers(int[] arr)
        {
            return new int[] { };
        }

        // Complete the dayOfProgrammer function below.
        static string DayOfProgrammer(int yr)
        {
            if (yr <= 1917) //during Julian calendar
            {
                if (yr % 4 == 0) //if given year is divisible by 4
                {
                    return "12.09." + yr; //output date will have 12.09
                }
                else
                {
                    return "13.09." + yr; //if not divisible by 4, then output date will have 13.09
                }
            }
            else if(yr == 1918) //between Julian calendar and Gregorian calendar
            {
                return "26.09." + yr; //return output date as 26.09.2018
            }
            else
            {
                if (yr % 400 == 0 || yr % 4 == 0 && yr % 100 != 0) //if input year is divisble by 400 or divisible by 4 and not by 100
                {
                    return "12.09." + yr; //return output date as 12.09
                }
                else
                {
                    return "13.09." + yr; //else return output date as 13.09
                }
            }
        }
    }
}
