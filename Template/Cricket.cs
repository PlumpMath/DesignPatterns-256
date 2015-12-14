using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Cricket : Game
    {
        
        public override void initialize()
        {
            Console.WriteLine("Cricket Game initialized, start playing.");
        }
        public override void startPlay()
        {
            Console.WriteLine("Cricket game started, enjoy the game");
        }
        public override void endPlay()
        {
            Console.WriteLine("Cricket Game Finished");
        }

    }
}
