using System;

class Program {
  static void Main(string[] args) {
    if (0 < args.Length) {
      foreach (string arg in args) {
        printBinary(int.Parse(arg));
      }
    } else {
      Console.Write("수를 넣으시오: ");
      printBinary(int.Parse(Console.ReadLine()));
    }
  }

  static void printBinary(int n) {
    Console.WriteLine("{0}\t--> {1}\n{2}\n", n, binary(n), bits(n));
  }

  static string binary(int n) {
    if (n == 0) {
      return "0";
    }
    string sign = "";
    if (n < 0) {
      sign = "-";
      n = -n;
    }
    string s = "";
    for (; n != 0; n /= 2) {
      s = n % 2 + s;
    }
    return sign + s;
  }

  static string bits(int n) {
    string s = "";
    for (uint bit = 0x80000000; bit != 0; bit >>= 1) {
      s += (n & bit) == 0 ? "0" : "1";
    }
    return s;
  }
}