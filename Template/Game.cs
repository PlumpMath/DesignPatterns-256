using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public abstract class Game
    {
        public abstract void initialize();
        public abstract void startPlay();
        public abstract void endPlay();

        public void play()
        {
            initialize();
            startPlay();
            endPlay();
        }
    }
}
