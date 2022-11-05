//using System;
//class UserException : ApplicationException { } //ApplicationException클래스를 상속한 사용자 정의 예외클래스 
//class UserExThrowApp
//{
//    static void Method()
//    {
//        throw new UserException(); //명시적 사용자 정의 예외 발생
//    }
//    public static void Main()
//    {
//        try
//        {
//            Console.WriteLine("Here: 1");
//            Method(); // static 메소드
//            Console.WriteLine("Here: 2");
//        }
//        catch (UserException) //예외처리기
//        {
//            Console.WriteLine("User-defined Exception");
//        }
//    }
//}