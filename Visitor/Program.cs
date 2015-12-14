using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerPart computer = new Computer();
            computer.accept(new ComputerPartDisplayVisitor());
            Console.ReadLine();
        }
    }
}
