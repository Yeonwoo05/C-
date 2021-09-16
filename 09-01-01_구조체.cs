using System;

// 구조체란?
// - 클래스처럼 복합데이터 형식이라는 점에서는 비스하지만, 참조형식이 아닌 값 형식입니다.
// - struct 키워드로 구조체를 선언을 합니다.
// - 기본접근제한자가 클래스와 동일하게 private으로 설정됩니다.
// - 대입연산자로 복사를 진행할때 얕은 복사가 아닌 깊은 복사가 일어납니다.
// - 생성자를 호출하는 것이 아니라면 new 키워드를 사용하지 않아도 됩니다.
// - 클래스와 다르게 필드를 정의할 수 없습니다.
// - 클래스처럼 매개 변수가 존재하지 않는 생성자를 사용할 수 없습니다.
//   생성자를 사용한다면 생성자 내부에서 모든 필드에 대한 초기화가 진행되어야 합니다.

public partial struct Point
{
	public double x;
	public double y;
}
public partial struct Point
{
	// 구조체의 생성자, 메서드도 오버로딩이 가능합니다.
	// - 생성자는 무조건 매개변수가 있어야 하며, 생성자 내부에 필드를 모두 초기화 시켜야 합니다.
	// - 구조체는 생성자를 명시적으로 구현해도 기본 생성자를 제공합니다.
	public Point(double x, double y)
	{
		this.x = x;
		this.y = y;
	}
	public Point(double value)
	{
		this.x = this.y = value;
	}
	public void SetPoint(Point point)
	{
		this = point;
	}
	public void SetPoint(double x, double y)
	{
		this.x = x;
		this.y = y;
	}
}
public static class PointEx
{
	public static double Distance(this Point point, Point otherPoint)
	{
		double distance = Math.Sqrt(
			Math.Pow((otherPoint.x - point.x), 2) +
			Math.Pow((otherPoint.y - point.y), 2));
		return distance;
	}
}

class _01_구조체
{
	private static void Main() { new _01_구조체().Entry(); }
	private void Entry()
	{
		// 구조체의 기본 생성자를 호출 한다면 모든 필드는 기본값이 들어갑니다.
		Point MyLocation = new Point();

		// MyLocation의 x, y를 설정
		MyLocation.SetPoint(1.0, 1.0);

		//  생성자를 호출하지 않는다면 직접 필드를 초기화 해야 합니다.
		Point yourLocation;
		yourLocation.x = 10.0;
		yourLocation.y = 10.0;

		double distance = MyLocation.Distance(yourLocation);
		Console.WriteLine("거리 : " + distance);
	}
}
