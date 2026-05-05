using System;
using System.Threading;
enum ActionState
{
    Down,
    Up,
    Right,
    Left,
    Idle
}


class Program
{
    
    static void Main(string[] args)
    {
        ActionState state = ActionState.Idle;
        int score = 0;
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
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.W:
                        state = ActionState.Up;
                        break;
                    case ConsoleKey.S:
                        state = ActionState.Down;
                        break;
                    case ConsoleKey.A:
                        state = ActionState.Left;
                        break;
                    case ConsoleKey.D:
                        state = ActionState.Right;
                        break;

                }

            }
            switch (state)
            {
               
                case ActionState.Up:
                    if (matrix[randomRow, randomCol] < cols - 1 || randomRow - 1 > 
                    {
                        if (matrix[randomRow, randomCol] == 5)
                        {
                            score++;
                            Console.WriteLine("You collected a point!");
                        }
                        matrix[randomRow, randomCol] = 0; // Clear current position
                        randomRow--;
                        matrix[randomRow, randomCol] = 1; // Move up
                    }
                    break;
                case ActionState.Down:
                    if (matrix[randomRow, randomCol] == 5)
                    {
                        score++;
                        Console.WriteLine("You collected a point!");
                    }
                    matrix[randomRow, randomCol] = 0; // Clear current position
                    randomRow++;
                    matrix[randomRow, randomCol] = 1; // Move down

                    break;
                case ActionState.Left:
                    if (matrix[randomRow, randomCol] == 5)
                    {
                        score++;
                        Console.WriteLine("You collected a point!");
                    }
                    matrix[randomRow, randomCol] = 0; // Clear current position
                    randomCol--;
                    matrix[randomRow, randomCol] = 1; // Move left
                    break;
                case ActionState.Right:
                    if (matrix[randomRow, randomCol] == 5)
                    {
                        score++;
                        Console.WriteLine("You collected a point!");
                    }
                    matrix[randomRow, randomCol] = 0; // Clear current position
                    randomCol++;
                    matrix[randomRow, randomCol] = 1; // Move right

                    break;
            }




            // Top border
            Console.WriteLine("+" + new string('-', cols * 4) + "+");

            for (int i = 0; i < rows; i++)
            {
                Console.SetCursorPosition(0, i + 1); // Move cursor to the beginning of the line
                Console.Write("|");
                Console.WriteLine();

                for (int j = 0; j < cols; j++)
                {
                    Console.Write($" {matrix[i, j],2} "); // spacing for alignment
                }

                Console.WriteLine("|");
            }
            Console.WriteLine("+" + new string('-', cols * 4) + "+"); //bottom border
            Console.WriteLine($"Score: {score}");
            System.Threading.Thread.Sleep(100);
            // Console.Clear();

            }
        }
    }

