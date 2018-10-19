using System;

namespace ConsoleApplication17 {

  class Program {
    static void Main(string[] args) {
      //----4행2열
      int[,] twoDim = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
      for (int i = 0; i < twoDim.GetLength(0); i++) {
        for (int j = 0; j < twoDim.GetLength(1); j++) {
          Console.Write(twoDim[i, j]);
        }
      }
      Console.WriteLine();

      foreach (int i in twoDim) {
        Console.Write(i);
      }
      Console.WriteLine();
    }
  }
}