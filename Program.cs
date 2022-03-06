using System;
using System.Collections.Generic;

namespace backtracking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> board = new List<List<int>> {
            new List<int> { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
            new List<int> { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
            new List<int> { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
            new List<int> { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
            new List<int> { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
            new List<int> { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
            new List<int> { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
            new List<int> { 0, 0, 0, 4, 1, 9, 0, 0, 5 },
            new List<int> { 0, 0, 0, 0, 8, 0, 0, 7, 9 },
            };

        }
        static void print_board(List<List<int>> list)
        {
            if (list == null)
            {
                Console.WriteLine("There is no solution");
            }
            else
            {
                print_line(list[0]);
                print_line(list[1]);
                print_line(list[2]);
                print_line(list[3]);
                print_line(list[4]);
                print_line(list[5]);
                print_line(list[6]);
                print_line(list[7]);
                print_line(list[8]);
            }
        }
        static void print_line(List<int> list)
        {
            List<string> print = new List<string>();
            foreach (int item in list)
            {
                if (item == 0)
                {
                    print.Add(" ");
                }
                else
                {
                    print.Add(item.ToString());
                }
            }
        }
}
}