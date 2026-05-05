using System;
using System.Threading;
enum ActionState
{
    Idle,
    MoveForward,
    MoveBack
}


class Program
{
    static void Main(string[] args)
    {
        ActionState state = ActionState.Idle;

        Random rand = new Random();
        int[,] matrix = new int[5, 5];
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int randomRow = rand.Next(0, rows);
        int randomCol = rand.Next(0, cols);
        matrix[randomRow, randomCol] = 1;
        int randomRow2 = rand.Next(0, rows);
        int randomCol2 = rand.Next(0, cols);
        matrix[randomRow2, randomCol2] = 5;


        while (true)
        {
            // Top border
            Console.WriteLine("+" + new string('-', cols * 4) + "+");

            for (int i = 0; i < rows; i++)
            {
                Console.Write("|");
                Console.WriteLine();

                for (int j = 0; j < cols; j++)
                {
                    Console.Write($" {matrix[i, j],2} "); // spacing for alignment
                }

                Console.WriteLine("|");
            }
            Console.WriteLine("+" + new string('-', cols * 4) + "+"); //bottom border
        }
    }
}
