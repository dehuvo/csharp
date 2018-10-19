using System;

class Program {
  static void Main(string[] args) {
    Console.Write("수를 넣으시오: ");
    int num = int.Parse(Console.ReadLine());
    int sum = 0;
    for (int i = 2; i <= num; i++) {
      if (isPrime(i)) {
        sum += i;
      }
    }
    Console.WriteLine("{0}까지 소수의 합은 {1}입니다.", num, sum);
  }

  static bool isPrime(int n) {
    int m = (int)Math.Sqrt(n);
    for (int i = 2; i <= m; i++) {
      if (n % i == 0) return false;
    }
    return 1 < n;
  }
}