using System;

class EventPublisher {
  public delegate void MyEventHandler(); //이벤트처리를위한델리게이트정의
  public event MyEventHandler MyEvent; //이벤트 정의
  public void Do() {
    MyEvent?.Invoke();
  }
}

class Subscriber {
  static void Main(string[] args) {
    EventPublisher p = new EventPublisher();
    p.MyEvent += new EventPublisher.MyEventHandler(doAction);
    p.Do();
  }

  static void doAction() {
    Console.WriteLine("MyEvent 라는 이벤트 발생...");
  }
}