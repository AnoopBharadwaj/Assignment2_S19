﻿using System;
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
            // This for loop uses another for loop to rotate the array d times
            for (int i = 0; i < d; i++)
            {
                int j;              // This variable is used to increment the below for loop                                    
                int first = a[0];   // This variable is used to store the first element of the array
                                    // in the current iteration of this for loop

                // This for loop rotates the array to the left once
                for (j = 0; j < a.Length - 1; j++)
                {
                    a[j] = a[j + 1];
                }

                a[j] = first; // This changes the last element of the array to the value stored
                              // in the first variable
            }

            return a;
        }

        // Complete the maximumToys function below.
        static int MaximumToys(int[] prices, int k)
        {
            int temp;
            for (int j = 0; j < prices.Length; j++)
            {
                int min_position = j;
                for (int l = j + 1; l < prices.Length; l++)
                {
                    if (prices[l] < prices[min_position])
                    {
                        min_position = l;
                    }
                }
                if (min_position != j)
                {
                    temp = prices[j];
                    prices[j] = prices[min_position];
                    prices[min_position] = temp;
                }
            }

            int n = prices.Length, total = 0, count = 0;
            for (int i = 0; i < n; i++)
            {
                total += prices[i];
                if (total > k)
                {
                    break;
                }
                count++;
            }
            return count;
        }

        // Complete the balancedSums function below.
        static string BalancedSums(List<int> arr)
        {
            string result = "NO";   // String variable to hold the result of the test

            // If the list only 1 element, the result is YES.
            if (arr.Count == 1)
            {
                result = "YES";
            }
            else
            {
                // Variables used to collect sum values used in the operation
                int sum1 = 0;   
                int sumLeft;
                int sumRight;

                // This for loop
                for (int i = 1; i < arr.Count; i++)
                {
                    sum1 += arr[i];
                }

                // If the sum of all elements to the right of the first element
                // is 0 the result is YES
                if (sum1 == 0)
                {
                    result = "YES";                    
                }
                else
                {
                    // This for loop increments through the list to determine is an element satisfies
                    // the condition of having equal sums on both sides
                    for (int i = 1; i < arr.Count; i++)
                    {
                        // Set the sum variables to 0
                        sumLeft = 0;    
                        sumRight = 0;

                        // Find sum of the left side of the element
                        for (int j = 0; j < i; j++)
                        {
                            sumLeft += arr[j];
                        }

                        // Find sum for the right side of the variable
                        for (int k = i + 1; k < arr.Count; k++)
                        {
                            sumRight += arr[k];
                        }

                        // If both the left and right side are equal, the result is YES
                        if (sumLeft == sumRight)
                        {
                            result = "YES";
                            break;  // Break out of the loop
                        }
                    }
                }
            }
            return result;
        }

        // Complete the missingNumbers function below.
        static int[] MissingNumbers(int[] arr, int[] brr)
        {
            int[] a = new int[brr.Length - arr.Length];
            int x;
            int count = 0;
            int count1 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                while (arr[i] != brr[i])
                {
                    x = brr[i];
                    for (int j = i; j < brr.Length - 1; j++)
                    {
                        brr[j] = brr[j + 1];
                    }
                    brr[brr.Length - 1] = x;

                }

            }

            for (int i = 0; i < brr.Length - arr.Length; i++)
            {
                a[i] = brr[arr.Length + i];
            }

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] == a[i])
                    {
                        a[j] = 0;
                    }
                }
            }



            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    count = count + 1;
                }
            }


            int[] b = new int[a.Length - count];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {
                    b[count1] = a[i];
                    count1 = count1 + 1;
                }
            }

            return b;
        }


        // Complete the gradingStudents function below.
        static int[] GradingStudents(int[] grades)
        {
            int[] roundedGrades = new int[grades.Length];   // Initialize array to hold rounded grades
            
            // For loop used to iterate through the grades in the array
            for (int i = 0; i < grades.Length; i++)
            {
                // If the grade is less than 38, the grade remains the same
                if (grades[i] < 38)
                {
                    roundedGrades[i] = grades[i];
                }
                else
                {
                    int nextMultiple = ((grades[i] / 5)*5) + 5; // This operation finds the next
                                                                // multiple of five 

                    // If the result of the operation is less than 3, round the grade and
                    // store it to the roundedGrades array. If not, it remains the same.
                    if (nextMultiple - grades[i] < 3)
                    {
                        roundedGrades[i] = nextMultiple;
                    }
                    else
                    {
                        roundedGrades[i] = grades[i];
                    }
                }
            }
            return roundedGrades;
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
              int d = 0;
            int count = 0;
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;

            for (int i = 0; i < arr.Length-1; i++)
            {
                count = arr.Length - (i + 1) + count;
            }
            int[] a = new int[count];

            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    d = arr[j] - arr[i];
                    a[count1] = d;
                    count1 = count1 + 1;
                }
            }

            for(int i=0;i<a.Length;i++)
            {
                if(a[i]<0)
                {
                    a[i] = (-1) * a[i];
                }
            }

            int diff = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (diff > a[i])
                {
                    diff = a[i];
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == diff)
                {
                    count2 = count2 + 1;
                }
            }

            int[] b = new int[2 * count2];

            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    d = arr[j] - arr[i];
                    if (d < 0)
                    {
                        d = (-1) * d; //Making the negative number to positive by multiplying it with -1.
                    }

                    if (d == diff)
                    {
                        
                        if (a[i] > a[j])
                        {
                            b[count3] = arr[j];
                            b[count3 + 1] = arr[i];
                            count3 = count3 + 2;
                        }
                        if (a[j] > a[i])
                        {
                            b[count3] = arr[i];
                            b[count3 + 1] = arr[j];
                            count3 = count3 + 2;
                        }
                    }

                }//End of  for loop
            }//End of for loop.

            return b;
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
