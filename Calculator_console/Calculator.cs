using Calculator_console.Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_console
{
    internal class Calculator : Abstract_Calculator
    {
        private MemoryList memory;
        private byte operand;
        private bool isAdd;

        internal Calculator()
        {
            this.memory = new MemoryList();
            this.operand = 0;
        }

        internal override void Add(byte operand)
        {
            this.operand = operand;
            this.isAdd = true;
        }

        internal override void Subtract(byte operand)
        {
            this.operand = operand;
            this.isAdd = false;
        }

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

        internal void ShowMemory()
        {
            memory.ShowMemoryList();
        }

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
