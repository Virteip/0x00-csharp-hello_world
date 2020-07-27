using System;
using System.Collections.Generic;

class MyStack 
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
		bool found = aStack.Contains(search);
		
		Console.Write($"Number of items: {aStack.Count}\n");

		if(aStack.Count == 0){
			Console.WriteLine("Stack is empty");
		}else{
			Console.Write($"Top item: {aStack.Peek()}\nStack contains \"{search}\": {found}\n");
             if(found){
                 while(aStack.Pop() != search){
                     continue;
                 }
             }

		}

		aStack.Push(newItem);

		return (aStack);
    }
}
