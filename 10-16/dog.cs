using System;

namespace ConsoleApp1 {
  interface Dog {
    string Name { get; set; }
    void jitda();
  }

  public class Poodle : Dog {
    public string Name { get; set; }
    
    public void jitda() {
      Console.WriteLine(Name + " 푸들푸들~");
    }

    public void work() {
      Console.WriteLine(Name + "가 일한다.");
    }
  }

  public class Jindo : Dog {
    public string Name { get; set; }

    public void jitda() {
      Console.WriteLine(Name + " 진도진도~");
    }

    public void run() {
      Console.WriteLine(Name + "가 달린다.");
    }
  }

  class DogManager {
    static void Main(string[] args) {
      Dog p = new Poodle();
      p.Name = "푸들이";
      p.jitda();
      ((Poodle) p).work();
      (p as Poodle).work();
      behave(p);

      Dog j = new Jindo();
      j.Name = "진도이";
      j.jitda();
      ((Jindo) j).run();
      behave(j);
    }
 
    static void behave(Dog d) {
      Console.WriteLine("-----");
      d.jitda();
      if (d is Poodle) {
        (d as Poodle).work();
      } else if (d is Jindo) {
        (d as Jindo).run();
      }
      Console.WriteLine("=====");
    }
  }
}