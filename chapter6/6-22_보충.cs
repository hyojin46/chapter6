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
//        Console.WriteLine("Current Priority : " + t.Priority); //우선순위: Normal
//        ++t.Priority; //스레드 우선순위 증가
//        Console.WriteLine("Higher Priority : " + t.Priority); //우선순위: AboveNormal
//        --t.Priority; //스레드 우선순위 감소
//        --t.Priority;
//        Console.WriteLine("Lower Priority : " + t.Priority); //우선순위: BelowNormal
//        --t.Priority; //스레드 우선순위 감소
//        Console.WriteLine("even more low : " + t.Priority); //우선순위: Lowest
//    }
//}