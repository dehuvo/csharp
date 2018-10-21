using System;
using System.Linq;

class Program {
  static void Main() {
    int[] oneToTen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    var evenNumbers = oneToTen.Where(n => n % 2 == 0);
    foreach (int i in evenNumbers) {
      Console.Write("{0} ", i);
    }
    Console.WriteLine();
  }
}