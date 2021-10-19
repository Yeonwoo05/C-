using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Job
{
	// 직업군 이름
	private string Name;

	// 직업군이 사용하는 무기
	private string Weapon;

	protected Job(string name, string weapon)
	{
		this.Name = name;
		this.Weapon = weapon;
	}
	// 정보를 출력하는 메서드
	public void PrintInfo()
	{
		Console.WriteLine("이름 : " + Name);
		Console.WriteLine("사용하는 무기 : " + Weapon);
	}
}

public sealed class Warriors : Job
{
	// 봉인 : Sealed이라는 키워드를 class 앞에 써주면 됩니다.
	// - 클래스에 사용될 경우 봉인된 클래스로 설정하여 
	// 더이상 상속시킬수 없도록 합니다.

	// 방어력
	public int Defensive;
	// 부모 클래스의 생성자 호출
	public Warriors(string name, string weapon, int defensive) : base(name, weapon)
	{
		Defensive = defensive;
	}
	public void PrintInfo()
	{
		base.PrintInfo();
		Console.WriteLine("방어력 : " + Defensive);
		Console.WriteLine();
	}
}
 
public sealed class Magician : Job
{
	public int Mana;

	public Magician(string name, string weapon, int mana) : base(name, weapon)
	{
		Mana = mana;
	}
	public void PrintInfo()
	{
		base.PrintInfo();
		Console.WriteLine("마나력 : " + Mana);
		Console.WriteLine();
	}
}
class _04_상속
{
	private static void Main()
	{
		new _04_상속().Entry();
	}
	private void Entry()
	{
		//Job job = new Job("초보", "없음");
		Job warrior = new Warriors("검사", "철검", 30);

		warrior.PrintInfo();

		((Warriors)warrior).PrintInfo();

		// 똑같은 방법으로 마법사 출력
		// "마법사", "지팡이", 100
		Job magician = new Magician("마법사", "지팡이", 100);

		((Magician)magician).PrintInfo();


		// 상속에서 사용할 수 있는 연산자
		// ~ 이다(is) : 객체가 해당 형식에 해당하는지 검사해서
		//  그 결과를 bool 형식으로 반환
		// ~ 처럼(as) : 형식 변환 연산자와 같은 역할을 하지만
		//   변환에 실패할 경우 null을 반환

		Console.WriteLine();
		Console.WriteLine("Magician이 Warrior 인지 확인합니다.");
		Console.WriteLine((magician is Warriors ? "네" : "아니오"));
		Console.WriteLine();

		Magician magic = (warrior as Magician);
		Console.WriteLine("warrior as Magician = " + (magic == null ? "NO" : "YES"));

	}
}