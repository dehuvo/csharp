using System;

class Program {

  static void Main() {
    // Write array from Method.
    Console.WriteLine(string.Join(" ", Method()));
  }

  /// <summary>
  /// Return an array.
  /// </summary>
  static string[] Method() {
    string[] array = new string[2];
    array[0] = "THANK";
    array[1] = "YOU";
    return array;
  }
}