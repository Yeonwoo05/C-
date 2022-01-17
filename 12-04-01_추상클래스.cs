using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// > 추상클래스란?
/// - 미완성된 클래스를 의미합니다.
/// - 클래스 구현이 가능하지만, 인터페이스 처럼 상속시켜서 사용합니다.
/// - 인스턴스화가 불가능합니다.
/// - abstract 키워드를 사용해서 추상 클래스를 선언합니다.
/// - 추상 메서드를 가질수 있습니다.

// > 추상 메서드?
/// - 몸체가 없는 메서드를 의미합니다.
/// - abstract 키워드를 이용해서 추상 메서드를 선언할 수 있습니다.
/// - 추상 메서드를 갖는 클래스라면 무조건 추상 클래스가 되어야 합니다.
/// - 인터페이스르 상속받는 추상 클래스라면 인터페이스의 멤버를 추상 메서드화 시키거나
/// 구현할 수 있습니다.
/// - 파생 클래스에서 구현을 강제할 때 사용합니다.

// > 추상클래스 선언
/// - 해당 클래스는 상속을 통해서 사용 가능합니다.
public abstract class SampleClassBase
{
	// 필드
	protected string Print;

	// > 일반 메서드
	public void HelloClass()
	{
		Console.WriteLine("Hello Class!");
	}
	// 추상 메서드
	public abstract void AbstractMethod();
}
public class SampleClass : SampleClassBase
{
	// 추상 메서드를 구혀낳ㅂ니다.
	// - override을 해야합니다.
	// - 부모의 접근제한자, 반환 형식, 메서드명, 매개변수 목록이 같아야 합니다.
	public override void AbstractMethod()
	{
		Print = "Abstract Method!";
		Console.WriteLine(Print);
	}
}

class _01_추상클래스
{
	private static void Main() { new _01_추상클래스().Entry(); }
	private void Entry()
	{
		SampleClassBase sampleClass = new SampleClass();
		sampleClass.HelloClass();
		sampleClass.AbstractMethod();
	}
}