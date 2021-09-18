using System;
class _02_난수
{
	private static void Main()
	{
		// 기본 퍼센트
		int per;

		while (true)
		{
			Console.Write("1 ~ 100 사이의 값으로 확률을 설정하세요 : ");
			per = int.Parse(Console.ReadLine());
			// 예외처리
			if (0 < per && per <= 100) break;
			else
			{
				// 콘솔창의 화면을 지웁니다.
				Console.Clear();
				// 오류 메시지 전송
				Console.WriteLine("!오류!");
				Console.WriteLine("1 ~ 100 사이의 값으로 입력해주세요.");
				System.Threading.Thread.Sleep(1000);
				Console.Clear();
			}
			Console.WriteLine("확률이 " + per + "%로 설정되었습니다.");
			System.Threading.Thread.Sleep(500);
			Console.Clear();

			for (int i = 0; i < 3; i++)
			{
				Console.Write(" .");
				System.Threading.Thread.Sleep(200);
			}
			int pick = new Random().Next(1, 101);
			Console.Clear();

			// 확률값 이하라면 성공
			if (pick <= per) Console.WriteLine("성공이에열");
			// 아니라면 실패
			else Console.WriteLine("실패에열");
		}
	}
}