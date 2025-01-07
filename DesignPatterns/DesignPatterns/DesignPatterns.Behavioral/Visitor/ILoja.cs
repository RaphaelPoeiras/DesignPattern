using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    public interface ILoja
    {
        void Visit(IVisitor visitor);
    }
}