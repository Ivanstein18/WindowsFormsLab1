using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;


namespace WindowsFormsLab1
{
    static class Sound
    {
        static SoundPlayer soundFail = new SoundPlayer(Properties.Resources.sound_fail);
        static SoundPlayer soundKey = new SoundPlayer(Properties.Resources.sound_key);
        static SoundPlayer soundStart = new SoundPlayer(Properties.Resources.sound_start);
        static SoundPlayer soundYouWin = new SoundPlayer(Properties.Resources.sound_youwin);
        static bool enableSound = true;


        public static void soundOn()
        {
            enableSound = true;
        }

        public static void soundOff()
        {
            enableSound = false;
        }


        public static void playFail()
        {
            if(enableSound)
            soundFail.Play();
        }
        public static void playKey()
        {
            if(enableSound)
            soundKey.Play();
        }
        public static void playStart()
        {
            if(enableSound)
            soundStart.Play();
        }
        public static void playYouWin()
        {
            if(enableSound)
            soundYouWin.Play();
        }


    }
}
