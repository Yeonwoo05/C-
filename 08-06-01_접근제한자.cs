using System;

// 접근제한자(접근 한정자) ?
// - 외부로부터 멤버로의 접근을 제한할 때 사용하는 한정자입니다.

// > 객체 지향 프로그래밍 특성
// > 은닉성
/// - 값의 보호를 위해서 객체의 필드, 메서드를 필요에 의해 감추거나
///   공개하는 것을 의미합니다.
/// - 접근 한정자를 사용 합니다.

// > 상속성
/// - 부모가 가지고 있는 것을 자식 클래스가 물려받아 같이 공유하며
///   더 나아가 확장하는 개념을 의미합니다.
/// - 기존의 코드를 재사용하여 보다 쉽게 코드를 작성하는 기법을 말합니다.
/// - 비슷한 개념을 발견해서 이를 공통화 시켜 개발의 생산성을 향상시킬수 있다.
/// 
// > 다형성
/// - 같은 타입이지만 실행 결과가 다양한 객체를 이용할 수 있는 성질을 의미
/// - 하나의 이름으로 많은 상황에 대처하는 기법
/// 

// > 접근 한정자의 종류
/// - public
/// 클래스의 내부 / 외부 모든곳에서 접근이 가능하도록 합니다.
/// 
/// - protected
/// 클래스의 외부에서는 접근하지 못하지만 자기 내부와 파생된 클래스에서는
/// 접근이 가능합니다.
/// 
/// - private
/// 클래스 내부에서만 접근 가능하도록 합니다. 파생 클래스, 외부에서 접근이
/// 불가능합니다.
/// 클래스와 구조체에서 접근 제한자를 설정하지 않았을 경우 기본값입니다.
/// 
/// - internal
/// 같은 어셈블리 단위에서만 public으로 접근이 가능합니다.
/// 다른 어셈블리 에서는 private과 동일하게 작용합니다.
/// namespace 에서 접근 제한자를 명시적으로 지정하지 않았을 경우 기본값입니다.
/// 
/// - protected internal
/// 같은 어셈블리 코드에서만 protected로 접근할 수 있습니다.
/// 다른 어셈블리에서는 private과 동일하게 작용합니다.
/// 
/// - private internal
/// 같은 어셈블리에 있는 클래스에서 상속받은 클래스 내부에서만 접근이 가능합니다.
/// 

public class Student
{
	// 학생의 이름을 가진 멤버
	private string Name;

	// 학생의 나이를 가진 멤버
	private int Age;
	
	public Student(string name, int age)
	{
		Name = name;
		Age = age;

	}

	// 학생의 정보를 출력하는 메서드
	public void PrintInfo()
	{
		Console.WriteLine("학생의 이름 : " + Name);
		Console.WriteLine(Name + "의 나이 : " + Age);
	}

}
class _01_접근제한자
{
	private Student st1 = null;
	private Student st2 = null;

	static void Main() { new _01_접근제한자().Entry(); }
	void Entry()
	{
		// 입력값을 저장할 변수
		string inputName;
		int inputAge;

		for(int i = 0; i < 2; i++)
		{
			Console.Write($"학생 {i + 1}의 이름을 입력하세요 : ");
			inputName = Console.ReadLine();

			Console.Write($"학생 {i + 1}의 나이를 입력하세요 : ");
			inputAge = int.Parse(Console.ReadLine());

			if (i == 0) st1 = new Student(inputName, inputAge);
			else st2 = new Student(inputName, inputAge);
		}

		Console.WriteLine();
		st1.PrintInfo();
		st2.PrintInfo();
	}
}