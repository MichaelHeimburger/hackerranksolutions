using System;
using System.Collections.Generic;
using System.IO;
class Solution
{

    static void displayPathtoPrincess(int n, String[] grid)
    {
        int pline = 0;
        int pchar = 0;
        int mline = 0;
        int mchar = 0;
        for (int line = 0; grid.Length > line; line++)
        {


            for (int ccheck = 0; grid[line].Length > ccheck; ccheck++)
            {

                if (grid[line].ToCharArray()[ccheck] == 'p')
                {
                    pline = line;
                    pchar = ccheck;

                }
                if (grid[line].ToCharArray()[ccheck] == 'm')
                {
                    mline = line;
                    mchar = ccheck;
                }
            }
        }    // end loop       

        if (mchar > pchar)
        {
            while (mchar > pchar)
            {
                Console.WriteLine("LEFT");
                pchar++;
            }
        }
        else
        {
            while (mchar < pchar)
            {
                Console.WriteLine("RIGHT");
                mchar++;
            }
        }
        if (mline > pline)
        {
            while (mline > pline)
            {
                Console.WriteLine("UP");
                pline++;
            }
        }
        else
        {
            while (mline < pline)
            {
                Console.WriteLine("DOWN");
                mline++;
            }
        }
    }


    static void Main(String[] args)
    {
        int m;

        m = int.Parse(Console.ReadLine());

        String[] grid = new String[m];
        for (int i = 0; i < m; i++)
        {
            grid[i] = Console.ReadLine();
        }

        displayPathtoPrincess(m, grid);
    }
}