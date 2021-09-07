using System;

class SampleClass
{
	public int A = 0;
}
class _01_객체복사
{
	static void Main() { new _01_객체복사().Entry(); }
	void Entry()
	{
		// SampleClas형식의 객체를 힙에 동적할당 해서
		// stack의 sample1이 참조하도록 합니다.
		SampleClass sample1 = new SampleClass();
		SampleClass sample2 = sample1;

		// > Sample1 이 참조하는 객체의 A의 값을 10으로 만듭니다.
		sample1.A = 10;

		Console.WriteLine("Sample1.A = " + sample1.A);
		sample2.A = 100;
		Console.WriteLine("Sample2.A = " + sample2.A);
		Console.WriteLine("Sample1.A = " + sample1.A);

		// 이렇게 두개 결과값이 모두 100이 되었는가?
		// - 클래스는 참조 형식이기 때문에 '=' 대입연산자로 대입을 했을 경우
		// 힙에 있는 데이터가 복사되는것이 아닌, 스택에 있는 데이터가 복사가 되기
		// 때문에 값복사가 아닌 객체 참조가 일어납니다.

		// - 값 복사가 아닌 참조만 살짝 복사되는것을
		// 얕은 복사라고 합니다./
		// 반대로 힙에 있는 메모리까지 복사하는 것을 깊은 복사라고 합니다.

	}
}