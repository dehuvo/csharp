using System;

namespace Program {
  class Program {
    static void Main(string[] args) {
      int num, reverse = 0;
      Console.WriteLine("Enter a Number : ");
      num = int.Parse(Console.ReadLine());
      while (num != 0) {
        reverse = reverse * 10 + num % 10;
        num /= 10;
      }
      Console.WriteLine("Reverse of Entered Number is : " + reverse);
      Console.ReadLine();
    }
  }
}