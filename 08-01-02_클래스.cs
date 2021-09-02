using System;

// 새로운 클래스 만들기
class Dog
{
	// 강아지 형식의 객체를생성합니다.
	// 강아지가 가질 속성과 기능을 정의합니다.
	// > 강아지의 이름
	public string Name;

	// > 강아지의 나이
	public int Age;

	// > 강아지의 울음소리
	public string Sound;

	// 강아지의 정보를 출력하는 메서드를 만듭니다.
	public void PrintInfo()
	{
		Console.WriteLine("강아지의 이름 : " + Name);
		Console.WriteLine(Name + " 의 나이 : " + Age);
		Console.WriteLine(Name + " : " + Sound);
		Console.WriteLine();
	}

	// 강아지의 산책을 정리하는 메서드를 만듭니다.
	public void GoToPark() {
		Console.WriteLine(Name + "은 목줄을 하고 열심히 공원 뛰어다닙니다.");
		Console.WriteLine("나무아래에서 열심히 잡니다.");
		Console.WriteLine("Zzz");
		Console.WriteLine();
	}
}



class _02_클래스
{
	static void Main()
	{
		// 강아지 두마리를 객체로 받습니다.
		Dog Choco = new Dog();

		Dog Sam = new Dog();
		// 보기에는 같은 형태인데 새로운 Dog 객체 입니다.
		// 서로 다른 객체입니다.

		Choco.Name = "초코";
		Choco.Age = 10;
		Choco.Sound = "왈멍";

		Sam.Name = "샘";
		Sam.Age = 2;
		Sam.Sound = "컹컹";

		Choco.PrintInfo();
		Sam.PrintInfo();

		Choco.GoToPark();

	}
}