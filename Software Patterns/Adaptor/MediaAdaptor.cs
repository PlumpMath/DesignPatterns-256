using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor
{
    class MediaAdaptor : MediaPlayer
    {
        AdvancedMediaPlayer AdvancedMusicPlayer;

        public MediaAdaptor(string audioType)
        {
            if (audioType.Equals("vlc", StringComparison.InvariantCultureIgnoreCase))
            {
                AdvancedMusicPlayer = new VlcPlayer();
            }
            else if (audioType.Equals("mp4", StringComparison.InvariantCultureIgnoreCase))
            {
                AdvancedMusicPlayer = new Mp4Player();
            }
        }

        public void play(String audioType, String fileName)
        {
            if (audioType.Equals("vlc",StringComparison.InvariantCultureIgnoreCase))
            {
                AdvancedMusicPlayer.playVlc(fileName);
            }
            else if (audioType.Equals("mp4", StringComparison.InvariantCultureIgnoreCase))
            {
                AdvancedMusicPlayer.playMp4(fileName);
            }
        }
    }
}
