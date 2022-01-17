using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// > 추상클래스를 상속받는 추상클래스
// - 자식 추상 클래스에서 추상 클래스를 구현해도 되고, 안해도 됩니다.
// - 만약 구현하지 않은 추상클래스가 존재한다면 파생 추상 클래스가 아닌,
//  일반 파생 클래스에서 구현하지 않은 모든 추상 메서드를 구현해야 합니다.

public abstract class Machine
{
	public enum Power { On, Off}
	public abstract void PowerOff(Power power);
	public abstract void Repair();
}
public interface ILogin
{
	void Login(Computer computer);
}
public interface ILogout
{
	void Logout(Computer computer);
}
// 인터페스를 상속받는 추상클래스 라면
// - 인터페이스의 메서드를 구현해도 되지만 추상 메서드화 시켜도 됩니다.
public abstract class Computer : Machine, ILogin, ILogout
{
	protected string OwnerName;

	public Computer(string ownerName) 
	{
		OwnerName = ownerName;
	}
	public abstract void PlayGame();
	public override void Repair()
	{
		Console.WriteLine("PC를 수리합니다.");
	}
	// 인터페이스 메서드를 추상 메서드와 시킵니다.
	public abstract void Login(Computer computer);
	public void Logout(Computer computer)
	{
		Console.WriteLine(OwnerName + " PC를 로그아웃 합니다.");
	}
}
public class MyDeskTop : Computer
{
	public MyDeskTop(string ownerName) : base(ownerName) { }
	public override void Login(Computer computer)
	{
		Console.WriteLine(computer + " PC 로그인");
	}
	public override void PlayGame()
	{
		Console.WriteLine("게임을 합니다.");
	}
	public override void PowerOff(Power power)
	{
		switch(power)
		{
			case Power.On:
				Console.WriteLine("전원을 켭니다.");
			break;
			case Power.Off:
				Console.WriteLine("전원을 끕니다.");
			break;
		}
	}
}
class _02_추상클래스
{
	private static void Main()
	{ new _02_추상클래스().Entry(); }
	private void Entry()
	{
		MyDeskTop pc = new MyDeskTop("짱구");

		pc.PowerOff(Machine.Power.On);
		pc.Login(pc);
		pc.PlayGame();
		pc.Repair();
		pc.Logout(pc);
		pc.PowerOff(Machine.Power.Off);
	}
}