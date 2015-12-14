using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}
