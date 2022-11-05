//using System;
//class MyException : ApplicationException
//{
//    public int value;
//    public MyException() { } // 생성자
//    public MyException(string msg, int i) : base(msg)
//    { // 생성자
//        value = i;
//    }
//}
//class MsgExceptionApp
//{
//    static void F(int k)
//    {
//        if (k < 70 || k > 100) // 2. 예외처리 x
//            throw new MyException();
//    }
//    static void G(int k)
//    {
//        if (k > 200) //4. 예외발생
//            throw new MyException("Too Many", k); //5. 명시적 예외처리발생 -> 39번째줄로 이동
//        if (k < 50)
//            throw new MyException("Too Less", k);
//    }
//    public static void Main()
//    {
//        try
//        {
//            F(50); //1. 13번째줄로 이동
//        }
//        catch (MyException e)
//        {
//            Console.WriteLine(e.StackTrace);
//        }
//        try
//        {
//            G(250); // 3. 18번째줄로 이동
//        }
//        catch (MyException e) //6. 예외처리기 발생
//        {
//            Console.WriteLine(e.Message); // Message: 에러의 상황을 묘사하는 메세지를 얻는데 사용하는 속성
//            Console.WriteLine(e.StackTrace); //StackTrace: 표준에러스트림으로 출력하는 기능
//            Console.WriteLine("Data value is " + e.value + ".");
//        }
//    }
//}