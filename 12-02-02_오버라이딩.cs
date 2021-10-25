using System;

// - 기반클래스 Shape를 만들고
// 오버라이딩 받을 메서드 Draw()만듭니다.
// 자식클래스 Triangle, Ellipse, Rectangle만들고
// 각각 삼각형, 원, 사각형을 그립니다.
// 마지막에 Entry() 메서드에서 배열형태로
// 각각 동적할당 받고 반복문을통해 하나씩 출력을 해주세요.

public class Shape
{
	public virtual void Draw()
	{
		Console.WriteLine("도형을 그립니다.");
	}
}
public class Triangle : Shape
{
	public override void Draw()
	{
		Console.WriteLine("삼각형을 그립니다.");
	}
}
public class Ellipse : Shape
{
	public override void Draw()
	{
		Console.WriteLine("원을 그립니다.");
	}
}

public class Rectangle : Shape
{
	public override void Draw()
	{
		Console.WriteLine("사각형을 그립니다.");
	}
}

class _02_오버라이딩
{
	private static void Main() { new _02_오버라이딩().Entry(); }
	private void Entry()
	{
		Shape[] shapes = { new Shape(), new Triangle(), new Ellipse(), new Rectangle() };
		foreach (var shape in shapes) shape.Draw();
	}
}