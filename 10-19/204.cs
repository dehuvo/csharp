using System;
using System.Threading;

class Program {
  public static Thread sleeperThread;

  public static void Main(string[] args) {
    sleeperThread = new Thread(ThreadToSleep);
    sleeperThread.Start();
    sleeperThread.Interrupt();
  }

  private static void ThreadToSleep() {
    int i = 0;
    while (true) {
      Console.WriteLine("[Sleeper : " + i++ + "]");
      if (i == 9) {
        try {
          Console.WriteLine("i 가 9 가 되어 1 초쉼...");
          Thread.Sleep(1000);
        } catch (ThreadInterruptedException e) {
          Console.WriteLine(e.Message);
          Environment.Exit(0);
        }
      }
    }
  }
}