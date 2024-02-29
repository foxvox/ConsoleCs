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

			btn1.Click += new Button.ClickEvent(OnClick); 
			btn2.Click += new Button.ClickEvent(OnClick);

			btn1.MouseClick();
			btn2.MouseClick();				
		}
	}
}
