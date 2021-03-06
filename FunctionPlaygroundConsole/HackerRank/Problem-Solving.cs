﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace FunctionPlayground.HackerRank
{
    public class ProblemSolving
    {
        /* 
        
            -- Diagonal Difference --
            Given a square matrix of size N x N, calculate the absolute difference between the sums of its
            diagonals.

            - Input Format
            The first line contains a single integer, . The next lines denote the matrix's rows, with each line
            containing space-separated integers describing the columns.

            - Constraints
            -100 <= Elements in the matrix <= 100

            - Output Format
            Print the absolute difference between the two sums of the matrix's diagonals as a single integer.
            
            - Sample Input
            3
            11 2 4
            4 5 6
            10 8 -12

            - Sample Output
            15

            - Explanation
            The primary diagonal is:
            
            11
               5
                 -12

            Sum across the primary diagonal: 11 + 5 - 12 = 4
            The secondary diagonal is:
            
            4
              5
                10

            Sum across the secondary diagonal: 4 + 5 + 10 = 19
            Difference: |4 - 19| = 15
            Note: |x| is absolute value function

        */
        // Complete the diagonalDifference function below.
        public static int diagonalDifference(int[][] arr)
        {
            int primaryDiag = 0;
            int secondaryDiag = 0;

            int primaryIndexCounter = arr[arr.Length - 1].Length - 1;
            int secondaryIndexCounter = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                primaryDiag += arr[i][primaryIndexCounter];
                primaryIndexCounter--;
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                secondaryDiag += arr[i][secondaryIndexCounter];
                secondaryIndexCounter++;
            }

            int result = Math.Abs(primaryDiag - secondaryDiag);
            return result;
        }

        // Complete the plusMinus function below.
        public static void plusMinus(int[] arr)
        {
            int positives = 0;
            int negatives = 0;
            int zeros = 0;

            foreach (int item in arr)
            {
                if (item > 0) { positives++; }
                if (item == 0) { zeros++; }
                if (item < 0) { negatives++; }
            }

            decimal positivesDec = (decimal)positives / arr.Length;
            decimal negativesDec = (decimal)negatives / arr.Length;
            decimal zerosDec = (decimal)zeros / arr.Length;

            Console.WriteLine(positivesDec.ToString("N6"));
            Console.WriteLine(negativesDec.ToString("N6"));
            Console.WriteLine(zerosDec.ToString("N6"));
        }

    }
}