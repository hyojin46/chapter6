//using System;
//using System.Threading;//스레드 네임스페이스 필수
//class ThreadState
//{
//    public void ThreadBody() //스레드메소드(인스턴스 메소드)
//    {
//        while (true)
//        {
//            // ... infinite loop ...
//        }
//    }
//}
//class ThreadStateApp
//{
//    public static void Main()
//    {
//        ThreadState obj = new ThreadState(); //스레드메소드가 있는 클래스 객체 생성
//        ThreadStart ts = new ThreadStart(obj.ThreadBody); // 델리게이트 객체에 스레드 메소드 연결
//        Thread t = new Thread(ts); // 스레드 클래스 객체 생성
//        Console.WriteLine("Step 1: " + t.ThreadState);
//        t.Start(); // 해당 스레드 실행
//        Thread.Sleep(100); //대기시간 0.1초
//        Console.WriteLine("Step 2: " + t.ThreadState);
//        t.Suspend(); // 해당 스레드를 대기상태로 만듬
//        Thread.Sleep(100); //대기시간 0.1초
//        Console.WriteLine("Step 3: " + t.ThreadState);
//        t.Resume(); // 해당 스레드를 실행상태로 만듬
//        Thread.Sleep(100); //대기시간 0.1초
//        Console.WriteLine("Step 4: " + t.ThreadState);
//        t.Abort(); // 해당 스레드를 종료시킴
//        Thread.Sleep(100); //대기시간 0.1초
//        Console.WriteLine("Step 5: " + t.ThreadState);
//    }
//}