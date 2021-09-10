using System;

// private으로 선언한 필드에 접근하는방법?
// - 접근자 와 설정자를 이용합니다.

// 접근자?
// - 지정한 필드의 값을 반환하는 메서드 입니다.
// - 이름앞에 Get을 사용합니다.

// 설정자?
// - 지정한 필드의 값을 설정하는 메서드 입니다.
// - 이름앞에 Set을 사용합니다.

public class MyDog
{
	// private을 필드로 선언을 합니다.
	private string Name;
	private int Age;

	// 필드 Name에 대한 설정자, 접근자를 구성
	public string GetName() { return Name; }
	public void SetName(string name) { Name = name; }

	// 필드 Age에 대한 설정자, 접근자를 구성 -> 여러분이 하기
	public int GetAge() { return Age; }
	public void SetAge(int age)
	{

		if (age <= 0)
		{
			Console.WriteLine("나이 값이 잘못 설정되었습니다.");
			Console.WriteLine("나이를 1로 설정합니다.");
			Age = 1;
			return;
		}

		Age = age;

	}
}

class _02_접근제한자
{
	private MyDog dog = new MyDog();

	private static void Main() { new _02_접근제한자().Entry(); }
	private void Entry()
	{
		dog.SetName("인문?");
		dog.SetAge(2);

		Console.WriteLine(dog.GetName() + "의 나이 : " + dog.GetAge() + "살");
	}
}