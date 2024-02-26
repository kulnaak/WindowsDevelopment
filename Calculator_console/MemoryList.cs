using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_console.Memory
{
    internal class MemoryList : MemoryItem
    {
        internal List<MemoryItem> Memory = [];

        internal void SaveToMemory(byte value)
        {
            MemoryItem item = new(value);
            Memory.Add(item);
        }

        internal void ChangeValueAtIndex(byte index, byte value)
        {
            if (index >= 0 && index < Memory.Count)
                Memory[index].MemoryStore = value;
            else
                Console.WriteLine("Index out of range.");
        }
        internal void RemoveFromMemory(byte index)
        {
            if (index >= 0 && index < Memory.Count)
                Memory.RemoveAt(index);
            else
                Console.WriteLine("Index out of range.");
        }

        internal void ClearMemory() 
        { 
            Memory.Clear(); 
        }

        internal void ShowMemoryList()
        {
            if(Memory.Count == 0)
            {
                Console.WriteLine("Memory is empty.");
                    return;
            }
            Console.WriteLine("\nMemory:\nIndex:\tValue:");
            byte i = 0;
            foreach (MemoryItem item in Memory)
            {
                Console.WriteLine($"{i}\t{item.MemoryStore}");
                i++;
            }

        }
    }
}
