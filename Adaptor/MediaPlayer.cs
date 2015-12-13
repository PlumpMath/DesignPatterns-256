using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor
{
    public interface MediaPlayer
    {
        void play(String audioType, String filename);
    }
}
