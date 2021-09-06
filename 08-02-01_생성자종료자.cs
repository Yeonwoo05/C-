using System;

// > 생성자란?
/// - 객체를 생성하기 위해 호출하는 메서드를 의미합니다.
/// - 객체를 생성하는 시점에 필드를원하는 값으로 초기화 하고 싶은 경우
/// 사용할 수 있습니다.
/// - 호출 했을 경우 지정한 형태의 객체를 생성하여 반환합니다.

// > 생성자의 언어적 규칙
/// - 생성자는 클래스의 이름과 같아야 합니다.
/// - 생성자에는 반환 타입을 작성하지 않고, 반환값도 설정하지 않습니다.
/// - 생성자를 매개 변수를 달리하여 오버로딩이 가능합니다.
/// - 생성자를 정의하지 않는다면 컴파이럴는 '기본 생성자'를 제공합니다.
/// - 생성자는 상속되지 않습니다.

// > 기본 생성자란?
/// - 클래스를 선언할 때 명시적으로 생성자를 구현하지 않아도
///   컴파일러에서 만들어주는 기본 형태의 생성자를 의미합니다.
/// - 기본 생성자는 매개변수는 없으며
///	  객체를 생성하는 일 이외에는 아무 일도 하지 않습니다.
///	- 생성자를 하나라도 정의를 하게 된다면 컴파일러는 기본 생성자를 제공하지 않습니다.

class Human
{
	public enum HumanGender { Woman, Man}
	public string Name;
	public int Age;
	public HumanGender Gender;

	// 기본 생성자
	public Human()
	{
		Console.WriteLine("Human 의 생성자를 호출되었습니다.");
		Console.WriteLine("Human의 필드를 초기화하세요.");
	}
	public Human(string Name, int Age, HumanGender Gender)
	{
		this.Name = Name;
		this.Age = Age;
		this.Gender = Gender;

		Console.WriteLine("이름을 [" + Name + "] 으로 초기화 하였습니다.");
		Console.WriteLine("나이를 [" + Age + "] 으로 초기화 하였습니다.");
		Console.WriteLine("성별을 [" + (Gender == HumanGender.Woman ?
			"여성" : "남성") + "] 으로 초기화 하였습니다.");
	}

	public void PrintInfo()
	{
		Console.WriteLine($"{Name}은(는) {Age}살 이며," +
			$"{((Gender == HumanGender.Woman) ? "여성" : "남성")}입니다.");
	}
}

class _01_생성자종료자
{
	static void Main()
	{
		// 매개 변수가 없는 기본생성자를 호출합니다.
		Human human1 = new Human();
		human1.Name = "짱구";
		human1.Age = 5;
		human1.Gender = Human.HumanGender.Man;

		Console.WriteLine();

		// 매개변수가 있는 오버로딩된 생성자를 호출
		Human human2 = new Human("짱아", 1, Human.HumanGender.Woman);
		Console.WriteLine();
		human1.PrintInfo();
		human2.PrintInfo();
	}
}