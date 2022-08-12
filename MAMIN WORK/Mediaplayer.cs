using System;
using System.Media;
namespace MAMIN_WORK
{
    internal class Mediaplayer
    {
        public static void LoseSound()
        {
            string add = "";
            Random ran = new Random();
            int random = ran.Next(1,4);
            switch (random)
            {
                case 1:
                    add = "cok1_4.wav";
                    break;
                case 2:
                    add = "cok1_6.wav";
                    break;
                case 3:
                    add = "cok4_16.wav";
                    break;

                default:
                    break;
            }
            SoundPlayer sound = new SoundPlayer(@"D:\\"+add);
            //sound.Play();
        }
    }
}
