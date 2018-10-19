using System;

class Program {
  static void Main() {
    Console.WriteLine("쉼표(,)로 구분하여 수열을 넣으시오: ");
    string[] strings = Console.ReadLine().Split(',');
    int[] numbers = Array.ConvertAll(strings, s => int.Parse(s));
    
    int sum = 0;
    foreach (int n in numbers) {
      sum += n;
    }
    Console.WriteLine("합 = " + sum);
  }
}