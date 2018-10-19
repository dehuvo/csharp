class A {
  protected A() {}
  ~A() {
    System.Console.WriteLine("A 소멸~");
  }
}

class B : A {
} 

public class Test {
  static void Main() {
    A a = new B();
//    System.GC.Collect();
  }
}