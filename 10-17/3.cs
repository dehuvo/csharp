using System;

class A {
  static void Main() {

    // This is a zero-element int array.
    var values1 = new int[] { };
    Console.WriteLine(values1.Length);

    // This is a zero-element int array also.
    var values2 = new int[0];
    Console.WriteLine(values2.Length);
  }
}