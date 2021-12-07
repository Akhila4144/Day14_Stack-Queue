using System;
using System.Collections.Generic;

namespace StackUC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------");        
            Console.WriteLine("The Peek Num is");
            stack.Peek();
            Console.WriteLine(stack.Pop());           
            Console.WriteLine("After pop the peek number the stack will be:");
            Console.WriteLine("--------");
            Console.WriteLine("The Peek Num is");
            stack.Peek();
            Console.WriteLine(stack.Pop());
            Console.WriteLine("After pop the peek number the stack will be:");
            Console.WriteLine("--------");
            Console.WriteLine("The Peek Num is");
            stack.Peek();
            Console.WriteLine(stack.Pop());
            Console.WriteLine("After pop the peek number the stack will be:");
            Console.WriteLine("Now The stack is Empty");



        }
    }
}
