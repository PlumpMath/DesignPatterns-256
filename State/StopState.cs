using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class StopState
    {

        public void doAction(Context context)
        {
            Console.WriteLine("Player is in the stop state");
            context.setState(this);
        }

        public string ToString()
        {
            return "Stop State";
        }
    }
}
