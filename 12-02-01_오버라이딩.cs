using System;

// > 오버라이딩?
/// - 기반 클래스에 있는 같은 이름, 같은 매개 변수의 메서드를 재정의 하는 것을 의미

public class BaseClass
{
	// virtual : 파생클래스에서 오버라이딩 가능하도록 합니다.
	public virtual void PrintClassName()
	{
		Console.WriteLine("Base Class!!");
	}
}

public class ChildClass : BaseClass
{
	// 오버라이딩을 진행
	// override 키워드를 작성을 합니다.
	// 봉인 (sealed)를 사용해서 해당 메서드를 재정의 하지 못하게 할 수 있습니다.
	// override가 진행된다면 참조하는 객체의 자료형에 따라 메서드가 호출
	public sealed override void PrintClassName()
	{
		//base.PrintClassName();
		Console.WriteLine("Child Class!!");
	}
}

class _01_오버라이딩
{
	private static void Main()
	{
		new _01_오버라이딩().Entry();
	}
	private void Entry()
	{
		// BaseClass 형식의 myClass 변수로 childClass 형식의 객체를 참조
		BaseClass myClass = new ChildClass();

		myClass.PrintClassName();
	}

}
