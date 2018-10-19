using System;

namespace ConsoleApp2 {
  class MyConstants {
    public const double PI = 3.14;
    public const int MY_AGE = 22;
  }

  class Program {
    static void Main(string[] args) {
      double radius = 2;
      double area = MyConstants.PI * radius * radius;
      Console.WriteLine("Age = {1}, Area = {0}", area, MyConstants.MY_AGE);

      const string name = "홍길동";
      Console.WriteLine("name : " + name);
    }
  }
}
