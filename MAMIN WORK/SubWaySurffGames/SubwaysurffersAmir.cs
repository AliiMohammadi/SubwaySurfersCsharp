using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAMIN_WORK
{
    internal class SubwaysurffersAmir
    {
        static int Score = 0;
        public static void Start()
        {
            Console.WriteLine("Game started!");
            Random rand = new Random();
            int RandomNumb = 0;

            while (true)
            {
                
                RandomNumb = rand.Next(0,4);
                switch (RandomNumb)
                {
                    case 1:
                        Console.WriteLine("Sang");
                        if (GetInputKey() != ConsoleKey.UpArrow)
                        {
                            GameOver();
                            break;
                        }
                        else
                        {
                            PassedTheObject();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Tablo");
                        if (GetInputKey() != ConsoleKey.DownArrow)
                        {
                            GameOver();
                            break;
                        }
                        else
                        {
                            PassedTheObject();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Qatar");
                        ConsoleKey key = GetInputKey();
                        if (key == ConsoleKey.LeftArrow || key == ConsoleKey.RightArrow)
                        {
                            PassedTheObject();
                        }
                        else 
                        {
                            GameOver();
                            break;
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        static ConsoleKey GetInputKey()
        {
            return Console.ReadKey().Key;
        }
        static void GameOver()
        {
            Console.Clear();
            Console.WriteLine("GAME OVER!");
            Console.WriteLine("Score: " + Score);
        }
        static void PassedTheObject()
        {
            Console.WriteLine("Passed.");
            Score++;
        }
    }
}
