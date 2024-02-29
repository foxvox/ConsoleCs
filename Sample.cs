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
			string myInput;
			int myInt;
		main:
			Console.Write("1: 사과, 2: 포도, 3: 수박\t");
			Console.Write("하나의 숫자를 선택하세요! ");
			myInput = Console.ReadLine();
			myInt = Int32.Parse(myInput);

			switch (myInt)
			{
				case 1:
					Console.Write("당신은 1번을 선택하셨습니다.");
					break; 
				case 2:
					Console.WriteLine("당신은 2번을 선택하셨습니다.");
					break; 
				case 3:
					Console.WriteLine("당신은 3번을 선택하셨습니다.");
					break; 
				default:
					Console.WriteLine("1번과 3번 사이를 고르셔야 합니다."); 
					break; 
			}

		question:
			Console.Write("계속하시려면 계속 끝내시려면 끝내기라고 쓰세요: ");
			myInput = Console.ReadLine(); 

			switch (myInput)
			{
				case "계속":
					goto main;
				case "끝내기":
					Console.WriteLine("좋은 하루 되세요.");
					break;
				default:
					Console.WriteLine("{0}은 정확한 입력이 아닙니다.", myInput);
					goto question; 
			}

		}
	}
}
