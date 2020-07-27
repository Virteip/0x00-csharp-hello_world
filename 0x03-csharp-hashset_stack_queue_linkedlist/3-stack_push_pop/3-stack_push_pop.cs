using System;
using System.Collections.Generic;

class MyStack 
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
		bool found = aStack.Contains(search);

		if(aStack.Count != 0){
			Console.Write($"Number of items: {aStack.Count}\nTop item: {aStack.Peek()}\nStack contains \"{search}\": {found}\n");
			
			if(found){
				while(aStack.Pop() != search){
					continue;
				}
			}
		}else{
			Console.WriteLine("Stack is empty");
		}

		aStack.Push(newItem);

		return (aStack);
    }
}
