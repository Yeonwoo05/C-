using System;
class _02_Continue
{
	static void Main()
	{
		int A = 0;

		while(A < 5)
		{
			// > 0.5초를 대기
			// - mainThread를 0.5간 대기
			System.Threading.Thread.Sleep(500);
			/// - System.Threading : 다중 스레드 프로그램을 할 수 있는 클래스와
			///						 인터페이스를 제공하는 네임스페이스
			///	- Thread : 스레드를 만들고 제어하는 클래스
			///	- Sleep(ms) : 지정된 밀리초(ms) 동안 현재 스레드를 일시 중단 합니다.
			///	1000ms -> 1초

			// > A의 값을 출력합니다.
			Console.WriteLine("A = " + A);

			++A;
			//  만약 A의 값이 3이라면
			if (A == 3) continue;

		}
	}
}