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

            }
        }
    }
}