using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9a
{
	class Program
	{
		
		static void Mai2(string[] args)
		{
			int Size1 = 3, Size2 = 3;
			int[] Array1 = new int[] { 1, 2, 3 };
			int[] Array2 = new int[] { 1, 2, 3 };
			int[] Array3 = new int[] { };
			for (int i = 0; i < Size1; i++)
			{
				Array3[i] = Array1[i];
				Array3[i + Size1] = Array2[i];
			}
			

		}
	}
}
