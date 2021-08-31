using System;
class _01_참조에의한매개변수전달
{
	// 매개변수 value에 전달 된 값에 10을 더하는 메서드
	static void AddTen(int value)
	{
		value += 10;
	}

	static void Main()
	{
		int A = 0;
		AddTen(A);
		Console.WriteLine("A = " + A);
		// Call By Value ("값에 의한 호출"), Pass By Value("값에 의한 전달")
		// 값 복사
	}
}