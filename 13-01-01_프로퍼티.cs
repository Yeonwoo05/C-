using System;

// 프로퍼티(Property)
/// - 기존의 Getter, Setter를 구성하는 방식의 번거로움을 덜어주는 기느입니다.
/// - 편의성, 은닉성을 지킬 수 있습니다.

// - 프로퍼티 선언 방법?
/// - private / protected 데이터 형식 필드이름;
/// 접근한정자 데이터형식 프로퍼티 이름
/// {
///		get { return 필드 이름;}
///		set { 필드이름 = value; }
///	}
public class SampleClass
{
	private string MyString;
	public string myString
	{
		get { return MyString; }
		// - get : 필드로부터 값을 읽어옵니다.
		set { MyString = value; }
		// - set : 필드에 값을 할당합니다.
		// - value : set 접근자의 암묵적 매개 변수
		// 이러한 get/set 이라는 특수 메서드를 프로퍼티에서는 '접근자'라고 합니다.
	}
	//public string GetMyString()
	//{ return MyString; }
	//public void SetMyString(string myString)
	//{ MyString = myString; }
}

class _01_프로퍼티
{
	private static void Main()
	{
		new _01_프로퍼티().Entry();
	}
	private void Entry()
	{
		SampleClass sample = new SampleClass();
		sample.myString = "안녕하세요!";
		Console.WriteLine("sample.myString = " + sample.myString);
	}
}