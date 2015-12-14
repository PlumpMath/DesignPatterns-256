using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public interface ComputerPartVisitor
    {
        void visit(Computer computer);
        void visit(Mouse mouse);
        void visit(Keyboard keyboard);
        void visit(Monitor monitor);
    }
}
