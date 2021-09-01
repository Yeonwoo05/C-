using System;
// > ref 한정자를 이용해서 두개의 매개 변수에 전달된 변수의 값을 변경하는
// Swap() 메서드를 작성해주세요
// - 조건 : Swap 메서드의 반환 형식은 void로 작성하세요

	// ex ) 
	// A = 10
	// B = 20;
	// Swap (10, 20_

	// A = 20
	// B = 10
class _04_참조에의한매개변수전달
{
	static void Swap(ref int val1, ref int val2)
	{
		int temp = val1;
		val1 = val2;
		val2 = temp;
	}

	static void Main()
	{
		int A = 10;
		int B = 20;
		Swap(ref A, ref B);
		Console.WriteLine("A = " + A);
		Console.WriteLine("B = " + B);
	}
}