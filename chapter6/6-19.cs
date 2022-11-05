//using System;
//using System.Threading;
//class ThreadProperty
//{
//    public void ThreadBody() // 스레드메소드 작성
//    {
//        Thread myself = Thread.CurrentThread; // 실행중인 자신의 스레드 객체 반환
//        for (int i = 1; i <= 3; i++)
//        {
//            Console.WriteLine("{0} is activated => {1}", myself.Name, i); // 스레드 이름출력
//            Thread.Sleep(1000); // 1초 지연
//        }
//    }
//}
//class ThreadPropertyApp
//{
//    public static void Main()
//    {
//        ThreadProperty obj = new ThreadProperty(); //스레드를 처리할 메소드를 포함하는 클래스 객체 생성
//        // 클래스객체 생성이유: 스레드메소드가 인스턴스 메소드여서 객체이름으로 참조해야되기 때문이다
//        ThreadStart ts = new ThreadStart(obj.ThreadBody); // 델리게이트객체에 스레드 메소드연결
//        Thread t1 = new Thread(ts); // 클래스 객체를 생성함
//        Thread t2 = new Thread(ts);
//        t1.Name = "Apple"; t2.Name = "Orange"; // 클래스객체를 통한 값지정
//        t1.Start(); t2.Start(); //스레드메소드 호출 -> 5번째줄
//    }
//}