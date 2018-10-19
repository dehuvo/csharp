using System;

class Program {
  delegate int Calc(int i, int j);

  static void Main(string[] args) {
    Calc c = new Calc(MySum);           // 이름있는 외부 메소드 참조
    Console.WriteLine("1+2={0}", c(1, 2));

    Calc c1 = delegate (int i, int j) { //익명 메소드
      return i + j;
    };
    Console.WriteLine("3+4={0}", c1(3, 4));

    Calc c2 = (int a, int b) => a + b;
    Console.WriteLine("3+4={0}", c2(3, 4));

    Calc c3 = (a, b) => a + b;  // 형식 유추(Type Inference)
    Console.WriteLine("3+4={0}", c3(3, 4));
  }
  
  static int MySum(int i, int j) {
    return i + j;
  }
}
