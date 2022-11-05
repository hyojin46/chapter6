//using System;
//class UserErrException : ApplicationException //예외클래스 정의
//{
//    public UserErrException(string s) : base(s) { } // 생성자
//    // 자식클래스의 객체 s에 담아 부모클래스의 생성자 호출
//}
//class UserException
//{
//    public static void Main()
//    {
//        try
//        {
//            throw new UserErrException("throw a exception with a message");
//            // 명시적 예외발생문 
//        }
//        catch (UserErrException e) //예외처리기
//        {
//            Console.WriteLine(e.Message); //Message프로퍼티의 get접근자 호출
//        }
//    }
//}