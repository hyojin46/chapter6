//using System;
//class GenericMethodApp //non-제네릭 클래스
//{
//    static void Swap<DataType>(ref DataType x, ref DataType y) //제네릭 메소드
//    {
//        DataType temp;
//        temp = x; x = y; y = temp; //x와 y의 값을 exchange
//    }
//    public static void Main()
//    {
//        int a = 1, b = 2; double c = 1.5, d = 2.5;
//        Console.WriteLine("Before: a = {0}, b = {1}", a, b);
//        Swap<int>(ref a, ref b); // 정수형 변수로 호출, ref(주소참조)
//        Console.WriteLine(" After: a = {0}, b = {1}", a, b);
//        Console.WriteLine("Before: c = {0}, d = {1}", c, d);
//        Swap<double>(ref c, ref d); // 실수형 변수로 호출
//        Console.WriteLine(" After: c = {0}, d = {1}", c, d);
//    }
//}