using System;
namespace _11_배열._03_다차원배열
{
	class _04_다차원_배열
	{
		private static void Main() { new _04_다차원_배열().Entry(); }

		private void Entry()
		{
			int[,] arr = new int[4, 5];

			int count = 0;

			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					arr[i, j] = ++count;
				}
			}

			// 출력
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					Console.Write((arr[i, j] < 10 ? " " : "") + arr[i, j] + " ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			// 뒤에서부터 출력

			for (int i = arr.GetLength(0) - 1; i >= 0; --i)
			{
				for (int j = arr.GetLength(1) - 1; j >= 0; --j)
				{
					Console.Write((arr[i, j] < 10 ? " " : "") + arr[i, j] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
