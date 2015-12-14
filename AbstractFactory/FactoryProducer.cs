using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(string choice)
        {
            if (choice.Equals("SHAPE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new ShapeFactory();
            }
            else if (choice.Equals("COLOR", StringComparison.InvariantCultureIgnoreCase))
            {
                return new ColorFactory();
            }
            return null;
        }
    }
}
