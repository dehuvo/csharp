using System;

class Program {
  static void Main(string[] args) {
    Func<double, double> f1 = x => Math.Sqrt(x);
    Console.WriteLine("sqrt(25) = {0}", f1(25));

    Func<double, double> f2 = Math.Sqrt;
    Console.WriteLine("sqrt(25) = {0}", f2(25));

    Func<int, int> sum = n => n * (n + 1) / 2;
    Console.WriteLine("sum(10) = {0}", sum(10));
  }
}