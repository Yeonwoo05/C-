using System;

// > 다음 코드에서 NameCard 클래스 GetName(), SetName(), GetAge(), SetAge()
// 메서드를 프로퍼티로 변경하고 이름과 나이를 출력해보세요.

public class NameCard
{
	private string Name;
	private int Age;

	//public string GetName() { return Name; }
	//public void SetName(string name) { Name = name; }
	//public int GetAge() { return Age; }
	//public void SetAge(int age) { Age = age; }

	public string name
	{
		get { return Name; }
		set { Name = value; }
	}
	public int age
	{
		get { return Age; }
		set { Age = value; }
	}

}

class _03_프로퍼티
{
	private static void Main()
	{
		new _03_프로퍼티().Entry();
	}
	private void Entry()
	{
		NameCard namecard = new NameCard();

		namecard.name = "강아지";
		namecard.age = 7;
		Console.WriteLine("name : " + namecard.name);
		Console.WriteLine("age : " + namecard.age);
	}
}