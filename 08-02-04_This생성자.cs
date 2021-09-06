using System;

// > 생성자의 this
// - 오버로딩 되어있는 자기 자신의 다른 생성자를 가르킵니다.
// - 연산자에서 자기 자신을 가리키는 this를 사용했어요
// - 생성자에도 this() 생성자 안에서만 사용할 수 있다.
//   같은 코드를 중복 작성 하지 않도록 할 때 사용합니다.


	class MyClass
{
	public int A;
	public int B;
	public int C;
	
	// 생성자를 만듭니다.
	public MyClass(int A)
	{
		this.A = A;
		Console.WriteLine("A = " + A);
	}
	public MyClass(int A, int B) : this(A)
	{
		this.B = B;
		Console.WriteLine("B = " + B);
	}
	// 마지막 세번째는 여러분들이 만들어보기
	public MyClass(int A, int B, int C) : this(A, B)
	{
		this.C = C;
		Console.WriteLine("C = " + C);
	}
}

class _04_This생성자
{
	static void Main()
	{
		new MyClass(1, 2);
		Console.WriteLine();
		new MyClass(1, 2, 3);
		Console.WriteLine();
	}

}