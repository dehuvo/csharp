using System;

class Program {
  static void Main() {
    int n;
    
    do {
      Console.Write("수를 넣으시오: ");
    } while (!int.TryParse(Console.ReadLine(), out n));

    Console.WriteLine("넣은 수는 " + (n % 2 == 0 ? "짝" : "홀") + "수입니다.");
  }
}