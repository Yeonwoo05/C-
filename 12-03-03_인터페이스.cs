using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 인터페이스 암묵적 구현, 명시적 구현
// > 암묵적 구현 : 메서드를 public 멤버로 구현
// > 명시적 구현 : 메서드를 private 멤버로 구현
//						[인터페이스명.메서드명] 형식으로 구현

public interface IActor1
{
	void Act();
}
public interface IActor2
{
	void Act();
}
public class Person : IActor1, IActor2
{
	public void Act()
	{
		Console.WriteLine("void Act()");
	}
	void IActor1.Act()
	{
		Console.WriteLine("void IActor1.Act()");
	}
	void IActor2.Act()
	{
		Console.WriteLine("void IActor2.Act()");
	}
}

class _03_인터페이스
{
	private static void Main()
	{
		Person p = new Person();
		p.Act();

		(p as IActor1).Act();

		(p as IActor2).Act();
	}
}