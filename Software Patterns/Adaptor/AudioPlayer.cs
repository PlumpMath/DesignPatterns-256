using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor
{
    class AudioPlayer : MediaPlayer
    {
        MediaAdaptor mediaAdaptor;

        public void play(String audioType, string filename)
        {

            if(audioType.Equals("mp3",StringComparison.InvariantCultureIgnoreCase))
            {
                // Do mp3 function here
                Console.WriteLine("Playing MP3 file. Name: " + filename);
            }

            else if(audioType.Equals("vlc", StringComparison.InvariantCultureIgnoreCase) || audioType.Equals("mp4", StringComparison.InvariantCultureIgnoreCase))
            {
                mediaAdaptor = new MediaAdaptor(audioType);
                mediaAdaptor.play(audioType, filename);
            }
            else
            {
                Console.WriteLine("Error, " +  audioType + " media format not suported");
            }


        }

    }
}
