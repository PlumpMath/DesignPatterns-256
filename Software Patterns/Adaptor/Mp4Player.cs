using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor
{
    class Mp4Player : AdvancedMediaPlayer
    {
        public void playVlc(string filename)
        {
            // Do nothign since this is a VLC player
            //Console.WriteLine("Playing VLC file. Name: " + filename);
        }
        public void playMp4(string filename)
        {
            Console.WriteLine("Playing MP4 file. Name: " + filename);
        }

    }
}
