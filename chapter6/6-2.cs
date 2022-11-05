//using System;

//interface IGenericInterface<T> //제네릭 인터페이스
//{
//    void SetValue(T x);
//    string GetValueType();
//}
//class GenericClass<T> : IGenericInterface<T> //인터페이스를 상속한 클래스
//{
//    private T value; //제네릭형 필드
//    public void SetValue(T x) //인터페이스의 메소드 구현
//    {
//        value = x;
//    }
//    public String GetValueType() //인터페이스의 메소드 구현
//    {
//        return value.GetType().ToString();//value의 자료형을 문자열형으로 반환
//    }
//}
//public class GenericInterfaceApp
//{
//    public static void Main()
//    {
//        GenericClass<Int32> gInteger = new GenericClass<Int32>();
//        GenericClass<String> gString = new GenericClass<String>();
//        gInteger.SetValue(10); //value =10
//        gString.SetValue("Text"); //value ="Text"
//        Console.WriteLine(gInteger.GetValueType()); // Int32출력
//        Console.WriteLine(gString.GetValueType()); // String출력
//    }
//}