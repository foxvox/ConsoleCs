using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCs
{
	internal class Program
	{
		class Button
		{
			public string name; 

			public Button(string name)
			{
				this.name = name;
			}

			public delegate void ClickEvent(object sender, EventArgs e);

			public event ClickEvent Click; 

			public void MouseClick()
			{
				if (Click != null) 
				{
					// Click 이벤트 호출 
					EventArgs e = new EventArgs();	
					Click(this, e);
				}
			}
		}

		public static void OnClick(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			Console.WriteLine("[{0}] 버튼 클릭!", btn.name); 
		}
		

		static void Main(string[] args)
		{
			Button btn1 = new Button("빌드");
			Button btn2 = new Button("실행");


			// 델리깃 + 연산은 이벤트와 이벤트 핸들러를 연결합니다. 
			btn1.Click += new Button.ClickEvent(OnClick); 
			btn2.Click += new Button.ClickEvent(OnClick);

			// 이벤트 발생
			btn1.MouseClick();
			btn2.MouseClick();				
		}
	}
}
