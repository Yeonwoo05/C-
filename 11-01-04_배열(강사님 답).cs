using System;
using System.Runtime.CompilerServices;

class _04_배열_강사님_답_
{
	int A;

	private void PrintAllElems(int[] values)
	{
		for (int i = 0;i < values.Length; i++)
		{
			Console.WriteLine($"{A} X {i + 1} = {values[i]}");
		}		
	}

	private static void Main() { new _04_배열_강사님_답_().Entry(); }
	private void Entry()
	{
		int[] myArray = null;

		Console.Write("A를 입력해주세요 : ");
		A = int.Parse(Console.ReadLine());
		myArray = new int[9];
		for (int i = 0;i < myArray.Length; i++)
		{
			myArray[i] = A * (i + 1);
		}
		PrintAllElems(myArray);
	}
}

