using System;

class Program {
  static void Main() {
    int number;
    do {
      Console.Write("입력숫자: ");
    } while (!int.TryParse(Console.ReadLine(), out number));
    string label = number + "까지의 숫자";
    string series = label + ":";
    int sum = 0;
    for (int i = 1; i <= number; i++) {
      sum += i;
      series += " " + i;
    }
    Console.WriteLine(series);
    Console.WriteLine(label + " 합은: " + sum);
  }
}
