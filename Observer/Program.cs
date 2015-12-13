using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            new HexObserver(subject);
            new OctalObserver(subject);
            new BinaryObserver(subject);

            Console.WriteLine("First state change: 15");
            subject.setState(15);
            Console.WriteLine("Second state change: 18");
            subject.setState(18);

            Console.ReadLine();
        }
    }
}
