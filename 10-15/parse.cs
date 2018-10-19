using System;

class Program {
  static void Main() {
    string s = Console.ReadLine();
    int num = 0; // = int.Parse(s);
    int sum = 0;
    if (int.TryParse(s, out num)) {
      for (int i = 2; i <= num; i += 2) {
        sum += i;
      }
    }
    Console.WriteLine("{0}까지 짝수의 합은 {1}.", num, sum);
  }
}