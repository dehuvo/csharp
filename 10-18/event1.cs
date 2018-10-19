using System;

namespace EventTest {
  delegate void MyDelegate(int i);

  class EventPublisher {
    public event MyDelegate ClapEvent;
    public void Clap(int num) {
      if (num % 2 == 0) {
        ClapEvent(num);
      }
    }
  }

  public class EventSubscriber {
    static void Caller(int num) {
      Console.WriteLine("{0} : 짝~", num);

    }

    static void Main(string[] args) {
      EventPublisher p = new EventPublisher();
      // p.ClapEvent += new MyDelegate(Caller);
      p.ClapEvent += Caller;

      int[] iArr = Array.ConvertAll(Console.ReadLine().Split(','), i => int.Parse(i));
      foreach (int i in iArr) {
        p.Clap(i);
      }
    }
  }
}