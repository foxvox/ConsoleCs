using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*Dictionary<string, List<int>> listDic = new Dictionary<string, List<int>>();	

			List<Dictionary<string, int>> dicList = new List<Dictionary<string, int>>(); */

			Dictionary<string, int> dic = new Dictionary<string, int>();

			dic.Add("일", 1);
			dic.Add("이", 2);
			dic.Add("삼", 3); 
			dic.Add("사", 4);
			dic.Add("오", 5);
			dic.Add("윤은서", 1004); 

			List<int> LTest = new List<int>();

			LTest.Add(1);
			LTest.Add(2);	
			LTest.Add(3);
			LTest.Add(4);
			LTest.Add(5);

			LinkedList<int> LLTest = new LinkedList<int>();

			LLTest.AddLast(11);
			LLTest.AddLast(22);	
			LLTest.AddLast(33);
			LLTest.AddLast(44);
			LLTest.AddLast(55);

			Console.WriteLine("\n이것은 List 출력");
			foreach (var i in LTest) 
			{				
				Console.WriteLine(i); 
			}

			Console.WriteLine("\n이것은 Linked List 출력");
			foreach (var i in LLTest)
			{				
				Console.WriteLine(i);
			}

			Console.WriteLine("\n이것은 Dictionary 출력");
			foreach (var i in dic)
			{				
				Console.WriteLine(i);
				Console.WriteLine("Key: " + i.Key);
				Console.WriteLine("Value: " + i.Value);
			}
			Console.WriteLine(); 
		}
	}
}
