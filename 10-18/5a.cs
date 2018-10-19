using System;

namespace Akadia.NoDelegate {

  public delegate void Process();
  
  public class MyClass {
    public void Process() {
      Console.WriteLine("Process() begin");
      Console.WriteLine("Process() end");
    }
  }

  public class Test {
    static void Main(string[] args) {
      Process process = new MyClass().Process;
      process();
    }
  }
}