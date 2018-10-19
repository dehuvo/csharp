using System;

class Program {
  static void Main() {
    // Declare new int array.
    int[] teams = new int[3];
    teams[0] = 1;
    teams[1] = 2;
    teams[2] = 3;

    // New employee that stores int array reference.
    Employee employee = new Employee(teams);

    // Loop through each int in employee's class.
    foreach (int team in employee.Teams) {
      Console.WriteLine(team);
    }
  }
}

/// <summary>
/// Stores an employee and his teams.
/// </summary>
class Employee {
  /// <summary>
  /// Int array reference at class level.
  /// </summary>
  int[] _teams;

  /// <summary>
  /// Create new employee.
  /// </summary>
  /// <param name="teams">Teams for the employee.</param>
  public Employee(int[] teams) {
    _teams = teams;
  }

  /// <summary>
  /// Get array of teams.
  /// </summary>
  public int[] Teams {
    get {
      return _teams;
    }
  }
}