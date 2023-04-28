﻿using System.Reflection.Metadata.Ecma335;

namespace GenericsExercise
{
    class MyStack<S>
    {
        S[] stackArray;
        int top;

        public MyStack()
        {
            stackArray = new S[10];
            top = -1;//initialise top
        }
        public void Push(S item)
        {
            if (top == stackArray.Length-1)
            {
                Console.WriteLine("OverFlow");
            }
            else
            {
                top = top + 1; //insert element
                stackArray[top] = item;
            }
        }
        public S Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("UnderFlow");
            }
            S item = stackArray[top];
            top--;
            return item;
        }
        public S Top
        {
            get
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack is empty");
                }
                return stackArray[top];
            }
        }
        public int Count
        {
            get { return top + 1; } 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Count: " + stack.Count);

            
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            stack.Push(5);

            Console.WriteLine("Top of the stack is: " + stack.Top);
            Console.WriteLine("Count: " + stack.Count);

        }
    }    
}