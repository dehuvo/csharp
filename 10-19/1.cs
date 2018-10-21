using System;

class Program {
  static void Main() {
    Console.WriteLine("쉼표(,)로 구분하여 수열을 넣으시오: ");
    int[] nums = Array.ConvertAll(Console.ReadLine().Split(','), s => int.Parse(s));
    int sum = 0;
    foreach (int n in nums) {
      sum += n;
    }
    Console.WriteLine("합 = " + sum);
  }
}