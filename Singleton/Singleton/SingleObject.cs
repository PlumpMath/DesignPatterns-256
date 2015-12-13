using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SingleObject
    {
        private static SingleObject instance = new SingleObject();

        private SingleObject() { }

        public static SingleObject getInstance()
        {
            return instance;
        }

        public void showMessage()
        {
            Console.WriteLine("Hello World from this instance");
        }
    }
}
