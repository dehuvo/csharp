using System;

struct Emp {
  public int id;
  public string name;
}

class EmpTest {
  public static void Main() {
    Emp e;
    e.id = 1;
    e.name = "1길동";
    Console.WriteLine("사번: {0}", e.id);
    Console.WriteLine("이름: {0}", e.name);

    Emp e1 = new Emp();
    e1.id = 2;
    e1.name = "2길동";
    Console.WriteLine("사번: {0}", e1.id);
    Console.WriteLine("사번: {0}", e1.id);
    Console.WriteLine("이름: {0}", e1.name);
  }
}
