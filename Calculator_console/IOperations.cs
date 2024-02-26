using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Calculator_console
{
    internal abstract class IOperations
    {
        internal abstract void Add(byte operand);
        internal abstract void Subtract(byte operand);
    }
}
