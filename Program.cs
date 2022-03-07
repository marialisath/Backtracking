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

            print_board(board);
            Console.WriteLine("");

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
        static List<int> find_zero(List<List<int>> list)
        {
            List<int> ret = new List<int> { 0, 0 };
            bool found = false;

            do
            {
                if (list[ret[0]][ret[1]] == 0)
                {
                    found = true;
                }
                else
                {
                    ret[1]++;
                    if (ret[1] > 8)
                    {
                        ret[0]++;
                        ret[1] = 0;
                    }
                }
            
             } while (ret[0] < list.Count && !found);
               return ret;
        }
        static List<List<int>> Solve(List<List<int>> board)
        {
            List<int> zero = find_zero(board);
            {
                if (zero[0] >= board.Count)
            {
                return board;
            }
                for (int i = 1; i < 10; i++)
                {
                    if (is_valid(board, zero[0], zero[1], i))
                    {
                        board[zero[0]][zero[1]] = i;
                        var solution = Solve(board);
                        if (solution != null)
                        {
                            return solution;
                        }
                        else board[zero[0]][zero[1]] = 0;
                    }
                }
                return null;
            }
        }
        static bool is_valid(List<List<int>> board, int row, int col, int value)
        {
            if (board[row].Contains(value))
            {
                return false;
            }
            foreach (List<int> list in board)
            {
                if (list[col] == value)
                {
                    return false;
                }
            }
            List<int> square = new List<int>();
            int square_col = 0;
            int square_row = 0;
            if (row > 2)
            {
                square_row = 3;
            }
            if (row > 5)
            {
                square_row = 6;
            }
            if (col > 2)
            {
                square_col = 3;
            }
            if (col > 5)
            {
                square_col = 6;
            }
            for (int i = square_row; i < (square_row + 3); i++)
            {
                for (int j = square_col; j < (square_col + 3); j++)
                {
                    square.Add(board[i][j]);
                }
            }
            if (square.Contains(value))
            {
                return false;
            }
            return true;
        }
    }
}

