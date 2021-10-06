using System;

class _02_다차원배열_강사님_답_
{
	private void PrintArr(int[,] arr)
	{
		for (int i = 0; i < arr.GetLength(0); i++)
		{
			for (int j = 0; j < arr.GetLength(1); j++)
			{
				int elemVal = arr[i, j];
				Console.Write("[ " + (elemVal < 10 ? " " : "") + elemVal + " ] ");
			}
			Console.WriteLine();
		}
	}

	private static void Main() { new _02_다차원배열_강사님_답_().Entry(); }
	private void Entry()
	{
		// > 2차원 배열의 길이를 정하고 선언하는 방법
		int[,] arr1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
		PrintArr(arr1);
		Console.WriteLine();

		//  > 2차원 배열의 길이를 정하지 않고 선언하는 방법
		int[,] arr2 = new int[,] { { 7, 8, 9 }, { 10, 11, 12 } };
		PrintArr(arr2);
		Console.WriteLine();

		//  > 2차원 배열의 길이를 정하지 않고 축약하여 선언하는 방법
		int[,] arr3 = { { 13, 14, 15 }, { 16, 17, 18 } };
		PrintArr(arr3);

	}
	
}

