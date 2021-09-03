using System;

// 다음과 같은 클래스를 설계하고 Main에서 기능을 실행보세요.

// = main에서 실행순서 =				= 설계할 때 필요한 내용 = 
/// - 전원 On						= 클래스 이름 : Airconditioner
/// - 온도 설정 18'C					= 변수 =
/// - 현재 온도 출력					= - 전원On / OFF 값을 저장할 변수
/// - 온도 증가						= - 온도를 저장할 변수(정수)
/// - 현재 온도 출력					= - 전원의 기본 값 : 꺼짐
/// - 온도 감소						= - 온도의 기본 값 : 22'C
/// - 현재 온도 출력					=
/// - 전원 Off						= - 메서드 -
///									= - 전원 On / OFF
///									= - 온도 설정
///									= - 온도 증가
///									= - 온도 감소
///									= - 현재 온도 출력

class Aircontioner
{
	// 전원 상태
	public enum PowerState { On, Off}
	public PowerState Power = PowerState.On;

	// 온도
	public int Temperature = 22;

	// 전원 On/ OFF
	public void SetPower(PowerState power)
	{
		Power = power;
		Console.WriteLine("전원이 " + (Power == PowerState.Off ? "꺼졌" : "켜졌")
			+ "습니다.");
	}

	// 온도 설정
	public void SetTemperature(int newTemp)
	{
		Temperature = newTemp;
		Console.WriteLine("온도를 " + Temperature + "'C로 설정합니다.");
	}
	// 온도 증가 감소
	public enum TempChange { Up, Down}
	public void TempUpDown(TempChange tempChange)
	{
		Temperature += (tempChange == TempChange.Up ? 1 : -1);
		Console.WriteLine("온도를 " + Temperature + "'C로 설정합니다.");
	}
	// 현재 온도 출력
	public void CurrentTEmp()
	{
		Console.WriteLine("온도를 " + Temperature + "'C로 설정합니다.");
	}
}

class _03_클래스
{
	static void Main()
	{
		Aircontioner air = new Aircontioner();

		// 전원ON
		air.SetPower(Aircontioner.PowerState.On);

		// 온도 설정
		air.SetTemperature(18);

		// 현재 온도 출력
		air.CurrentTEmp();

		// 온도 증가
		air.TempUpDown(Aircontioner.TempChange.Up);

		// 현재 온도 출력
		air.CurrentTEmp();

		// 온도 감소
		air.TempUpDown(Aircontioner.TempChange.Down);

		// 현재 온도 출력
		air.CurrentTEmp();

		// 전원ON
		air.SetPower(Aircontioner.PowerState.Off);
	}
}