using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_console.Memory
{
    internal class MemoryItem : IOperations
    {
        protected byte memoryStore;

        internal byte MemoryStore
        {
            get { return memoryStore; } 
            set { memoryStore = value; }
        }
        internal MemoryItem() 
        {
            MemoryStore = 0;
        }   
        internal MemoryItem(byte value)
        {
            MemoryStore = value;
        }

        internal override void Add(byte operand)
        {
            this.memoryStore += operand;
        }

        internal override void Subtract(byte operand)
        {
            this.memoryStore -= operand;
        }
    }
}
