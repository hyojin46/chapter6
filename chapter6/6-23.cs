//using System;
//using System.Threading;//스레드 네임스페이스 필수
//class SchedulerApp
//{
//    static int interval;
//    static void ThreadBody() //스레드 메소드 작성
//    {
//        Thread myself = Thread.CurrentThread; // 현재 스레드 반환
//        Console.WriteLine("Starting Thread : " + myself.Name); // 스레드 이름
//        for (int i = 1; i <= 3 * interval; i++)
//        {
//            if (i % interval == 0)
//                Console.WriteLine(myself.Name + " : " + i);
//        }
//        Console.WriteLine("Ending Thread : " + myself.Name);
//    }
//    public static void Main()
//    {
//        Console.Write("Interval value : ");
//        interval = int.Parse(Console.ReadLine()); //inteval에 키보드로 값을 입력받음
//        Thread.CurrentThread.Name = "Main Thread"; // 스레드 이름 지정
//                                                   //Thread.CurrentThread.Priority = ThreadPriority.Highest;
//        Thread worker = new Thread(new ThreadStart(ThreadBody)); // 델리게이트에 스레드 메소드 연결 및 스레드 객체 생성
//        worker.Name = "Worker Thread"; // 스레드 값 초기화
//        worker.Start(); //스레드 실행
//        ThreadBody(); // Main Thread에서 ThreadBody() 수행
//    }
//}