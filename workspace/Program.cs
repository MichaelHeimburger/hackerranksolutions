using System;
using System.Collections.Generic;
using System.IO;

class Solution
{

    static void next_move(int posr, int posc, String[] board)
    {
        List<Trash> tlist = new List<Trash> { };
        for (int i = 0; board.Length > i; i++)
        {
            for (int a = 0; board[i].Length > a; a++)
            {
                if (board[i][a] == 'd')
                {
                    Trash trash = new Trash();
                    trash.row = i;
                    trash.col = a;
                    tlist.Add(trash);
                }
            }
        } // trash locator
        int choicerow = 0;
        int choicecol = 0;
        int choicedistance = 0;
        int rowbuffer = 0;
        int colbuffer = 0;
        int totalbuffer = 0;
        for (int i = 0; tlist.Count > i; i++)
        {
            rowbuffer = Math.Abs(tlist[i].row - posr);
            colbuffer = Math.Abs(tlist[i].col - posc);
            totalbuffer = rowbuffer + colbuffer;
            if ((rowbuffer == 0) && (colbuffer == 0))
            {
                Console.WriteLine("CLEAN");
                return;
            }

            if ((totalbuffer < choicedistance) || (i == 0))
            {
                choicecol = tlist[i].col;
                choicerow = tlist[i].row;
                choicedistance = Math.Abs(choicecol-posc) + Math.Abs(choicerow-posr);
            }
        } // distance selection


        if ((choicerow == posr) && (choicecol == posc))
        {
            Console.WriteLine("CLEAN");
            return;
        }
        if (choicerow > posr)
        {
            Console.WriteLine("DOWN");
            return;
        }
        if (choicerow < posr)
        {
            Console.WriteLine("UP");
            return;
        }


        if (choicecol > posc)
        {
            Console.WriteLine("RIGHT");
            return;
        }
        if (choicecol < posc)
        {
            Console.WriteLine("LEFT");
            return;
        }

    }

    static void Main(String[] args)
    {
        String temp = Console.ReadLine();
        String[] position = temp.Split(' ');
        int[] pos = new int[2];
        String[] board = new String[5];
        for (int i = 0; i < 5; i++)
        {
            board[i] = Console.ReadLine();
        }
        for (int i = 0; i < 2; i++) pos[i] = Convert.ToInt32(position[i]);
        next_move(pos[0], pos[1], board);
    }
}
public class Trash
{

    public int row { get; set; }
    public int col { get; set; }
}