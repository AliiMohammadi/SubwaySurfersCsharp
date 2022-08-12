using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAMIN_WORK
{
    /// <summary>
    /// این کلاس کارهای نقاشی داخل کنسول را میکشد
    /// </summary>
    internal class Art
    {
        /// <summary>
        /// این تابع شکل گرافیکی سنگ را میکشد
        /// </summary>
        public static void Sangbekesh()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("       ████");
            Console.WriteLine("     ██   ████");
            Console.WriteLine("    ██        ███");
            Console.WriteLine("   ██           ███ ");
            Console.WriteLine("   ███████████████");
            Console.ForegroundColor = ConsoleColor.White;
        }
        /// <summary>
        /// کشیدن شکل تابلو
        /// </summary>
        public static void Tabllobekesh()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("███████████████████");
            Console.WriteLine("█----WARNING-----██");
            Console.WriteLine("█                ██");
            Console.WriteLine("███████████████████");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("█                ██");
            Console.WriteLine("█                ██");
            Console.WriteLine("█                ██");
        }
        /// <summary>
        /// کشیدن شکل قطار
        /// </summary>
        public static void Gatarbekesh()
        {
            Console.WriteLine("              ███    ");
            Console.WriteLine("█████████████████████");
            Console.WriteLine("█         ███    ██ █");
            Console.WriteLine("█         ███    ███ ");
            Console.WriteLine("███████████████████ █");
            Console.WriteLine("███████████████████ █");
            Console.WriteLine("███████████████████ █");
            Console.WriteLine("██  ██████████  ████ ");
        }
        /// <summary>
        /// کشیدن نوشته گیم اور
        /// </summary>
        public static void GameOverArt()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("    ████        ███           ███         ███        ");
            Console.WriteLine("  ██   ██      ██ ██         ██ ██       ██ ██     ██████████     ");
            Console.WriteLine("  ██          ██▄▄▄██       ██   ██     ██   ██    ██   ");
            Console.WriteLine("  ██   ███   █████████     ██     ██   ██     ██   █████████    ");
            Console.WriteLine("  ██    ██  ██       ██   ██       ██ ██       ██  ██     ");
            Console.WriteLine("    ████   ██         ██ ██         ███         ██ ██████████            ");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("    ████   ██         ██               ██████                                 ");
            Console.WriteLine("  ██    ██  ██       ██  ██████████  ██      ██                                        ");
            Console.WriteLine("  ██    ██   ██     ██   ██          ██     ██                                            ");
            Console.WriteLine("  ██    ██    ██   ██    █████████   ████████                                           ");
            Console.WriteLine("  ██    ██     ██ ██     ██          ██     ██                              ");
            Console.WriteLine("    ████        ███      ██████████  ██      ██                                         ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void coin()
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("       ████████                               ");
            Console.WriteLine("    ███        ███                           ");
            Console.WriteLine("   ███       █  ███                            ");
            Console.WriteLine("   ███   ██      ███                         ");
            Console.WriteLine("   ███    █      ███                         ");
            Console.WriteLine("   ███    █      ███                         ");
            Console.WriteLine("   ███   ███     ███                         ");
            Console.WriteLine("    ███        ███                           ");
            Console.WriteLine("      █████████                                  ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    
}
