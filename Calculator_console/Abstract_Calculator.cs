using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_console
{
    /// <summary>
    /// Represents an abstract calculator providing basic arithmetic operations.
    /// </summary>
    internal abstract class Abstract_Calculator : IOperations
    {
        /// <summary>
        /// The current result of calculations.
        /// </summary>
        protected byte result;

        /// <summary>
        /// Initializes a new instance of the <see cref="Abstract_Calculator"/> class with the default result set to zero.
        /// </summary>
        internal Abstract_Calculator()
        {
            Result = 0;
        }

        /// <summary>
        /// Gets or sets the current result of calculations.
        /// </summary>
        protected byte Result
        {
            get { return result; }
            set { result = value; }
        }

        /// <summary>
        /// Clears the current result, resetting it to zero.
        /// </summary>
        internal void ClearResult()
        {
            Result = 0;
        }
    }
}
