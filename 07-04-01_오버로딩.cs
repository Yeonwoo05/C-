using System;
using System.ComponentModel;

// 메서드 오버로딩(오버로드)
// - 하나의 클래스에 같은 이름의 메서드를 매개 변수를 다르게 해서
// 여러개 정의를 하는 것을 의미합니다.
// - 매개 변수의 개수, 데이터 형식을 이미 정의된 메서드와 다르게 해서
// 사용할 수 있습니다.
// - 메서드를 호출 할 때 전달하는 형식에 맞는 메서드를 호출합니다.

// 조건
// - 메서드의 이름이 같아야 합니다.
// - 매개변수의 개수, 또는 데이터 타입이 달라야 합니다.
// - 매개 변수는 같은데, 반환 형식이 다른 경우는 오버 로딩이 성립하지 않습니다.

class _01_오버로딩
{

	// 메서드의 기본형
	static int Plus(int a, int b) 
	{ return a + b; }
	// 메서드 오버로딩
	static int Plus(int a, int b, int c)
	{ return a + b + c; }
	static int Plus(int a, int b, int c, int d)
	{ return a + b + c + d; }
	static int Plus(int a, string b, int c, int d)
	// { return a + int.Parse(b) + c + d; } // 1번째
	//{ return int.Parse(a.ToString() + b + c.ToString() + d.ToString()); } // 2
	{ return int.Parse(b + a + c + d); }


	static void Main()
	{
		Console.WriteLine(Plus(10, 20));

		// 2 번째
		Console.WriteLine(Plus(10, 20, 30));

		//  3번째
		Console.WriteLine(Plus(10, 20, 30, 40));

		// 4번째
		Console.WriteLine(Plus(10, "20", 30, 40));
	}

}