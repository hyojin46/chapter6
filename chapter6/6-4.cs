//using System;
//class GenericType<T> where T : SystemException //형 매개변수 T는 SystemException의 파생클래스여야함
//{
//    private T value;
//    public GenericType(T v) { value = v; } //생성자
//    override public String ToString() //ToString()메소드를 실매개변수의 자료형을 출력하는 메소드로 재정의 
//    {
//        return "Type is " + value.GetType();
//    }
//}
//public class BoundedGenericApp
//{
//    public static void Main()
//    {
//        GenericType<NullReferenceException> gNullEx =
//        new GenericType<NullReferenceException>(new NullReferenceException());
//        GenericType<IndexOutOfRangeException> gIndexEx =
//        new GenericType<IndexOutOfRangeException>(new IndexOutOfRangeException());
//        // GenericType<String> gString = new GenericType<String>("Error"); //에러 : String형은 SystemException의 파생클래스가 아니기 때문
//        Console.WriteLine(gNullEx.ToString());
//        Console.WriteLine(gIndexEx.ToString());
//    }
//}