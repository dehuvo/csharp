using System;

class Program {
  delegate int Sum(int[] arg);
  static void Main() {
    Sum sumdeli = arg => {
      int mySum = 0;
      foreach (int i in arg) {
        mySum += i;
      }
      return mySum;
    };

    int[] arg1 = new int[] { 1, 2, 3, 4, 5 };
    int sum = sumdeli(arg1);
    Console.WriteLine("1+2+3+4+5=" + sum);

    Func<int[], int> f = arg => {
      int s = 0;
      foreach (int i in arg) {
        s += i;
      }
      return s;
    };
    Console.WriteLine("1+2+3+4+5=" + f(arg1));
  }
}