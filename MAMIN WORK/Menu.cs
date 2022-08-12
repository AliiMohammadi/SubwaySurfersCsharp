using System;

namespace MAMIN_WORK
{
    internal class Menu
    {
        public static string UserName = "User";

        static int s = 70;
        static int f = 1000;
        static int Index = 0;


        public static void shoro()
        {
            
            MenuAsli();
        }
        static void MenuAsli()
        {

            ChapDokmeha();


            ConsoleKey inpute = InputBegir();
            if (inpute == ConsoleKey.DownArrow)
            {
                Console.Beep(f,s);
                Index ++;
                
                if (Index >= 4)
                {
                    Index = 0;
                }

                shoro();
            }
            if (inpute == ConsoleKey.UpArrow)
            {
                Console.Beep(f, s);
                Index --;
                if (Index < 0)
                {
                    Index = 3;
                }

                shoro();



            }
            if (inpute == ConsoleKey.Enter)
            {
                Console.Beep(f+500, s);
                if (Index == 0)
                SubwasurffGame.Start();
                if (Index == 1)
                    Environment.Exit(0);
                if (Index == 2)
                    PanelScoreHa();
                if (Index == 3)
                    ChangeUserPanel();
            }
        }
        static void ChapDokmeha()
        {
            Console.Clear();

            Console.WriteLine("User: " + UserName);
            Console.WriteLine();

            if (Index == 0)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Shoro");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Beron");
                Console.WriteLine("emtiaz ha & coins ");
                Console.WriteLine("User");


            }
            if (Index == 1)
            {
                Console.WriteLine("Shoro");

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Beron");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("emtiaz ha & coins ");
                Console.WriteLine("User");

            }
            if (Index == 2)
            {
                Console.WriteLine("Shoro");

                Console.WriteLine("Beron");

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("emtiaz ha & coins ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("User");

            }
            if (Index == 3)
            {
                Console.WriteLine("Shoro");

                Console.WriteLine("Beron");
                Console.WriteLine("emtiaz ha & coins ");

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("User");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        static void PanelScoreHa()
        {
            Console.Clear();
            Console.WriteLine(Save.ReadFile());
            Console.WriteLine("Menu : 4");

            if (InputBegir() == ConsoleKey.NumPad4)
            {
                shoro();
            }
        }
        static ConsoleKey InputBegir()
        {
            return Console.ReadKey().Key;
        }
        static void ChangeUserPanel()
        {
            Console.Clear();
            Console.WriteLine("Enter the new user name:");
            UserName = Console.ReadLine();
            shoro();
        }
    }
}
