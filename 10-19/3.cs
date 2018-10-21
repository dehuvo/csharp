using System;

class Program {
  static void Main() {
    Console.Write("Enter the First Number : ");
    int num1 = int.Parse(Console.ReadLine());
    Console.Write("Enter the Second Number : ");
    int num2 = int.Parse(Console.ReadLine());
    int temp = num1;
    num1 = num2;
    num2 = temp;
    Console.WriteLine("After Swapping : ");
    Console.WriteLine("First Number : " + num1);
    Console.WriteLine("Second Number : " + num2);
  }
}