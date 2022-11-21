//using System;
//using System.Threading;
//class ThreadPriorityApp
//{
//    static void ThreadBody() //스레드 메소드
//    {
//        Thread.Sleep(1000); //대기시간 1초
//    }
//    public static void Main()
//    {
//        Thread t = new Thread(new ThreadStart(ThreadBody)); // 스레드 델리게이트에 메소드 연결및 스레드 객체 생성
//        t.Start(); //스레드 메소드 실행
//        Console.WriteLine("Current Priority : " + t.Priority);
//        ++t.Priority; //스레드 우선순위 증가
//        Console.WriteLine("Higher Priority : " + t.Priority);
        
//    }
//}