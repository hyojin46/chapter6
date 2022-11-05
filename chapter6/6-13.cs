//using System;
//// 사용자 정의 예외클래스 정의
//class UserExceptionOne : ApplicationException { }
//class UserExceptionTwo : ApplicationException { }
//class ExceptionHandlerApp
//{
//    static void method(int i) // 사용자 정의 예외 발생 메소드
//    {
//        if (i == 1) throw new UserExceptionOne();
//        else throw new UserExceptionTwo();
//    }
//    public static void Main()
//    {
//        try //예외발생 검사
//        {
//            Console.WriteLine("Here: 1");
//            method(2); //else문 실행
//            Console.WriteLine("Here: 2");
//        }
//        catch (UserExceptionOne o) //예외 불일치
//        {
//            Console.WriteLine("UserExceptionOne is occurred !!!");
//        }
//        catch (UserExceptionTwo t) //예외처리
//        {
//            Console.WriteLine("UserExceptionTwo is occurred !!!");
//        }
//        Console.WriteLine("Here: 3");
//    }
//}