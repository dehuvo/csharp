using System;

class Program {
  static void Main(string[] args) {
    if (0 < args.Length) {
      foreach (string arg in args) {
        printBinary(int.Parse(arg));
      }
    } else {
      int n;
      do {
        Console.Write("입력숫자: ");
      } while (!int.TryParse(Console.ReadLine(), out n));
      printBinary(n);
    }
  }

  static void printBinary(int n) {
    for (uint bit = 0x80000000; bit != 0; bit >>= 1) {
      Console.Write((n & bit) == 0 ? "0" : "1");
    }
    Console.WriteLine();

    int[] bin = new int[32];
    int i = 0;

    if (n == 0) {
      bin[i++] = 0;
    } else {
      int a = n;
      if (n < 0) {
        Console.Write("-");
        a = -n;
      }
      for (; a != 0; a /= 2) {
        bin[i++] = a % 2;
      }
    }
    while (0 < i) {
      Console.Write(bin[--i]);
    }
    Console.WriteLine(" ({0})\n", n);
  }
}