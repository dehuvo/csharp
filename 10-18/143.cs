using System;
class Program {
  delegate void Deli(string s);
  static void Main() {
    // Specify delegate with Lambda Expression
    Deli d0 = (v) => Console.WriteLine(v);
    d0("aaa");
    //Invoke delegate.
    d0.Invoke("OJC");
    // Specify delegate with new Constructor
    Deli d1 = new Deli(d);
    d1.Invoke("OJC");
    // Specify delegate with method name
    Deli d2 = d;
    d2.Invoke("OJC");
  }
  static void d(string s) {
    Console.WriteLine(s);
  }
}