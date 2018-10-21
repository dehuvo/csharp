using System;

class Program {
  static void Main(string[] args) {
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine("Reverse of the number is {0}.", Reverse(num));
  }

  static int Reverse(int number) {
    int reverse = 0;
    for (; number != 0; number /= 10) {
      reverse = reverse * 10 + number % 10;
    }
    return reverse;
  }
}