using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAMIN_WORK
{
    class SubwasurffGame
    {
        static int coin = 0;
            
        static int line = 0;
        static int emtiaz = 0;
        static bool BaziDarhaleEjraast = true;
        public static void Start()
        {
            Console.Clear();

            coin = 0;
            line = 0;
            emtiaz = 0;

            BaziDarhaleEjraast = true;
            Console.WriteLine("Bazi shoro shod!!!");
            while (BaziDarhaleEjraast)
            {
                ObjectComing(RandomNumber());
            }
        }
        /// <summary>
        /// این تابع عدد شانسی بینن 1 تا 3 رو برمیگرداند
        /// </summary>
        /// <returns></returns>
        static int RandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 5);

        }
        /// <summary>
        /// این تابع اشیاع را به بازی میاوردو حرکت بازی کن را چک میکند که درست باشد
        /// و امتیزا هم درصورت درست بودن اضافه میکند.
        /// </summary>
        /// <param name="objectnumber">ورودی شماره اشیاع هست. یک میشه سنگ دو میشه تابلو سه میشه قطار</param>
        static void ObjectComing(int objectnumber)
        {
            Console.Clear();
            ConsoleKey InputKey = ConsoleKey.U;

            if (objectnumber == 1)
            {
                Art.Sangbekesh();
                InputKey = Console.ReadKey().Key;
                if (InputKey == ConsoleKey.UpArrow)
                {
                    Pass();
                }
                else if (InputKey != ConsoleKey.UpArrow)
                {
                    Gameover();
                }
            }

            if (objectnumber == 2)
            {
                Art.Tabllobekesh();
                InputKey = Console.ReadKey().Key;
                if (InputKey == ConsoleKey.DownArrow)
                {
                    Pass();
                }
                else if (InputKey != ConsoleKey.DownArrow)
                {
                    Gameover();
                }
            }
            if (objectnumber == 3)
            {
                Art.Gatarbekesh();
  
                InputKey = Console.ReadKey().Key;
                if (InputKey == ConsoleKey.LeftArrow || InputKey == ConsoleKey.RightArrow)
                {
                    if (InputKey == ConsoleKey.LeftArrow)
                    {
                        line -= 1;
                    }
                    if (InputKey == ConsoleKey.RightArrow)
                    {
                         line += 1;
                    }
                       
                    if (line <= -2 || line >= 2)
                    {
                        Gameover();
                    }
                    Console.WriteLine(line);

                    Pass();
                }
                else if (InputKey != ConsoleKey.LeftArrow || InputKey != ConsoleKey.RightArrow)
                {
                    Gameover();
                }

            }
            if (objectnumber == 4)
            {
                Art.coin();
                InputKey = Console.ReadKey().Key;
                if (InputKey == ConsoleKey.Enter)
                {
                    coin += 1;
                    
                }
            }
        }
        /// <summary>
        /// بازی را تمام میکند. زمانی که بازی تمام میشود نیز این تابع خوانده میشود
        /// </summary>
        static void Gameover()
        {
            Console.Clear();
            Art.GameOverArt();
            Console.WriteLine("Emtiaz shoma : " + emtiaz);
            BaziDarhaleEjraast = false;
            Mediaplayer.LoseSound();
            Console.WriteLine("sekehay shoma :"+ coin);

            Save.SaveCon(emtiaz,coin) ;
            Console.WriteLine("Menu:1");
            Console.WriteLine("Restart:2");
            ConsoleKey exit;
            exit = Console.ReadKey().Key;
            if (exit == ConsoleKey.NumPad1)
            {
                Menu.shoro();
            }
            if (exit == ConsoleKey.NumPad2)
            {
                Start();
            }

        }
        /// <summary>
        /// زمانی که از یک شعی عبور میکنیم این تابع خوانده میشود. امتیاز اضافه میکند
        /// </summary>
        static void Pass()
        {
            emtiaz += 1;
            Console.WriteLine("rad shodi");

        }

    }
}
