using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

// > 인터페이스를 상속받는 인터페이스
/// - 1) 상속하려는 인터페이스가 소스 코드가 아닌, 어셈블리로만 제공되는 경우
///    (제공되는 인터페이스를 추가 작성하지 못하기 때문에)
/// - 2) 소스코드로 가지고 있지만, 이미 상속을 진행한 클래스가 많은 경우
///    (원본 인터페이스를 추가 작성할 경우 해당 인터페이스를 상속받는 클래스에서
///      인터페이스에 추가된 내용을 모두 구현해야 하기 때문에)
///      
public interface IReceiveMessage
{
	// 메시지를 받는 메서드입니다.
	// - phone : 메시지를 보낸 Phone 객체가 전달
	// - text : 보낸 메시지가 전달됩니다.
	void ReceiveMessage(Phone phone, string text);
}

public interface IMessageInterface : IReceiveMessage
{
	// 메시지를 보내는 메서드 입니다.
	void SendMessage(IMessageInterface phone);
}
public interface ICall
{
	// > 전화를 거는 메서드
	void Call(string phoneNumber);
}

public class Phone : IMessageInterface, ICall
{
	// 전화번호
	private string PhoneNumber;

	public Phone(string phoneNumber)
	{
		PhoneNumber = phoneNumber;
	}
	public void Call(string phoneNumber)
	{
		Console.WriteLine($"[ {phoneNumber} ] 에게 전화를 겁니다.");
	}
	public void ReceiveMessage(Phone phone, string text)
	{
		// 비프음
		for(int i = 0; i < 3; i++)
		{
			System.Threading.Thread.Sleep(1000);
			System.Media.SystemSounds.Beep.Play();
		}
		Console.WriteLine();
		Console.WriteLine(" - 메시지 도착 알림 - ");
		Console.WriteLine($"{phone.PhoneNumber} 메시지가 도착했습니다.");
		Console.Write("내용 : ");
		// 한글자씩 출력하비낟.
		for(int i = 0; i < text.Length; i++)
		{
			System.Threading.Thread.Sleep(100);
			Console.Write(text[i]);
		}
		Console.WriteLine();
	}
	public void SendMessage(IMessageInterface phone)
	{
		Console.Write("어떤 메시지를 보낼까요? : ");
		phone.ReceiveMessage(this, Console.ReadLine());
	}
	public string GetPhoneNumber()
	{ return PhoneNumber; }
}

class _02_인터페이스
{
	private static void Main() { new _02_인터페이스().Entry(); }
	private void Entry()
	{
		Phone myPhone = new Phone("01012345678");
		Phone yourPhone = new Phone("01098765432");

		myPhone.Call(yourPhone.GetPhoneNumber());
		myPhone.SendMessage(yourPhone);
	}
}
