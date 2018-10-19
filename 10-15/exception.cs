using System;

namespace ConsoleApp1 {
  class Program {
    static void Main(string[] args) {
      short a = 10;
      int b = a;
      int c = 50000;
      try {
        short d = checked((short)c);
        Console.WriteLine("Short : {0}", d);
      } catch (Exception e) {
        Console.WriteLine("예외: {0}", e.StackTrace);
      }
    }
  }
}
