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
		public class ObjList
		{
			protected ArrayList data; 
			
			public ObjList() 
			{
				data = new ArrayList();
			}

			public object this[int i]
			{
				get
				{
					if (i >= 0 && i < data.Count)
					{
						return data[i];
					}
					else
					{
						throw new IndexOutOfRangeException("범위 벗어남" + i); 
					}
				}

				set 
				{
					if (i >= 0 && i < data.Count)
					{
						data[i] = value; 
					}
					else if (i == data.Count)
					{
						data.Add(value);
					}
					else
					{
						throw new IndexOutOfRangeException("범위벗어남" + i); 
					}
				}
			}
		}

		static void Main(string[] args)
		{
			ObjList list = new ObjList();

			list[0] = 100;
			list[1] = "apple";
			list[2] = 123.456; 

			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine("[{0}] = {1}", i, list[i]); 
			}	
		}
	}
}
