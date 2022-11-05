//using System;
//class SimpleGeneric<T>
//{
//    private T[] values; // T 자료형의 배열 -> 초기화될 수 없음
//    private int index;
//    public SimpleGeneric(int len) // 생성자
//    {
//        values = new T[len];
//        index = 0;
//    }
//    public void Add(params T[] args) // 매개변수 가변배열 
//    {
//        foreach (T e in args)
//            values[index++] = e; // 삽입 후 index 증가
//    }
//    public void Print()
//    {
//        foreach (T e in values) // foreach반복문을 통한 배열 내 모든 요소를 출력
//            Console.Write(e + " ");
//        Console.WriteLine();
//    }
//}
//public class GenericClassExample
//{
//    public static void Main()
//    {
//        SimpleGeneric<Int32> gInteger = new SimpleGeneric<Int32>(10); //Int32 = int형
//        SimpleGeneric<Double> gDouble = new SimpleGeneric<Double>(10); //Double = double형
//        gInteger.Add(1, 2);
//        gInteger.Add(1, 2, 3, 4, 5, 6, 7);
//        gInteger.Add(0);
//        gInteger.Print();
//        gDouble.Add(10.0, 20.0, 30.0);
//        gDouble.Print();
//    }
//}