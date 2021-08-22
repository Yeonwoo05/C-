using System;
class _01_Break
{
	// > 점프문?
	// - 프로그램의 흐름을 끊고 프로그램의 실행 위치를 원하는 곳으로 도약시킬 때 사용합니다.
	
	// C#은 5개의 점프문을 제공합니다.
	/// - break
	/// - continue
	/// - goto
	/// - return
	/// - throw
	

	static void Main()
	{
		// > break문 ?
		/// - 현재 실행중인 반복문이나, switch문의 실행을 중단하고자 할 때 사용을 합니다.
		/// 
		int i = 10;

		while (true)
		{
			--i;
			Console.WriteLine("i = " + i);
			if(i == 5)
			{
				Console.WriteLine("i의 값은 5입니다.");
				Console.WriteLine("반복문을 중단합니다.");

				// 현재 실행중인 반복문을 중단합니다.
				break;
			}
		}

	}

}
