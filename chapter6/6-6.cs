//using System;

//class ObsoleteAttrApp
//{
//    [Obsolete("경고, Obsolete Method입니다.")] //애트리뷰트 다음에 오는 메소드에만 Obsolete애트리뷰트가 적용
//    public static void OldMethod()
//    {
//        Console.WriteLine("In the Old Method ...");
//    }
//    public static void NormalMethod() //애트리뷰트 적용 x -> 애트리뷰트 상관없이 호출되면 출력
//    {
//        Console.WriteLine("In the Normal Method ...");
//    }
//    public static void Main()
//    {
//        ObsoleteAttrApp.OldMethod(); //초록색줄(경고)의 의미: 가능하면 사용하지 말것
//        ObsoleteAttrApp.NormalMethod();
//    }
//}