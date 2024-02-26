using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Calculator_console
{
    /// <summary>
    /// Represents the interface for basic arithmetic operations.
    /// </summary>
    internal abstract class IOperations
    {
        /// <summary>
        /// Adds the specified operand to the current value.
        /// </summary>
        /// <param name="operand">The operand to add.</param>
        internal abstract void Add(byte operand);

        /// <summary>
        /// Subtracts the specified operand from the current value.
        /// </summary>
        /// <param name="operand">The operand to subtract.</param>
        internal abstract void Subtract(byte operand);
    }
}
