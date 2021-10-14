using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// > 프로그래밍에서의 상속이란?
//부모 클래스가 가지고 있는 것을 자식 클래스가 물려받아 같이 공유하며
//나아가 확장하는 개념을 의미한다.
//비슷한 클래스들의 공통된 코드를 묶어 기반(Base) 클래스로 만들고
//새로운 클래스를 작성할 때 같은 코드를 다시 작성하지 않도록 하여
//생산성을 높이는 깁버을 의미합니다.
//클래스에서만 사용할 수 있습니다.
//C#에서는 다중 상속을 지원하지 않습니다.

	// > 기반 클래스 정의
public class BaseClass
{
	// private으로 선언한 멤버를 제외한 나머지 멤버는 해당 클래스를
	// 기반 클래스로 설정하게 되었을 경우 기본으로 탑재하게 됩니다.
	public void BaseMethod()
	{
		Console.WriteLine("Base Method!!!");
	}
}

// > BaseClass의 파생클래스를 정의합니다.
// - 기반 클래스를 지정할 때 콜론 (:) 이용해서 기반 클래스 이름을 작성합니다.
public class ChildClass : BaseClass
{
	// 해당 클래스는 BaseClass를 기반으로 작성되었기 때문에 부모의 private멤버를
	// 제외한 모든 멤버를 탑재하게 됩니다.
	public void ChildMethod()
	{
		Console.WriteLine("ChildMethod !!!!");
	}
}

	class _01_상속
{
		ChildClass child = new ChildClass();

	private static void Main() { new _01_상속().Entry(); }
	private void Entry()
	{
		child.BaseMethod();
		child.ChildMethod();
	}

}
