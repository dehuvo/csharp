using System;
using System.Linq;

class Program {
  static void Main(string[] args) {
    int[] scores = { 30, 54, 64, 54, 99, 11 };

    int oddScoreSum = scores.Where(n => n % 2 == 1).Sum();
    Console.WriteLine("{0} 홀수의합", oddScoreSum);

    int oddCount = scores.Where(n => n % 2 == 1).Count();
    Console.WriteLine("{0} 홀수의개수", oddCount);

    int Count = scores.Where(n => n > 50).Count();
    Console.WriteLine("{0} 50보다큰수의개수", Count);

    int Max = scores.Max();
    Console.WriteLine("{0} 배열의 최대값", Max);

    int Min = scores.Min();
    Console.WriteLine("{0} 배열의 최소값", Min);
  }
}