using System;

// 클래스와 구조체를 이용해서
// 강아지의 정보를 가지고 있는 프로그램을 작성해주세요.
// 클래스 안에 구조체가 있고
// 그 구조체는 생성자에서 이름과 나이를 초기화합니다.
// 강아지의 정보(이름, 나이)를 출력할 수 있는 메서드를 만들고
// 강아지의 짖는 소리를 출력하는 메서드도 만든 뒤
// 메인 함수에서 출력을 해주세요.

// 제한시간 2:28분 시작!
public class Dog
{
	public struct DogInfo
	{
		public string Name;
		public uint Age;
		public DogInfo(string name, uint age)
		{
			Name = name;
			Age = age;
		}
	}

	private DogInfo dogInfo;

	public Dog(string name, uint age)
	{
		dogInfo = new DogInfo(name, age);
	}
	// 강아지의 정보를 출력하는 메섣,
	public void PrintInfo()
	{
		Console.WriteLine("강아지의 이름 : " + dogInfo.Name);
		Console.WriteLine(dogInfo.Name + "의 나이 : " + dogInfo.Age);
	}
	// 강아지의 짖는 소리를 출력하는 메서드
	public void Bark()
	{
		Console.WriteLine("멍왈멍왈멍왈!!");
	}
}

class _02_구조체
{
	private static void Main()
	{
		Dog myDog = new Dog("흰둥이", 2);
		myDog.PrintInfo();
		myDog.Bark();
	}
}