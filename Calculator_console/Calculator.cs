using Calculator_console.Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_console
{
    /// <summary>
    /// Represents a simple calculator with memory functionality.
    /// </summary>
    internal class Calculator : Abstract_Calculator
    {
        /// <summary>
        /// The memory list associated with the calculator.
        /// </summary>
        private MemoryList memory;

        /// <summary>
        /// The operand used in arithmetic operations.
        /// </summary>
        private byte operand;

        /// <summary>
        /// A flag indicating whether the current operation is addition.
        /// </summary>
        private bool isAdd;

        /// <summary>
        /// Initializes a new instance of the <see cref="Calculator"/> class with default memory and operand values.
        /// </summary>
        internal Calculator()
        {
            this.memory = new MemoryList();
            this.operand = 0;
        }

        /// <inheritdoc/>
        internal override void Add(byte operand)
        {
            this.operand = operand;
            this.isAdd = true;
        }

        
        /// <inheritdoc/>
        internal override void Subtract(byte operand)
        {
            this.operand = operand;
            this.isAdd = false;
        }

        /// <summary>
        /// Performs the calculation based on the current operation (addition or subtraction) and operand.
        /// </summary>
        /// <param name="isAddToMemory">Specifies whether to save the result to memory after calculation</param>
        internal void Calculate(bool isAddToMemory)
        {
            if (isAdd)
                Result += operand;
            else
                Result -= operand;
            if (isAddToMemory)
                memory.SaveToMemory(Result);
            Console.WriteLine($"\nResult: {Result}");
        }

        /// <summary>
        /// Displays the current memory contents.
        /// </summary>
        internal void ShowMemory()
        {
            memory.ShowMemoryList();
        }

        /// <summary>
        /// Updates the memory item at the specified index based on the given choice and operand.
        /// </summary>
        /// <param name="index">The index of the memory item to update.</param>
        /// <param name="choice">The choice of operation (1: add, 2: subtract, 3: remove, 4: clear).</param>
        /// <param name="operand">The operand to use in the operation.</param>
        internal void UpdateMemory(byte? index, char choice, byte? operand)
        {
            if (index.HasValue)
            {
                switch (choice)
                {
                    case '1':
                        if (operand.HasValue)
                            memory.Memory[index.Value].Add(operand.Value); break;
                    case '2':
                        if (operand.HasValue)
                            memory.Memory[index.Value].Subtract(operand.Value); break;
                    case '3':
                        memory.RemoveFromMemory(index.Value); break;
                    case '4':
                        memory.ClearMemory(); break;
                    default:
                        Console.WriteLine("Invalid index, operand or choice."); break;
                }
            }
        }
    }
}
