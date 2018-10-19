using System;

class Program {
  static void Main() {

    // Loop over array of integers.
    foreach (int id in GetEmployeeIds()) {
      Console.WriteLine(id);
    }

    // Loop over array of integers.
    int[] employees = GetEmployeeIds();
    for (int i = 0; i < employees.Length; i++) {
      Console.WriteLine(employees[i]);
    }
  }

  /// <summary>
  /// Returns an array of integers.
  /// </summary>
  static int[] GetEmployeeIds() {
    int[] employees = new int[5];
    employees[0] = 1;
    employees[1] = 3;
    employees[2] = 5;
    employees[3] = 7;
    employees[4] = 8;
    return employees;
  }
}