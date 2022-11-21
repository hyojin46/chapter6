//using System;
//using System.Threading;
//namespace Thread_parameter_passing_1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Thread t = new Thread(threadFunc); //스레드로 처리할 메소드 이름
//            t.Start(10); // 스레드를 시작하는 측에서 인자를 전달
//        }
//        static void threadFunc(object initialValue) //object는 모든 자료형 수신 가능
//        {
//            int intValue = (int)initialValue; // 다운캐스팅함
//            Console.WriteLine(intValue); //다운캐스팅한 값을 출력 = 10 
//        }
//    }
//}