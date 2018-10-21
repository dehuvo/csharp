using System;

class Program {
  static void Main() {
    Console.Write("수를 넣으시오: ");
    int num = int.Parse(Console.ReadLine());
    int sum = 0;
    for (int n = 2; n <= num; n++) {
      if (isPrime(n)) {
        sum += n;
      }
    }
    Console.WriteLine("{0}까지 소수의 합은 {1}입니다.", num, sum);
  }

  static bool isPrime(int n) {
    for (int d = 2; d * d <= n; d++) {
      if (n % d == 0) return false;
    }
    return 1 < n;
  }
}