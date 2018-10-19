using System;

namespace Akadia.NoDelegate {
  public class MyClass {
    public void Process() {
      Console.WriteLine("Process() begin");
      Console.WriteLine("Process() end");
    }
  }

  public class Test {
    static void Main(string[] args) {
      Action process = new MyClass().Process;
      process();
    }
  }
}