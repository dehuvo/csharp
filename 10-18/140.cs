using System;
public class Delegate1 {
  private delegate int OnjSum(int i, int j); //1. 선언
  public static void Main(string[] args) {
    OnjSum myMethod = new OnjSum(Delegate1.Sum);
    Console.WriteLine("myMethod : {0}", myMethod(10, 30));
    OnjSum myMethod1 = new OnjSum(Sum);
    Console.WriteLine("myMethod1 : {0}", myMethod1(10, 30));

    Func<int, int, int> f1 = new Func<int, int, int>(Sum);
    Console.WriteLine("f1 : {0}", f1(10, 30));

    Func<int, int, int> f2 = Sum;
    Console.WriteLine("f2 : {0}", f2(10, 30));

    Func<int, int, int> f3 = new Delegate1().Add;
    Console.WriteLine("f3 : {0}", f2(10, 30));

    Action<int, int> a1 = new Delegate1().printSum;
    a1(10, 30);

    Action<int, int> a2 = delegate(int i, int j) {
      Console.WriteLine(i + j);
    };
    a2(10, 30);

    Action<int, int> a3 = (i, j) => { Console.WriteLine(i + j); };
    a3(10, 30);

    Func<int, int, int> f4 = (i, j) => i + j;
    Console.WriteLine("f4 : {0}", f4(10, 30)); 
  }
  static int Sum(int i, int j) {
    return i + j;
  }
  int Add(int i, int j) {
    return i + j;
  }

  void printSum(int i, int j) {
    Console.WriteLine(i + j);
  }
}