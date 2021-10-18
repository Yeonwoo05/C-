using System;
using System.Security.Cryptography.X509Certificates;


// > 상속의 경우 생성자, 종료자 호출 순서
// 생성자 : 최상위 기반 클래스 생성자 -> 최하위 파생 클래스 생성자
// 종료자 : 최하위 파생 클래스 종료자 -> 최상위 기반 클래스 종료자

public class A
{ public A() { Console.WriteLine("A의 생성자 호출!"); }
		~A() { Console.WriteLine("A의 종료자 호출!"); }
}
public class B : A
{
	public B() { Console.WriteLine("B의 생성자 호출!"); }
		  ~B() { Console.WriteLine("A의 종료자 호출!"); }
}

public class C : B
{
	public C() { Console.WriteLine("C의 생성자 호출!"); }
		  ~C() { Console.WriteLine("C의 종료자 호출!"); }
}


class _03_상속
{
	private static void Main()
	{
		new C();
	}
}