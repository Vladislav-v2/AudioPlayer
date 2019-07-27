using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass;

namespace AudioPlayer
{
    public static  class BassLike
    {
        //частота дискретизації
        public static int HZ = 44100;
        //состояние инициализации
        public static bool InitDefoultDevice;
        //Канал
        public static int Stream;
        //Громкость
        public static int Volume = 20;

        //воспроизвидение прервано руками
        private static bool isStoped = true;

        //прелист польностью проигран
        public static bool EndPlayList;

        //список плагинов
        public static readonly List<int> BassPluginsHandles = new List<int>();

        //зацикливание трека
        public static int loop;
        //метод инициалтизации
        public static bool InitBasss(int hz)
        {
            if (!InitDefoultDevice)
            {
                InitDefoultDevice = Bass.BASS_Init(-1, hz, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
                if(InitDefoultDevice)
                {
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bass_aac.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bass_ac3.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bass_ape.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bass_mpc.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bass_tta.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bassalac.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bassflac.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\bassopus.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\basswma.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Vars.AppPath + @"plugins\basswv.dll"));

                    int ErrorCount = 0;
                    for (int i = 0; i < BassPluginsHandles.Count; i++)
                        if (BassPluginsHandles[i] == 0)
                            ErrorCount++;
                    if (ErrorCount != 0)
                        MessageBox.Show(ErrorCount + " плагинa не было загружено","Oшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorCount = 0;
                }
            }

            return InitDefoultDevice;
        }

        public static void loop_channel(int flag) //установить / снять зацикление
        {
            if (flag == 4)
            {
                loop = 4;
                Bass.BASS_ChannelFlags(Stream, BASSFlag.BASS_SAMPLE_LOOP, BASSFlag.BASS_SAMPLE_LOOP);
            }
            if (flag == 0)
            {
                loop = 0;
                Bass.BASS_ChannelFlags(Stream, 0, BASSFlag.BASS_SAMPLE_LOOP);
            }
        }

        public static void Play(string fileName, int vol)
        {
            if (Bass.BASS_ChannelIsActive(Stream) != BASSActive.BASS_ACTIVE_PAUSED)
            {
                Stop();
                if (InitBasss(HZ))
                {

                    Stream = Bass.BASS_StreamCreateFile(fileName, 0, 0, (BASSFlag)loop);
                    if (Stream != 0)
                    {
                        Volume = vol;
                        Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
                        Bass.BASS_ChannelPlay(Stream, false);
                    }
                }
            }
            else
            Bass.BASS_ChannelPlay(Stream, false);
            isStoped = false;
        }

        public static void Stop()
        {
            Bass.BASS_ChannelStop(Stream);
            Bass.BASS_StreamFree(Stream);
            isStoped = true;
        }

        public static void Pause()
        {
            if (Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_PLAYING)
                Bass.BASS_ChannelPause(Stream);
        }

        //получение длительности канала в секундах
        public static int GetTimeOfStream(int stream)
        {
            long TimeBytes = Bass.BASS_ChannelGetLength(stream);
            double Time = Bass.BASS_ChannelBytes2Seconds(stream, TimeBytes);
            return (int)Time;
        }
        //получение текущей позиции в секундах
        public static int GetPosOfStream(int stream)
        {
            long pos = Bass.BASS_ChannelGetPosition(stream);
            double posSec = Bass.BASS_ChannelBytes2Seconds(stream, pos);
            return (int)posSec;
        }
        //изминения позиции продолжительности исполняемого трека
        public static void SetPosOfScroll(int stream, int pos)
        {
            Bass.BASS_ChannelSetPosition(stream,(double)pos);
        }
        //изминения громкости треков
        public static void SetVolumeStream(int stream, int vol)
        {
            Volume = vol;
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
        }
        //следующтй трек после окончания играющего
        public static bool ToNextTrack()
        {
            if((Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_STOPPED) && (!isStoped))
            {
                if (Vars.Files.Count > Vars.CurrentTrackNumber + 1)
                {
                    Play(Vars.Files[++Vars.CurrentTrackNumber], Volume);
                    EndPlayList = false;
                    return true;
                }
                else EndPlayList = true;
            }
            return false;
        }
        //клик по кнопке "следующий трек"
        public static bool NextTrack() 
        {
            if (Vars.Files.Count > Vars.CurrentTrackNumber + 1)
            {
                Stop();
                Play(Vars.Files[++Vars.CurrentTrackNumber], Volume);
                EndPlayList = false;
                return true;
            }
            else
            {
                EndPlayList = true;
                return false;
            }
        }
        //клик по кнопке "предыдущий трек"
        public static void PreviousTrack()
        {
            if (Vars.CurrentTrackNumber != 0)
            {
                Stop();
                Play(Vars.Files[--Vars.CurrentTrackNumber], Volume);
            }
            else
            {
                Play(Vars.Files[Vars.CurrentTrackNumber], Volume);
            }
        }

    }
}