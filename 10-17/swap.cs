using System;

class Program {
  static void Swap(ref int a, ref int b) {
    int tmp = a; a = b; b = tmp;
  }
  static void Swap(int a, int b, out int c, out int d) {
    c = a;
    d = b;
  }

  static void Main(string[] args) {
    int a = 10; int b = 20;
    Console.WriteLine("a={0}, b={1}", a, b);
    Swap(ref a, ref b);
    Console.WriteLine("a={0}, b={1}", a, b);
    Swap(a, b, out b, out a);
    Console.WriteLine("a={0}, b={1}", a, b);
  }
}