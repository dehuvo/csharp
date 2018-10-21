using System;

class Program {
  static void Main() {
    Console.Write("수를 넣으시오: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine((n % 2 == 0 ? "짝" : "홀") + "수입니다.");
  }
}