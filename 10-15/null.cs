using System;

class LogicalAnd {
  static void Main(string[] args) {
    object a = null;
    object b = "abc";
    Console.WriteLine(a ?? b);

    a = "xyz";
    Console.WriteLine(a ?? b);
    Console.WriteLine(b ?? a);

    int? aa = 30;
    int bb = 0;

    if (aa.HasValue) {
      bb = aa.Value;
    }

    bb = aa ?? 0;

    Console.WriteLine(Method1() && Method2());
    Console.WriteLine(Method1() & Method2());


  }

  static bool Method1() {
    Console.WriteLine("메소드1...");
    return false;
  }

  static bool Method2() {
    Console.WriteLine("메소드2...");
    return true;
  }
}
