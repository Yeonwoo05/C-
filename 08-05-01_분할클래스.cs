using System;

// 분할 클래스?
// - 여러번 나눠서 구현하는 클래스를 의미합니다.
// - 클래스 구현이 길어질 경우 사용할 수 있습니다.
// - class 키워드 앞에 partial 키워드를 사용합니다.
// - 분할 작성할 클래스의 이름은 같아야 합니다.

partial class MyClass
{
	public void Method1()
	{
		Console.WriteLine("Method1 호출됨!");
	}
	public void Method2()
	{
		Console.WriteLine("Method2 호출됨!");
	}
}
partial class MyClass
{
	public void Method3()
	{
		Console.WriteLine("Method3 호출됨!");
	}
	public void Method4()
	{
		Console.WriteLine("Method4 호출됨!");
	}
}

class _01_분할클래스
{
	MyClass myClass = null;

	static void Main() { new _01_분할클래스().Entry(); }
	void Entry()
	{
		myClass = new MyClass();
		myClass.Method1();
		myClass.Method2();
		myClass.Method3();
		myClass.Method4();
	}
}