using System;
class _02_생성자종료자
{
	int number = 10;

	static void Main() { new _02_생성자종료자().Entry(); }

	void Entry()
	{
		Console.WriteLine("Entry() 실행되었습니다.");

		number = 100;
		Console.WriteLine("number = " + number);
	}
}