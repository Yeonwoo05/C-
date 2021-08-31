using System;
class _03_참조에의한매개변수전달
{
	// > ref 한정자를 이용한 참조 반환
	// - 반환받은 결과를 참조로 다룰수 있습니다.

	// 사용방법 ? 
	// - 반환형식에 ref 한정자를 작성하고, return 문이 반환하는
	// 변수 앞에도 ref 한정자를 명시합니다.

	static ref int GetRefData(ref int varforpass)
	{
		return ref varforpass;
	}
	static void Main()
	{
		int A = 10;

		// B에A를 참조합니다.
		ref int B = ref GetRefData(ref A);
		ref int C = ref B;

		Console.WriteLine("A = " + A);
		Console.WriteLine("B = " + B);
		C = 100;
		Console.WriteLine("C = " + C);
	}
}