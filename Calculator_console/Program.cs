using System.Numerics;
using Calculator_console.Memory;



namespace Calculator_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            byte operand, memoryIndex;
            char operation, choice;
            Calculator calculator = new();

            while (!exit)
            {
                Console.WriteLine("\nTo do calculation - 1, To do calculation on memory - 2, To exit - 0: ");
                choice = Console.ReadKey().KeyChar;
                switch (choice)
                {
                    case '0': exit = true; break;
                    case '1':
                        Console.WriteLine("\nClear the result? Yes - 1, No - 2: ");
                        choice = Console.ReadKey().KeyChar;
                        if(choice == '1')
                            calculator.ClearResult();

                        Console.WriteLine("\nEnter the number: ");
                        operand = byte.Parse(Console.ReadLine());

                        Console.WriteLine("\nTo add - 1, To subtract - 2: ");
                        operation = Console.ReadKey().KeyChar;

                        Console.WriteLine("\nSave the result to memory? Yes - 1, No - 2");
                        choice = Console.ReadKey().KeyChar;

                        if (operation == '1')
                            calculator.Add(operand);
                        else if (operation == '2')
                            calculator.Subtract(operand);
                        else
                            Console.WriteLine("\nInvalid operand or operator!");

                        calculator.Calculate(choice == '1');
                        calculator.ShowMemory();
                        break;

                    case '2':
                        Console.WriteLine("\nTo add - 1, To subtract - 2, To remove from memory - 3, To clear memory - 4: ");
                        choice = Console.ReadKey().KeyChar;

                        if (choice == '1' || choice == '2' || choice == '3')
                        {
                            Console.WriteLine("\nEnter memory index: ");
                            memoryIndex = byte.Parse(Console.ReadLine());

                            if (choice == '1' || choice == '2')
                            {
                                Console.WriteLine("\nEnter the number: ");
                                operand = byte.Parse(Console.ReadLine());
                                calculator.UpdateMemory(memoryIndex, choice, operand);
                                break;
                            }
                            calculator.UpdateMemory(memoryIndex, choice, null);
                            break;
                        }
                        calculator.UpdateMemory(null, choice, null);
                        calculator.ShowMemory();
                        break;

                    default: Console.WriteLine("Invalid."); exit = true; break;
                }
            }

        }
    }
}