using System;

class Program {
  static void Main() {
    int[] array = new int[2]; // Create an array.
    array[0] = 10;
    array[1] = 3021;
    Test(array);
    Test(null); // No output.
    Test(new int[0]); // No output.
  }

  static void Test(int[] array) {
    if (array != null && array.Length > 0) {
      int first = array[0];
      Console.WriteLine(first);
    }
  }
}