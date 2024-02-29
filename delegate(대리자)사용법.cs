using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCs
{
	internal class Program
	{		
		public static void Move(int x, int y) 
		{
			Console.WriteLine("Move({0}, {1})", x, y); 
		}

		public static void Resize(int x, int y)
		{
			Console.WriteLine("Resize({0}, {1})", x, y); 
		}
		
		public delegate void Action(int x, int y);

		static void Main(string[] args)
		{
			Action action1 = new Action(Move); 
			Action action2 = new Action(Resize);

			action1(100, 200); 
			action2(300, 400);
		}
	}
}
