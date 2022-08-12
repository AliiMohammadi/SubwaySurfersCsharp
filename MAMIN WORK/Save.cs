using System;
using System.IO;

namespace MAMIN_WORK
{
    internal class Save
    {
        static string saveAdres = @"D:\\Save file.txt";


        public static void SaveCon(int emtya , int Coins)
        {
            File.AppendAllText(saveAdres,"User: " + Menu.UserName + ". Emtiyaz: " + emtya.ToString() + "  Coins:" + Coins.ToString() + "\n");
        }    
        public static void PakCon()
        {
            File.Delete(saveAdres); 
        }
        public static string ReadFile()
        {
            return File.ReadAllText(saveAdres);
             ;
        }
    }
   
    
}
