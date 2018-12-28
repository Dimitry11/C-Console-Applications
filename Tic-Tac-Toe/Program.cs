using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    /*     
Вот игра крестики нолики, тут все готово кроме:
1. Бизнес логики (нет проверки на выигрышную ситуацию, 
когда три подряд креста или нолика в ряд или по диагонали вместе) - ваше домашнее задание.
2. Оформление: 
Отрисовка поля серым, 
Игрок 1 - синий цвет, 
Игрок 2 - Красный цвет, 
Выигрышная комбинация зеленым цветом - ваше домашнее задание.
    */
    class Program
    {
        static string[][] map = new string[4][];
        static void Main(string[] args)
        {         
            map[0] = new string[4] { "/", "1", "2", "3" };
            map[1] = new string[4] { "1", ".", ".", "." };
            map[2] = new string[4] { "2", ".", ".", "." };
            map[3] = new string[4] { "3", ".", ".", "." };
            ShowMap();

            bool isHave = true;
            int numPlayer = 1;
            while (isHave) // for(;;)
            {
                StepsPlayers(numPlayer);
                if (numPlayer == 1)                                
                    numPlayer = 2;
                else
                    numPlayer = 1;
                isHave = HaveEmptyFieldOnMap();
            }
            //Console.WriteLine($"{(char)008}{Console.BackgroundColor = ConsoleColor.White}");            
            Console.ReadLine();
        }

        static void ShowMap()
        {
            Console.ResetColor();
            for (int h = 0; h < map.Length; h++)
            {
                for (int v = 0; v < map[h].Length; v++)
                {
                    Console.Write($"{map[h][v]}\t");
                }
                Console.WriteLine();
            }
            WinnerX();
            WinnerO();
        }

        static bool HaveEmptyFieldOnMap()
        {
            bool isHave = false;
            for (int h = 0; h < map.Length; h++)
            {
                for (int v = 0; v < map[h].Length; v++)
                {
                    if (map[h][v] == ".")
                    {
                        isHave = true;
                    }
                }
            }
            return isHave;
        }

        static bool CheckMap(int h, int v)
        {
            if (map[h][v] == "X" || map[h][v] == "O")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static void StepsPlayers(int numberPlayer)
        {
            bool isCorrect = false;// numb = (bool)(numberPlayer == 1) ? 'X':'O';
            char ch = numberPlayer == 1 ? 'X' : 'O';
            var color = numberPlayer == 1 ? Console.ForegroundColor = ConsoleColor.Blue : Console.ForegroundColor = ConsoleColor.Red;
            while (!isCorrect)
            {
                try
                {
                    Console.WriteLine($"Please enter coordinate for Player {numberPlayer}: (.{ch}.)", color);
                    string step = Console.ReadLine();  
                    if (step.IndexOf("X") > -1)
                    {
                        string[] coords = step.Split('X'); 
                        int h = int.Parse(coords[0]); 
                        int v = int.Parse(coords[1]); 

                        if (CheckMap(h, v))
                        {
                            if (numberPlayer == 1)
                            {
                                map[h][v] = "X";
                            }
                            isCorrect = true;
                        }
                        else
                        {
                            Console.WriteLine("Enter anoter point, this is field busy");
                        }
                    }
                    if (step.IndexOf("O") > -1)
                    {
                        string[] coords = step.Split('O'); //12
                        int h = int.Parse(coords[0]); // 1
                        int v = int.Parse(coords[1]); // 2

                        if (CheckMap(h, v))
                        {
                            if (numberPlayer == 2)
                            {
                                map[h][v] = "O";
                               // WinnerY();
                            }
                            isCorrect = true;
                        }
                        else
                        {
                            Console.WriteLine("Enter anoter point, this is field busy");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Coordinates");
                    }
                }
                catch
                {
                    Console.WriteLine("Someelse wrong!");
                }
            }
            Console.Clear();
            ShowMap();
        }
        static void WinnerX()
        {
            //Console.Clear();
            if (map[1][1] == "X" && map[1][2] == "X" && map[1][3] == "X")
            {

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                //Console.Clear();
                Console.WriteLine("Winner is X (Player 1)\n\n\tPress ESCAPE for Start New Game..");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.ResetColor();
                    map[0] = new string[4] { "/", "1", "2", "3" };
                    map[1] = new string[4] { "1", ".", ".", "." };
                    map[2] = new string[4] { "2", ".", ".", "." };
                    map[3] = new string[4] { "3", ".", ".", "." };
                    //ShowMap();
                }
            }
            else if (map[2][1] == "X" && map[2][2] == "X" && map[2][3] == "X")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                //Console.Clear();
                Console.WriteLine("Winner is X (Player 1)\n\n\tPress ESCAPE for Start New Game..");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.ResetColor();
                    map[0] = new string[4] { "/", "1", "2", "3" };
                    map[1] = new string[4] { "1", ".", ".", "." };
                    map[2] = new string[4] { "2", ".", ".", "." };
                    map[3] = new string[4] { "3", ".", ".", "." };
                    //ShowMap();
                }
            }
            if (map[3][1] == "X" && map[3][2] == "X" && map[3][3] == "X")
            {

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                //Console.Clear();
                Console.WriteLine("Winner is X (Player 1)\n\n\tPress ESCAPE for Start New Game..");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.ResetColor();
                    map[0] = new string[4] { "/", "1", "2", "3" };
                    map[1] = new string[4] { "1", ".", ".", "." };
                    map[2] = new string[4] { "2", ".", ".", "." };
                    map[3] = new string[4] { "3", ".", ".", "." };
                    //ShowMap();
                }
            }
            // Diagonals:
            if (map[1][1] == "X" && map[2][2] == "X" && map[3][3] == "X")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                //Console.Clear();
                Console.WriteLine("Winner is X (Player 1)\n\n\tPress ESCAPE for Start New Game..");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.ResetColor();
                    map[0] = new string[4] { "/", "1", "2", "3" };
                    map[1] = new string[4] { "1", ".", ".", "." };
                    map[2] = new string[4] { "2", ".", ".", "." };
                    map[3] = new string[4] { "3", ".", ".", "." };
                    //ShowMap();
                }
            }
            if (map[3][1] == "X" && map[2][2] == "X" && map[1][3] == "X")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                //Console.Clear();
                Console.WriteLine("Winner is X (Player 1)\n\n\tPress ESCAPE for Start New Game..");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.ResetColor();
                    map[0] = new string[4] { "/", "1", "2", "3" };
                    map[1] = new string[4] { "1", ".", ".", "." };
                    map[2] = new string[4] { "2", ".", ".", "." };
                    map[3] = new string[4] { "3", ".", ".", "." };
                    //ShowMap();
                }
            }
            // Columns:
            if (map[1][1] == "X" && map[2][1] == "X" && map[3][1] == "X")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                //Console.Clear();
                Console.WriteLine("Winner is X (Player 1)\n\n\tPress ESCAPE for Start New Game..");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.ResetColor();
                    map[0] = new string[4] { "/", "1", "2", "3" };
                    map[1] = new string[4] { "1", ".", ".", "." };
                    map[2] = new string[4] { "2", ".", ".", "." };
                    map[3] = new string[4] { "3", ".", ".", "." };
                    //ShowMap();
                }
            }
            if (map[1][2] == "X" && map[2][2] == "X" && map[3][2] == "X")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                //Console.Clear();
                Console.WriteLine("Winner is X (Player 1)\n\n\tPress ESCAPE for Start New Game..");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.ResetColor();
                    map[0] = new string[4] { "/", "1", "2", "3" };
                    map[1] = new string[4] { "1", ".", ".", "." };
                    map[2] = new string[4] { "2", ".", ".", "." };
                    map[3] = new string[4] { "3", ".", ".", "." };
                    //ShowMap();
                }
            }
            if (map[1][3] == "X" && map[2][3] == "X" && map[3][3] == "X")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                //Console.Clear();
                Console.WriteLine("Winner is X (Player 1)\n\n\tPress ESCAPE for Start New Game..");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.ResetColor();
                    map[0] = new string[4] { "/", "1", "2", "3" };
                    map[1] = new string[4] { "1", ".", ".", "." };
                    map[2] = new string[4] { "2", ".", ".", "." };
                    map[3] = new string[4] { "3", ".", ".", "." };
                    //ShowMap();
                }
            }
        }
        static void WinnerO()
        {//Console.Clear();
            if (map[1][1] == "O" && map[1][2] == "O" && map[1][3] == "O")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                //Console.Clear();
                Console.WriteLine("Winner is O(Player 2)\n\n\tPress ESCAPE for Start New Game..");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.ResetColor();
                    map[0] = new string[4] { "/", "1", "2", "3" };
                    map[1] = new string[4] { "1", ".", ".", "." };
                    map[2] = new string[4] { "2", ".", ".", "." };
                    map[3] = new string[4] { "3", ".", ".", "." };
                    //ShowMap();
                }
            }
            else if (map[2][1] == "O" && map[2][2] == "O" && map[2][3] == "O")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                //Console.Clear();
                Console.WriteLine("Winner is O(Player 2)\n\n\tPress ESCAPE for Start New Game..");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.ResetColor();
                    map[0] = new string[4] { "/", "1", "2", "3" };
                    map[1] = new string[4] { "1", ".", ".", "." };
                    map[2] = new string[4] { "2", ".", ".", "." };
                    map[3] = new string[4] { "3", ".", ".", "." };
                    //ShowMap();
                }
            }
            if (map[3][1] == "O" && map[3][2] == "O" && map[3][3] == "O")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                //Console.Clear();
                Console.WriteLine("Winner is O(Player 2)\n\n\tPress ESCAPE for Start New Game..");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.ResetColor();
                    map[0] = new string[4] { "/", "1", "2", "3" };
                    map[1] = new string[4] { "1", ".", ".", "." };
                    map[2] = new string[4] { "2", ".", ".", "." };
                    map[3] = new string[4] { "3", ".", ".", "." };
                    //ShowMap();
                }
            }
            // Diagonals:
            if (map[1][1] == "O" && map[2][2] == "O" && map[3][3] == "O")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                //Console.Clear();
                Console.WriteLine("Winner is O(Player 2)\n\n\tPress ESCAPE for Start New Game..");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.ResetColor();
                    map[0] = new string[4] { "/", "1", "2", "3" };
                    map[1] = new string[4] { "1", ".", ".", "." };
                    map[2] = new string[4] { "2", ".", ".", "." };
                    map[3] = new string[4] { "3", ".", ".", "." };
                    //ShowMap();
                }
            }
            if (map[3][1] == "O" && map[2][2] == "O" && map[1][3] == "O")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                //Console.Clear();
                Console.WriteLine("Winner is O(Player 2)\n\n\tPress ESCAPE for Start New Game..");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.ResetColor();
                    map[0] = new string[4] { "/", "1", "2", "3" };
                    map[1] = new string[4] { "1", ".", ".", "." };
                    map[2] = new string[4] { "2", ".", ".", "." };
                    map[3] = new string[4] { "3", ".", ".", "." };
                    //ShowMap();
                }
            }
            // Columns:
            if (map[1][1] == "O" && map[2][1] == "O" && map[3][1] == "O")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                //Console.Clear();
                Console.WriteLine("Winner is O(Player 2)\n\n\tPress ESCAPE for Start New Game..");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.ResetColor();
                    map[0] = new string[4] { "/", "1", "2", "3" };
                    map[1] = new string[4] { "1", ".", ".", "." };
                    map[2] = new string[4] { "2", ".", ".", "." };
                    map[3] = new string[4] { "3", ".", ".", "." };
                    //ShowMap();
                }
            }
            if (map[1][2] == "O" && map[2][2] == "O" && map[3][2] == "O")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                //Console.Clear();
                Console.WriteLine("Winner is O(Player 2)\n\n\tPress ESCAPE for Start New Game..");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.ResetColor();
                    map[0] = new string[4] { "/", "1", "2", "3" };
                    map[1] = new string[4] { "1", ".", ".", "." };
                    map[2] = new string[4] { "2", ".", ".", "." };
                    map[3] = new string[4] { "3", ".", ".", "." };
                    //ShowMap();
                }
            }
            if (map[1][3] == "O" && map[2][3] == "O" && map[3][3] == "O")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                //Console.Clear();
                Console.WriteLine("Winner is O(Player 2)\n\n\tPress ESCAPE for Start New Game..");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.ResetColor();
                    map[0] = new string[4] { "/", "1", "2", "3" };
                    map[1] = new string[4] { "1", ".", ".", "." };
                    map[2] = new string[4] { "2", ".", ".", "." };
                    map[3] = new string[4] { "3", ".", ".", "." };
                    //ShowMap();
                }
            }
        }
    }
}
