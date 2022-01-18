using System;
using System.Runtime.InteropServices;

public class SampleClass
{
	private int Var1;

	// 프로퍼티 Var1의 set 접근자를 클래스 내부에서만 사용할 수 있도록 합니다.
	public int var1
	{
		get { return Var1; }
		private set { Var1 = value; }
	}

	// 읽기 전용 프로퍼티
	private int Var2;
	public int var2
	{
		get { return Var2; }
	}

	// 쓰기 전용 프로퍼티
	private int Var3;
	public int var3
	{
		set { Var3 = value; }
	}
}