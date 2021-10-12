using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_배열._04_가변배열
{
	class _01_가변배열
	{
		private static void Main() { new _01_가변배열().Entry(); }
		private void Entry()
		{
			// 가변배열 선언
			int[][] arr = new int[3][];
			int count = 0;
			int newLength = 2;
			for (int i = 0; i < arr.GetLongLength(0); ++i)
			{
				arr[i] = new int[newLength++];

				// 할당한 배열의 요소에 값을 할당합니다.
				for (int j = 0; j < arr[i].GetLongLength(0); j++)
				{
					arr[i][j] = ++count;
				}
			}
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr[i].GetLength(0); ++j)
				{
					Console.Write(arr[i][j] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
