//#define CSHARP //전처리기 지시어를 이용하여 명칭을 정의
//using System;
//using System.Diagnostics;//conditional attirbute를 사용하기 위한 네임스페이스 필요
//class ConditionalAttrApp
//{
//    [Conditional("CSHARP")] // 정의된 명칭이므로 다음 메소드 실행
//    public static void CsharpMethod()
//    {
//        Console.WriteLine("In the CSharp Method ...");
//    }
//    [Conditional("JAVA")] //정의되지 않은 명칭이므로 다음 메소드 실행하지 않음
//    public static void JavaMethod()
//    {
//        Console.WriteLine("In the Java Method ...");
//    }
//    public static void Main()
//    {
//        ConditionalAttrApp.CsharpMethod();
//        ConditionalAttrApp.JavaMethod();
//    }
//}
