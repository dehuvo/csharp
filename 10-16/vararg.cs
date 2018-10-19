using System;

class Program {
  static void Main() {
    Console.WriteLine(Sum());
    Console.WriteLine(Sum(1));
    Console.WriteLine(Sum(1, 2, 3, 4, 5));
    Console.WriteLine(Sum(1, 2, 3));
    Console.WriteLine(Sum2(1, 2));
    Console.WriteLine(Sum2(j : 1, i : 2));
    Console.WriteLine(Sum2(i : 2));
  }

  static int Sum(params int[] numbers) {
    int sum = 0;
    foreach (int n in numbers) {
      sum += n;
    }
    return sum;
  }

  static int Sum2(int i, int j = 0) {
    Console.WriteLine("i = " + i + ", j = " + j);
    return i + j;
  }
}