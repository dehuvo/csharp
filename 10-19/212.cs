using System;
using System.Threading;

class Program {
  static int mysum = 0;

  static void Sum(int[] n) {
    int sum = 0;
    for (int i = n[0]; i <= n[1]; i++) {
      sum += i;
    }
    mysum += sum;
  }

  static void Main(string[] args) {
    Thread[] threads = new Thread[5];
    for (int i = 0; i < threads.Length; i++) {
      int a = i * 10 + 1; 
      (threads[i] = new Thread(() => Sum(new int[] { a, a + 9 }))).Start();
    }
    for (int i = 0; i < threads.Length; i++) {
      threads[i].Join();
    }
    Console.WriteLine(mysum);
  }
}