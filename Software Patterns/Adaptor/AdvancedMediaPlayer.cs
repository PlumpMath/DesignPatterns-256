using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor
{
    public interface AdvancedMediaPlayer
    {
        void playVlc(string filename);
        void playMp4(string filename);
    }
}
