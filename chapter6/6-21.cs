//using System;
//using System.Threading;//스레드 네임스페이스 필수
//class ThreadJoin
//{
//    public int start;
//    public int perfectNumber;
//    public void ThreadBody() //스레드메소드 작성 (인스턴스 메소드)
//    {
//        int sum;
//        for (int i = start; ; i++)
//        {
//            sum = 0;
//            for (int j = 1; j <= i / 2; j++)
//                if (i % j == 0) sum += j; // 약수 합
//            if (i == sum) // 약수의 합과 자신의수가 같은 경우
//            {
//                perfectNumber = i; // perfectNumber(완전수)에 자신의 값을 저장
//                break; //(10~20)줄의 반복문 종료 
//            }
//        }
//    }
//}
//class ThreadJoinApp
//{
//    public static void Main()
//    {
//        ThreadJoin obj = new ThreadJoin(); // 스레드 메소드가 있는 클래스 객체를 생성
//        ThreadStart ts = new ThreadStart(obj.ThreadBody); // 델리게이트객체에 스레드메소드 연결
//        Thread t = new Thread(ts); // 스레드 클래스 객체 생성
//        Console.Write("Enter a number : ");
//        obj.start = int.Parse(Console.ReadLine()); // 필드(start) 초기화
//        t.Start(); // 스레드 실행
//        t.Join(); // 스레드 종료까지 대기
//        Console.WriteLine("The perfect number over {0} is {1}.",
//        obj.start, obj.perfectNumber);
//    }
//}