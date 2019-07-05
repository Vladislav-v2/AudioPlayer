using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass.AddOn.Tags;

namespace AudioPlayer
{
    public class TagModel
    {
        public int BitRate;
        public int Freq;
        public string Channels;
        public string Artist;
        public string Album;
        public string Title;
        public string Year;
        public TimeSpan Length;

        Dictionary<int, string> ChannelsDist = new Dictionary<int, string>()
        {
            {0,"Null"},
            {1,"Mono"},
            {2,"Stereo"}
        };

        public TagModel (string file)
        {
            TAG_INFO tagInfo = new TAG_INFO();
            tagInfo = BassTags.BASS_TAG_GetFromFile(file);
            BitRate = tagInfo.bitrate;
            Freq = tagInfo.channelinfo.freq;
            Channels = ChannelsDist[tagInfo.channelinfo.chans];
            Artist = tagInfo.artist;
            Album = tagInfo.album;
            if (tagInfo.title == "")
                Title = Vars.GetFileName(file);
            else Title = tagInfo.title;
            Year = tagInfo.year;
        }
    }
}
