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
			Dictionary<string, int> dic = new Dictionary<string, int>();

			dic.Add("일", 1);
			dic.Add("이", 2);
			dic.Add("삼", 3);
			dic.Add("윤은서", 1004); 

			Console.WriteLine(dic["삼"]);		// key를 넣어주면 value가 출력된다. 

			if (dic.ContainsKey("윤은서"))
			{
				Console.WriteLine("윤은서 key가 존재합니다.");
				Console.WriteLine("윤은서 key의 value는: " + dic["윤은서"]); 
			}
		}
	}
}
