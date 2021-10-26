using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// > 인터페이스란?
/// - 클래스와 비슷하지만, 메서드, 이벤트, 인덱서, 프로퍼티만 가질 수 있습니다.
/// - 내부에서 접근 한정자를 사용할 수 없고, 모두 public입니다.
/// - 인스턴스화 시킬 수 없습니다.
/// - 클래스와 다르게 다중 상속이 가능합니다.
/// - 선언시 interface 라는 키워드를 사용합니다.

// 인터페이스 ISampleInterface1을 선언
public interface ISampleInterface1
{
	// 해당 인터페이스를 상속받은 클래스는 "helloInterface"라는 메서드를
	// 구현해야 합니다.
	void HelloInterface();
}

public interface ISampleInteface2
{
	void PrintHello();
}


// > 인터페이스 상속도 클래스 상속과 동일하게 : 을 사용합니다.
// - 인터페이스 다중 상속을 사용할 때 쉼표(,)로 각각 인터페이스를 구분합니다.
public class SampleClass : ISampleInterface1, ISampleInteface2
{
	// 상속받은 인터페이스의 메서드를 구현할때 public 접근한정자를 사용하는 방법
	// "인터페이스 암묵적 구현" 이라고 한다.
	public void HelloInterface()
	{
		Console.WriteLine("HelloInterface Method!!");
	}
	public void PrintHello()
	{
		Console.WriteLine("PrintHello Method!!");
	}
}


class _01_인터페이스
{
	private static void Main() { new _01_인터페이스().Entry(); }
	private void Entry()
	{
		SampleClass sample = new SampleClass();
		sample.PrintHello();
		sample.HelloInterface();

		ISampleInterface1 sample1 = sample;
		sample1.HelloInterface();

		ISampleInteface2 sample2 = sample;
		sample2.PrintHello();
	}
}
