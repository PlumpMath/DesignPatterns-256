using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ShapeFactory
    {
        public Shape getShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if(shapeType.Equals("CIRCLE",StringComparison.InvariantCultureIgnoreCase))
            {
                return new Circle();
            }
            else if (shapeType.Equals("RECTANGLE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Rectangle();
            }
            else if (shapeType.Equals("SQUARE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Square();
            }
            return null;
        }
    }
}
