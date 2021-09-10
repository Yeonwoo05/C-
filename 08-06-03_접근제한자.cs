using System;

// Character 클래스를 정의하고 다음과 같은 결과를 출력하세요
// 클래스의 이름 : Character
// private 멤버 : 닉네임, 레벨
// 클래스의 외부에서 사용할수 있는 기능 : 캐릭터 정보 출력

	// 캐릭터 이름은 ? 자장가부른다
	// 캐릭터 레벨 ? 10

	// 캐릭터 닉네임 : 자장가부른다
	// 캐릭터 레벨 : 10 LV


	public class Character
{
	private string NickName;
	private int Level;
	public void SetNickName(string nickname) { NickName = nickname; }
	public void SetLevel(int level) { Level = level; }

	public void PrintInfo()
	{
		Console.WriteLine($"캐릭터 닉네임 : {NickName}");
		Console.WriteLine($"{NickName}의 레벨 : {Level} LV");
	}

}
class _03_접근제한자
{
	static void Main()
	{
		new _03_접근제한자().Entry();
	}
	void Entry()
	{
		Character character = new Character();
		Console.Write("캐릭터 이름은 ? ");
		character.SetNickName(Console.ReadLine());
		Console.Write("캐릭터 레벨은 ? ");
		character.SetLevel(int.Parse(Console.ReadLine()));

		character.PrintInfo();
	}
}
