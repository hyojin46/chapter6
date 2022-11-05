//using System;
//public class MyAttrAttribute : Attribute // System.Attribute 클래스의 상속
//{ // 속성 클래스
//    public MyAttrAttribute(string message) //생성자
//    { 
//        this.message = message;
//    }
//    private string message; // 필드 : 멤버 변수
//    public string Message //프로퍼티
//    { 
//        get { return message; } //get접근자
//    }
//}
//[MyAttr("This is Attribute test.")] //사용자 정의 애트리뷰트를 사용할때엔 Attribute를 제외한 이름으로 사용
//// new가 없는 객체 상태의 형태
//class MyAttributeApp
//{
//    public static void Main()
//    {
//        Type type = typeof(MyAttributeApp); // 클래스 자체의 type를 반환
//        object[] arr = type.GetCustomAttributes(typeof(MyAttrAttribute), true); //클래스에 적용된 사용자 정의 attribute의 object배열을 반환
//        if (arr.Length == 0)
//            Console.WriteLine("This class has no custom attrs.");
//        else
//        {
//            MyAttrAttribute ma = (MyAttrAttribute)arr[0]; //원래의 Attribute로 형변환(다운캐스팅)
//            Console.WriteLine(ma.Message); //Message프로퍼티의 get접근자 호출
//        }
//    }
//}