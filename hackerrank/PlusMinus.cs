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

class PlusMins
{

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
        decimal zeros = 0;
        decimal pos = 0;
        decimal neg = 0;
        decimal leng = Convert.ToDecimal(arr.Length);
        foreach(int num in arr)
        {
            if(num>0)
            {
                pos++;
            }
            if(num<0)
            {
                neg++;
            }
            if(num==0)
            {
                zeros++;
            }
        }
        Console.WriteLine(pos/leng);
        Console.WriteLine(neg /leng);
        Console.WriteLine(zeros /leng);



    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
