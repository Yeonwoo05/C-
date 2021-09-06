using System;
// 종료자(소멸자)?
/// - 객체가 소멸할때 마지막으로 호출되는 메서드입니다.
/// - CLR(Common Language Runtime) 의 가비지 컬렉터가
///  객체의 소멸 시점을 판단해서 호출합니다.
/// - 소멸자는 소멸 시점을 명시적으로 구현하지 않는 것이 좋습니다.
/// 

// > 종료자는 앞에 '~'을 붙여 있어 명시적으로 선언합니다.
// - 반환 형태를 지정할 수 없고 매개변수도 추가 할 수 없습니다.
// 명시적으로 호출도 불가능합니다.
class Hello
{
	int InstanceIdent;
	public Hello(int instanceIdent)
	{
		InstanceIdent = instanceIdent;
		Console.WriteLine(InstanceIdent + " :: Constructor Called! ");
	}
	~Hello()
	{
		Console.WriteLine(InstanceIdent + " :: Finializer Called! ");
	}

}

class _03_생성자종료자
{
	static void Main() { new _03_생성자종료자().Entry(); }
	void Entry()
	{
		for (int i = 0; i < 10; i++)
		{
			new Hello(i);
		}
		Console.WriteLine("ㅋㅋ 생성함 ㅋㅋ");
	}
}