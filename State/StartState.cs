using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class StartState : State
    {
        public void doAction(Context context)
        {
            Console.WriteLine("Player is in the start state");
            context.setState(this);
        }

        public string ToString()
        {
            return "Start State";
        }

    }
}
