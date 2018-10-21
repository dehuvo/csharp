using System;
using System.Threading;
using System.Diagnostics;

class Program {
  public static void Main() {
    Thread[] t = new Thread[10];
    int[] ms = new int[t.Length];

    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
    int n = 0;
    for (int i = 0; i < t.Length; i++) {
      (t[i] = new Thread(() => {
        Thread.Sleep(ms[n++] = new Random().Next(20));
        Console.Write(i + " ");
      })).Start();
    }
    stopwatch.Stop();

    for (int i = 0; i < t.Length; i++) {
      t[i].Join();
    }
    Console.WriteLine();
    foreach (int i in ms) {
      Console.Write(i + " ");
    }
    Console.WriteLine("\n" + stopwatch.Elapsed.TotalMilliseconds);
  }
}