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

class DiagonalDifference
{

    // Complete the diagonalDifference function below.
    static int diagonalDifference(int[][] arr)
    {
        int tdiff = 0;
        int fsum = 0;
        int ssum = 0;
        int counter = 0;
        //adding the first diag
        for(int c = 0;arr.Length > c;c++)
        {
            fsum += arr[c][c];
        }
        //adding the second diag
        for (int c = 0; arr.Length > c; c++)
        {
            ssum += arr[c][(arr.Length-c)-1];
        }
        tdiff = Math.Abs(fsum - ssum);
        return tdiff;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[][] arr = new int[n][];

        for (int i = 0; i < n; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
