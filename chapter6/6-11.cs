//using System;
//class SystemrExThrowApp
//{
//    public static void Exp(int ptr)
//    {
//        if (ptr == 0)
//            throw new NullReferenceException(); // 시스템정의 예외
//        // 시스템정의 예외를 명시적발생(예외처리기가 없는경우 디폴트예외처리기 동작)
//    }
//    public static void Main()
//    {
//        int i = 0;
//        // SystemExThrowApp.Exp(i);
//        Exp(i); // 동일 클래스의 static 메소드는 호출 시 클래스명 제외 가능
//    }
//}