using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_console.Memory
{
    /// <summary>
    /// Represents a list of memory items with operations to manipulate the memory.
    /// </summary>
    internal class MemoryList : MemoryItem
    {
        /// <summary>
        /// The list of memory items.
        /// </summary>
        internal List<MemoryItem> Memory = [];

        /// <summary>
        /// Saves a new value to memory.
        /// </summary>
        /// <param name="value">The value to save in memory.</param>
        internal void SaveToMemory(byte value)
        {
            MemoryItem item = new(value);
            Memory.Add(item);
        }

        /// <summary>
        /// Changes the value at the specified index in memory.
        /// </summary>
        /// <param name="index">The index of the memory item to change.</param>
        /// <param name="value">The new value to set at the specified index.</param>
        internal void ChangeValueAtIndex(byte index, byte value)
        {
            if (index >= 0 && index < Memory.Count)
                Memory[index].MemoryStore = value;
            else
                Console.WriteLine("Index out of range.");
        }

        /// <summary>
        /// Removes the memory item at the specified index.
        /// </summary>
        /// <param name="index">The index of the memory item to remove</param>
        internal void RemoveFromMemory(byte index)
        {
            if (index >= 0 && index < Memory.Count)
                Memory.RemoveAt(index);
            else
                Console.WriteLine("Index out of range.");
        }

        /// <summary>
        /// Clears all memory items.
        /// </summary>
        internal void ClearMemory() 
        { 
            Memory.Clear(); 
        }

        /// <summary>
        /// Displays the list of memory items along with their indexes and values.
        /// </summary>
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
