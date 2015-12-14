using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ShapeFactory : AbstractFactory
    {
        public override Shape getShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if(shapeType .Equals("CIRCLE",StringComparison.InvariantCultureIgnoreCase))
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

        public override Color getColor(string color)
        {
            return null;
        }
    }
}
