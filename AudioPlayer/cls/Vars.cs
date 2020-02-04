using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{ 
    public static class Vars
    {
        //путь у испольняемому  файлу
        public static AudioPlayer Link;
        public static string AppPath = AppDomain.CurrentDomain.BaseDirectory;

        public static List<string> Files = new List<string>();

        //текущий номер трека
        public static int CurrentTrackNumber;

        
        public static string GetFileName(string file)
        {
            string[] tmp = file.Split('\\');
            return tmp[tmp.Length - 1];  
        }

        //public static void SetInputFormat()
        //{
        //    Link.openFileDialog1.Filter = "Bce форматы|*.mp3; *.m4a; *.mp4; *.ogg; *.opus; *.ac3; *.ape; *.mpc; *.flac; *.wma; *.tta; *.alac; *.wv;"
        //        + "|IPEG Audio Layer III (*.mp3)|*.mp3"
        //        + "|Advanced Audio Coding (*.m4a;*.mp4)|*.m4p;*.mp4" 
        //        + "|OGG Vorbis Audio (*.ogg)|*.ogg" 
        //        + "|OPUS Audio (*.opus)|*.opus"
        //        + "|Dolby Digital AC3 (*.ac3)|*.ac3"
        //        + "|IMonkey's Audio (*.ape)|*.ape" 
        //        + "|MusePack (*.mpc)|*.mpc"
        //        + "|Free Lossless Audio Codec (*.flac)|*.flac"
        //        + "|Windows Media Audio (*.wma)|*.wma"
        //        + "|ITrue Audio (*.tta)|*.tta"
        //        + "|Apple Lossless Audio Codec (*.alac)|*.alac"
        //        + "|WavPack(*.wv)|*.wv";
        //}
    }
}
