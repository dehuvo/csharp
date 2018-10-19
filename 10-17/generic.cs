using System;

class Test {
  static void Main() {
    Console.WriteLine(Sum(1, 2));
    Console.WriteLine(Sum(1.1, 2.2));

    SumTest<double> s = new SumTest<double>();
    Console.WriteLine(s.Sum(1.1, 2.2));
  }

  static T Sum<T>(T a, T b) {
    return (dynamic) a + (dynamic) b;
  }
}

class SumTest<T> {
  public T Sum(T a, T b) {
    return (dynamic) a + (dynamic) b;
  }
}