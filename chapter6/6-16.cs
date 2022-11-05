//using System;
//class PropagateApp
//{
//    void Orange()
//    {
//        int i = 25, j = 0;
//        i = i / j; //4. 시스템 예외발생 (Divide-by-Zero Exception)
//        Console.WriteLine("End of Orange method"); //실행 x
//    }
//    void Apple()
//    {
//        Orange(); //3. Orange메소드 호출
//        Console.WriteLine("End of Apple method");//실행 x
//    }
//    public static void Main()
//    {
//        PropagateApp p = new PropagateApp();
//        try //1. 예외발생검사
//        {
//            p.Apple(); //2. Apple메소드 호출
//        }
//        catch (ArithmeticException) //5. 예외처리
//        {
//            Console.WriteLine("ArithmeticException is processed"); //실행 o
//        }
//        Console.WriteLine("End of Main"); //실행 o
//    }
//}