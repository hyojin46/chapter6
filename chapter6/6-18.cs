//using System;
//using System.Threading; // 네임스페이스 반드시 포함 !!!
//class SimpleThreadApp
//{
//    static void ThreadBody() //1. 스레드 메소드 작성
//    {
//        for (int i = 0; i < 5; i++)
//        {
//            Console.WriteLine(DateTime.Now.Second + " : " + i);
//            Thread.Sleep(1000); // 1초 동안 스레드 실행을 멈추고 대기 상태
//        }
//    }
//    public static void Main()
//    {
//        ThreadStart ts = new ThreadStart(ThreadBody); //2. 델리게이트객체에 스레드 메소드 연결
//        Thread t = new Thread(ts); // 스레드 클래스 객체 생성
//        Console.WriteLine("*** Start of Main");
//        t.Start(); // 클래스객체를 통한 스레드 실행 -> 5번째줄 실행
//        Console.WriteLine("*** End of Main");
//    }
//}