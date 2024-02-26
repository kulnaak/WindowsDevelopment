using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_console
{
    internal abstract class Abstract_Calculator : IOperations
    {
        protected byte result;
        internal Abstract_Calculator()
        {
            Result = 0;
        }

        protected byte Result
        {
            get { return result; }
            set { result = value; }
        }

        internal void ClearResult()
        {
            Result = 0;
        }
    }
}
