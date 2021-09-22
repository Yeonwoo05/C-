using System;

// 배열이란?
/// - 동일한 타입의 변수를 모아 놓은 데이터 집합을 의미합니다.
/// - 여러개의 동일한 타입의 변수가 필요할 경우 유용하게 사용할 수 있습니다.
/// - 복합 데이터 형식입니다.

// > 배열 선언
/// - 데이터형식 [] 식별자 = new 데이터형식[용량];
/// - int var1, var2, var3, var4, var5;
/// - int [] var = new int[5];
/// 
class _01_배열
{
	private static void Main() { new _01_배열().Entry(); }

	void Entry()
	{
		int[] myArray1 = new int[5];
		/// - 배열의 요소들은 엘리먼트(Element)라고 하며
		///   각각의 요소들을 구분하기 위한 번호를 인덱스(Index)라고 합니다.
		/// - 배열의 인덱스는 0부터 시작합니다.
		/// - 각각의 엘리먼트에 접근할 때에는 "배열이름[index]"를 통해 할 수 있습니다.
		/// - [new int[5]; ] : 20byte의 메모리를 힙에 동적 할당 하겠다 라는 뜻입니다.

		myArray1[0] = 10;
		myArray1[1] = 20;
		myArray1[2] = 30;
		myArray1[3] = 40;
		myArray1[4] = 50;

		Console.WriteLine("myArray1[0] = " + myArray1[0]);
		Console.WriteLine("myArray1[1] = " + myArray1[1]);
		Console.WriteLine("myArray1[2] = " + myArray1[2]);
		Console.WriteLine("myArray1[3] = " + myArray1[3]);
		Console.WriteLine("myArray1[4] = " + myArray1[4]);
		Console.WriteLine();

		// string 2 -> 짱구, 철수
		string[] myArray2 = new string[2] { "짱구", "철수" };

		/// myArray2[0] = "짱구";
		/// myArray2[1] = "철수";

		Console.WriteLine("myArray2[0] = " + myArray2[0]);
		Console.WriteLine("myArray2[1] = " + myArray2[1]);
		Console.WriteLine();

		// int 3 -> 1,2,3
		int[] myArray3 = new int[3] { 1, 2, 3 };

		/// myArray3[0] = 1;
		/// myArray3[1] = 2;
		/// myArray3[2] = 3;

		Console.WriteLine("myArray3[0] = " + myArray3[0]);
		Console.WriteLine("myArray3[1] = " + myArray3[1]);
		Console.WriteLine("myArray3[2] = " + myArray3[2]);
		Console.WriteLine();

		// object 3 -> Fun, Coding, ZZZ
		object[] myArray4 = new object[3] { "Fun", "Coding", "ZZZ" };

		/// myArray4[0] = "Fun";
		/// myArray4[1] = "Coding";
		/// myArray4[2] = "ZZZ";

		Console.WriteLine("myArray4[0] = " + myArray4[0]);
		Console.WriteLine("myArray4[1] = " + myArray4[1]);
		Console.WriteLine("myArray4[2] = " + myArray4[2]);

	}
}

