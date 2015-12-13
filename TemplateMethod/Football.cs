using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Football : Game
    {
        public override void initialize()
        {
            Console.WriteLine("Football Game initialized, start playing.");
        }
        public override void startPlay()
        {
            Console.WriteLine("Football game started, enjoy the game");
        }
        public override void endPlay()
        {
            Console.WriteLine("Football Game Finished");
        }
    }
}
