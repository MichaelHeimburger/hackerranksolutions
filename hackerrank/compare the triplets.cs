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

class compare_the_triplets
{

    // Complete the solve function below.
    static int[] solve(int[] a, int[] b)
    {
        int aa = 0;
        int bb = 0;
        for (int j = 0; a.Length > j; j++)
        {
            if (a[j] > b[j])
            {
                aa++;
            }
            if (b[j] > a[j])
            {
                bb++;
            }
        }
        int[] score = new int[] { aa, bb };
        return score;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;

        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp))
        ;
        int[] result = solve(a, b);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
