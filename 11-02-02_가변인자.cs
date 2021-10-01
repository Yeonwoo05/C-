using System;

class _02_가변인자
{
	int[] MakeIntArray(params int[] values)
	{ return (int[])values.Clone(); }
	// 배열.Clone() : 배열이 깊은복사를 수행합니다.
	// object형식으로 리턴을 하기 때문에 원하는 형식으로 캐스팅해야 합니다.

	private static void Main() { new _02_가변인자().Entry(); }
	private void Entry()
	{
		int[] myArray = MakeIntArray(10, 20, 30, 40, 50);

		foreach (var i in myArray)
			Console.Write(i + " ");
		Console.WriteLine();
	}
}

