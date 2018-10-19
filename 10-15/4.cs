using System;

class Program {
  static void Main() {
    int dan;
    do {
      Console.Write("출력을 원하는 구구단 단수: ");
    } while (!int.TryParse(Console.ReadLine(), out dan));
    for (int i = 1; i <= 9; i++) {
      for (int j = 1; j <= dan; j++) {
        int k = i * j;
        Console.Write(j + "x" + i + " = " + k);
        Console.Write(j < dan ? ", " + (k < 10 ? " " : "") : "\n");
      }
    }
  }
}
