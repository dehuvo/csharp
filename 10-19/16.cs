using System;

public delegate void EventHandler();

class Program {
  public static event EventHandler _show;

  static void Main() {
    _show = new EventHandler(Dog)
          + new EventHandler(Cat)
          + new EventHandler(Mouse)
          + new EventHandler(Mouse);
    _show();
  }

  static void Cat() {
    Console.WriteLine("Cat");
  }

  static void Dog() {
    Console.WriteLine("Dog");
  }

  static void Mouse() {
    Console.WriteLine("Mouse");
  }
}
