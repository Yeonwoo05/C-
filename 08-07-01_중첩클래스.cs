using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_클래스._07_중첩클래스
{

	// 중첩클래스
	// - 내부 클래스라고 합니다.
	// - 클래스 내부에 선언된 클래스를 의미합니다.
	// - 자신이 속해있는 클래스의 멤버에 자유롭게 접근할 수 있습니다.

	public partial class GameCharacter
	{
		// 내부 클래스 Info 선언 합니다.
		public class Info
		{
			private string Name;
			private uint Level;

			public Info(string name, uint level)
			{
				Name = name;
				Level = level;
			}

			// 멤버에 대한 접근자를 구성
			public string GetName() { return Name; }
			public uint GetLevel() { return Level; }
		}
	}
	public partial class GameCharacter
	{
		private Info PlayerCharacterInfo = null;
		public Info GetCharacterInfo() { return PlayerCharacterInfo; }

		// GameCharacter의 생성자를 만듭니다.
		public GameCharacter(Info InitialInfo)
		{
			PlayerCharacterInfo = InitialInfo;
		}
	}
	class _01_중첩클래스
	{
		// GameCharacter 객체를 참조할 변수
		private GameCharacter CharacterInstance = null;

		private static void Main() { new _01_중첩클래스().Entry(); }
		private void Entry()
		{
			// GameCharacter의 생성자를 호출합니다.
			// Info의 객체에 값을 전달
			GameCharacter.Info info = new GameCharacter.Info("짱구", 5);
			CharacterInstance = new GameCharacter(info);

			Console.WriteLine("캐릭터 닉네임 : " + CharacterInstance.GetCharacterInfo().GetName());
			Console.WriteLine("캐릭터 레벨 : " + CharacterInstance.GetCharacterInfo().GetLevel());
		}
	}
}
