using System;

class Program {
  static void Main() {
    for (int i = 1; i <= 5; i += 2) {
      for (int j = 0; j < i; j++) {
        Console.Write("*");
      }
      Console.WriteLine();
    }
  }
}