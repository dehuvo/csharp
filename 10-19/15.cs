using System;
using System.Threading;

class Program {
  public static void Main(string[] args) {
    Thread[] t = new Thread[10];
    for (int tNum = 0; tNum < 10; tNum++) {
      t[tNum] = new Thread(() => {
        Thread.Sleep(new Random().Next(20));
        Console.Write(tNum + " ");
      });
      t[tNum].Start();
    }

    // wait for the threads to finish
    for (int tNum = 0; tNum < 10; tNum++) {
      t[tNum].Join();
    }
    Console.WriteLine("\nPress a key...");
    Console.Read();
  }
}