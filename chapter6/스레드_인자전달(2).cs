//using System; // 스레드를 시작하는 측에서 여러개의 인자를 전달하는 방법
//using System.Threading;
//namespace Thread_parameter_passing_2
//{
//    class ThreadParam // 전달할 수만큼 필드를 포함한 클래스
//    {
//        public int Value1;
//        public int Value2;
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Thread t = new Thread(threadFunc); //스레드 객체 생성
//            ThreadParam param = new ThreadParam(); //여러 객체를 담을 객체 생성
//            param.Value1 = 10; //값을 담는다
//            param.Value2 = 20; //값을 담는다
//            t.Start(param); // start() 메소드 인자에 값을 담은 객체를 전달
//        }
//        static void threadFunc(object initialValue) //업캐스팅
//        {
//            ThreadParam value = (ThreadParam)initialValue; // 다운 캐스팅
//            Console.WriteLine("{0}, {1}", value.Value1, value.Value2);
//        }
//    }
//}