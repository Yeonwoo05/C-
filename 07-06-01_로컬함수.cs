using System;
// 로컬함수?
/// - 메서드 내부에서 선언되며, 선언된 메서드 내부에서만 사용할 수 있습니다.
/// - 자신이 존재하는 지역에 선언되어있는 변수를 사용할 수 있으며,
/// 클래스 멤버 변수, 메서드를 모두 사용할 수 있습니다.
 
// 로컬 메서드라고 부르지 않는가?
/// - 클래스의 멤버가 아니기 때문에 머서드가 아닌, 함수라고 부릅니다.
class _01_로컬함수
{
    static void Main()
    {
        const string EndLine = "\n";

        void PrintString(string print, bool In = true)
        {
            // 메서드 내부의 로컬 변수를 사용할 수 있도록 만듭니다.
            Console.Write(print + (In ? EndLine : ""));
        }
        PrintString("ㅎㅇ!", false);
        PrintString("재밌는 코딩!", true);
        TestMethod();
    }

}