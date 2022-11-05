//using System;
//class FinallyClauseApp
//{
//    static int count = 0;
//    public static void Main()
//    {
//        while (true)
//        {
//            try //예외발생검사
//            {
//                if (++count == 1) throw new Exception(); //count변수를 증가시킨 후 비교
//                if (count == 3) break;
//                Console.WriteLine(count + ") No exception");
//            }
//            catch (Exception) //예외처리
//            {
//                Console.WriteLine(count + ") Exception thrown");
//            }
//            finally //항상수행
//            {
//                Console.WriteLine(count + ") in finally clause");
//            }
//        } // end while
//        Console.WriteLine("Main program ends");
//    }
//}