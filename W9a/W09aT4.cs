using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9a
{
	class W09aT4
	{
		
		public static void Main()
		{
			int[] Scores = new int[30];
			int Total = 0, Average = 0;
			Random rnd = new Random();
			for (int i = 0; i < 30; i++)
			{
				Scores[i] = rnd.Next(1, 101);
				Total += Scores[i];
			}
			Average = Total / 30;
			Console.WriteLine(Average);
			Console.ReadLine();
		}

		public void Add()
		{
			int[] Array1 = new int[] { 1, 2, 3 };
			int[] Array2 = new int[] { 1, 2, 3 };
			int[] Array3 = new int[Array1.Length];
			if (Array1.Length == Array2.Length)
			{
				for (int i = 0; i < Array1.Length; i++)
				{
					Array3[i] = Array1[i] + Array2[i];
				}
			}
		}
	}
}
