using System;
using System.Runtime.CompilerServices;

class _01_가변인자
{
	private void PrintAll(params string[] prints)
	{
		foreach (string str in prints)
			Console.WriteLine(str);
	}
	
	
	private static void Main() { new _01_가변인자().Entry(); }

	private void Entry()
	{
		params string[] prints;
		Console.ReadLine(prints);
		// 가변 인자 매개 변수란?
		/// - 개수가 유연하게 변할 수 있는 매개변수를 뜻합니다.
		/// - 매개 변수의 개수에 따라 오버 로딩처리를 해주지 않아도 됩니다.
		/// - params 키워드와 배열을 사용하게 되는데
		/// - 가변 인자 매개 변수는 항상 필수 매개변수 뒤에 선언할 수 있습니다.
		/// - 만일 선언을 했다면 매개변수를 선언할 수 없습니다.
		PrintAll("우와", "코딩은", "너무 재밌다.", "매일매일 해야지");
	}
}

