//using System;
//using System.Threading; //스레드 네임스페이스
//class ThreadProperty
//{
//    public void ThreadBody() //스레드 메소드(인스턴스 메소드)
//    {
//        Thread myself = Thread.CurrentThread; // 실행중인 자신의 스레드 객체 반환
//        Monitor.Enter(this); // 스레드 시작지점
//        for (int i = 1; i <= 3; i++)
//        {
//            Console.WriteLine("{0} is activated => { 1}", myself.Name, i); // 스레드 이름
//            Thread.Sleep(1000); // 1초 지연
//        }
//    Monitor.Exit(this); //스레드 종료지점
//    }
//}
//class ThreadPropertyApp
//{
//    public static void Main()
//    {
//        ThreadProperty obj = new ThreadProperty(); //스레드 메소드가 포함된 클래스 객체 생성
//        ThreadStart ts = new ThreadStart(obj.ThreadBody); //델리게이트에 스레드메소드 연결
//        Thread t1 = new Thread(ts); //스레드 클래스 객체 생성
//        Thread t2 = new Thread(ts);
//        t1.Name = "Apple"; t2.Name = "Orange";
//        t1.Start(); t2.Start();
//    }
//}