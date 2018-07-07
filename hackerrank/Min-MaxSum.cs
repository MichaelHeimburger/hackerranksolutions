using System.CodeDom.Compiler;
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

class Solution
{

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr)
    {
        double sum = 0;
        double summin = 0;
        double summax = 0;

        for (int i = 0; arr.Length > i; i++)
        {
            sum = (arr[0] + arr[1] + arr[2] + arr[3] + arr[4]) - arr[i];

            if ((sum > summax) || (i == 0))
            {
                summax = sum;
            }
            if ((sum < summin) || (i == 0))
            {
                summin = sum;
            }

        }
        Console.WriteLine(summin + " " + summax);
    }

    static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
