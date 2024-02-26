using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_console.Memory
{
    /// <summary>
    /// Represents an item stored in memory, providing basic arithmetic operations.
    /// </summary>
    internal class MemoryItem : IOperations
    {
        /// <summary>
        /// The value stored in memory.
        /// </summary>
        protected byte memoryStore;

        /// <summary>
        /// Gets or sets the value stored in memory.
        /// </summary>
        internal byte MemoryStore
        {
            get { return memoryStore; } 
            set { memoryStore = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryItem"/> class with the default memory value set to zero.
        /// </summary>
        internal MemoryItem() 
        {
            MemoryStore = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryItem"/> class with the specified memory value.
        /// </summary>
        /// <param name="value">The value to store in memory.</param>
        internal MemoryItem(byte value)
        {
            MemoryStore = value;
        }

        /// <inheritdoc/>
        internal override void Add(byte operand)
        {
            this.memoryStore += operand;
        }

        /// <inheritdoc/>
        internal override void Subtract(byte operand)
        {
            this.memoryStore -= operand;
        }
    }
}
