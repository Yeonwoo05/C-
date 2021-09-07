using System;

// > Static?
/// - 키워드 뒤에 오는 필드나 메서드를 인스턴스에 소속시키는 것이 아닌,
///   클래스 자체에 소속시키도록 하는 한정자입니다.
/// - 멤버 변수는 정적 필드가 되게 하고, 메서드는 정적 메서드가 됩니다.

// > static 이 붙지 않은 필드나 메서드는 인스턴스에 소속되므로
///		인스턴스 변수, 인스턴스 메서드라고 합니다.

// > 정적 필드, 정적 메서드, 인스턴스 변수, 인스턴스 메서드의 차이점?
/// - 인스턴스 변수, 인스턴스 메서드
///   무조건 특정한 클래스 형태로 인스턴스를 만들고 메서드를 호출하거나
///   변수를 사용해야 합니다.
///   각각의 인스턴스마다 다른 값을 가질수 있습니다.
/// - 정적 변수, 정적 메서드
///   클래스에 소속되어있기 때문에 인스턴스를 만들지 않아도 사용할 수 있습니다.

class SampleClass1
{
	// 정적 필드
	public static int Var = 0;
	// 정적 메서드
	public static void PrintVar()
	{
		Console.WriteLine("SampleClass1.Var = " + Var);
	}
}

class SampleClass2
{
	// 인스턴스 필드
	public int Var = 0;
	// 인스턴스 메서드
	public void PrintVar()
	{
		Console.WriteLine("SampleClass2.Var = " + Var);
	}
}
// > 만약 static 한정자를 이용해서 클래스를 선언할때?
// - 해당 클래스는 인스턴스 멤버를 가질수 없으며
//   무조건 상수, static변수, static 메서드만 가질 수 있습니다.
static class StaticClass
{
	public static int Var = 0;
	public const int Var2 = 0;
	public static void Method() { }
}
class _01_Static
{
	static void Main()
	{
		StaticClass.Method();

		SampleClass1 sample1 = new SampleClass1();
		SampleClass2 sample2 = new SampleClass2();


		// 정적 메서드, 필드에 접근하기 위해서는
		// 클래스의 이름.필드(메서드)를 적어야 되며
		// 초기화를 통해 객체를 전달 받았더라도
		// 안에 들어있는 멤버에 접근하기 어렵다.

		SampleClass1.Var = 500;
		SampleClass1.PrintVar();

		sample2.Var = 100;
		sample2.PrintVar();
	}
}