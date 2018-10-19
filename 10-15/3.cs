using System;

class Program {
  static void Main() {
    const int count = 10;
    int sum = 0;
    for (int i = 1; i <= count; i++) {
      int num;
      do {
        Console.Write("숫자-" + i + ": ");
      } while (!int.TryParse(Console.ReadLine(), out num));
      sum += num;
    }
    Console.WriteLine("합: " + sum);
    Console.WriteLine("평균: " + (double) sum / count);
  }
}