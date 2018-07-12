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
        double maxnum = 0;
        double minnum = 0;
        double summin = 0;
        double summax = 0;

        foreach (int i in arr)
        {
            if
}

        for (int i = 0; arr.Length > i; i++)
        {
            if ((arr[i] < minnum) || (i == 0))
            {
                minnum = arr[i];
            }
            if (arr[i] > maxnum)
            {
                maxnum = arr[i];
            }
        }
        foreach (int i in arr)
        {
            if (i != minnum)
            {
                summax += i;
            }
            if (i != maxnum)
            {
                summin += i;
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
