using System;


class _04_배열
{
	// myArray는 A의 곱셈 결과값을 갖는 배열입니다.
	// A의 값을 입력받고 MyArray 요소들에게서 {A X 1 - A X 9} 까지의 값을 할당하여
	// PrintAllElems() 로 출력을 해주세요.
	private static void Main() { new _04_배열().Entry(); }
	private void Entry()
	{
		// 입력값
		Console.WriteLine("A의 값을 입력하세요.");
		int A = int.Parse(Console.ReadLine());

		int[] MyArray= new int[10];

		for(int i = 1;i < MyArray.Length; i++)
		{
			MyArray[i] = A * i;
			Console.WriteLine($"{A} X {i} = {MyArray[i]}");
			Console.WriteLine();
		}
		
	}
	
}