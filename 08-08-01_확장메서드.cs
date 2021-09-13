using System;

// 확장 메서드
// - 기존 클래스의 기능을 확장하는 기법

// - 확장 메서드를 포함하는 클래스는 반드시 static 클래스가 되어야 합니다.
public static class MyClass
{
	// > int타입 확장
	// 확장 메서드 규칙
	// - 접근 한정자는 public, static 키워드를 통해서 클래스에 포함되게 해야한다.
	// - 첫번째 매개변수에 this, 확장 클래스 타입을 명시를 해야합니다.
	// - public static [반환형식][확장메서드명](this [확장 클래스 타입] 식별자, 매개변수 목록);

	public static int Plus(this int var, int add)
	{
		return var + add;
	}
	public static int Mimun(this int var, int sub)
	{
		return var - sub;
	}
}

class _01_확장메서드
{
	private static void Main()
	{
		int A = 10;
		Console.WriteLine("A.Plus(10) = " + A.Plus(10));
		Console.WriteLine("A.Plus(100) = " + A.Plus(100));
		Console.WriteLine("A.Minus(100) = " + A.Mimun(100));
	}
}