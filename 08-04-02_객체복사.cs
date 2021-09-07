using System;

class SampleClass
{
	public int A = 0;
	public int B = 0;

	// SampleClass에 대한 깊은 복사를 수행하는 메서드
	public SampleClass DeepCopy()
	{
		SampleClass copy = new SampleClass();
		copy.A = A;
		copy.B = B;

		return copy;
	}
	public void PrintField()
	{
		Console.WriteLine("A = " + A);
		Console.WriteLine("B = " + B);
	}
}

class _02_객체복사
{
	static void Main() { new _02_객체복사().Entry(); }
	void Entry()
	{
		SampleClass sample1 = new SampleClass();
		SampleClass sample2 = sample1.DeepCopy();

		sample1.A = 10;
		sample1.B = 100;

		sample2.A = 20;
		sample2.B = 200;

		sample1.PrintField();
		Console.WriteLine();
		sample2.PrintField();
	}
}
