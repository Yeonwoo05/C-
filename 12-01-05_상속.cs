using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 영희네 집 꽃밭에는 장미(Rose)와 튤립(Tulip) 이 심어져 있습니다.
// 장미와 튤립 클래스를 작성하고, 다음과 같은 결과를 출력해보세요.

/// - 이 꽃들은 'Flower'라는 클래스를 상속받습니다.
/// - 'Flower' z클래스는 protected 접근제한자의 "꽃 이름", "가격" 필드를 가집니다.
/// - Entry() 메서드 Rose, Tulip을 동적 할당 한 뒤 두 꽃의 이름과 가격을 출력
/// - 필요한 변수나 함수는 추가해도 됩니다.

/// 꽃의 이름 : 장미
/// 장미의 가격 : 1000원
/// 
/// 꽃의 이름 : 튤립
/// 튤립의 가격 : 1200원

public class Flower
{
	// 꽃 이름
	protected string FlowerName;

	protected int Cost;

	protected Flower(string flowerName, int cost)
	{
		FlowerName = flowerName;
		Cost = cost;
	}
	// 꽃의 정보 메서드
	public void PrintInfo()
	{
		Console.WriteLine();
		Console.WriteLine("꽃의 이름 : " + FlowerName);
		Console.WriteLine(FlowerName + "의 가격 : " + Cost + "원");
	}
}
public sealed class Rose : Flower
{
	public Rose(string flowerName, int cost) : base(flowerName, cost) { }
}
public sealed class Tulip : Flower
{
	public Tulip(string flowerName, int cost) : base(flowerName, cost) { }
}
class _05_상속
{
	private static void Main() { new _05_상속().Entry(); }
	private void Entry()
	{
		new Rose("장미", 1000).PrintInfo();
		new Tulip("튤립", 1200).PrintInfo();
	}
}