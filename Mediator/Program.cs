using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {

            User Robert = new User("Robert");
            User john = new User("John");

            Robert.sendMessage("Hello John");
            john.sendMessage("Hello to you too Robert");

        }
    }
}
