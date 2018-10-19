using System;

delegate void OnjDelegate(int a, int b);

class MainApp {
  static void Plus(int a, int b) {
    Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
  }
  static void Minus(int a, int b) {
    Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
  }
  void Multiplication(int a, int b) {
    Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
  }
  void Division(int a, int b) {
    Console.WriteLine("{0} / {1} = {2}", a, b, (double) a / b);
  }

  static void Main() {
    Console.Write("쉼표(,)로 구분하여 두 수를 넣으시오: ");
    string[] strings = Console.ReadLine().Split(',');
    int[] n = Array.ConvertAll(strings, s => int.Parse(s));

    MainApp m = new MainApp();
    OnjDelegate chain1 = (OnjDelegate) Delegate.Combine(
      new OnjDelegate(MainApp.Plus),
      new OnjDelegate(MainApp.Minus),
      new OnjDelegate(m.Multiplication),
      new OnjDelegate(m.Division)
    );
    chain1(n[0], n[1]);
    Console.WriteLine();

    OnjDelegate chain2 = new OnjDelegate(MainApp.Plus)
                       + new OnjDelegate(MainApp.Minus)
                       + new OnjDelegate(m.Multiplication)
                       + new OnjDelegate(m.Division);
    chain2(n[0], n[1]);
  }
}