using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ColorFactory : AbstractFactory
    {
        public override Shape getShape(string shapeType)
        {
            return null;
        }

        public override Color getColor(string color)
        {
            if (color == null)
            {
                return null;
            }
            if (color.Equals("RED",StringComparison.InvariantCultureIgnoreCase))
            {
                return new Red();
            }
            else if (color.Equals("GREEN", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Green();
            }
            else if (color.Equals("BLUE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Blue();
            }

            return null;
        }
    }
}
