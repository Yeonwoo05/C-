using System;

public class Human
{
	// > protected로 선언한 멤버는 자신과, 파생클래스만 접근할 수 있습니다.
	protected string Name;
	protected uint Age;
	// 사람의 정보를 출력하는 메서드
	public void PrintInfo()
	{
		Console.WriteLine("사람 이름 : " + Name);
		Console.WriteLine("나이 : " + Age);
	}
}

public class Student : Human
{
	public Student (string name, uint age)
	{
		Name = name;
		Age = age;
	}
	public void PrintInfo()
	{
		// 만약 부모의 멤버를 사용하고 싶다면
		// "base" 키워드를 앞에 작성 하면 됩니다.
		// base : 바로 상위의 기반 클래스를 가르키는 키워드입니다.
		base.PrintInfo();

		Console.WriteLine("학생의 이름 : " + Name);
		Console.WriteLine("학생의 나이 : " + Age);
	}
}

class _02_상속
{
	private static void Main()
	{
		Student st = new Student("짱구", 5);
		st.PrintInfo();
	}
}
