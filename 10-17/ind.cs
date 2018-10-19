using System;
using System.Collections;

class DayCollection {
  string[] days = { "일", "월", "화", "수", "목", "금", "토" };
  // This method finds the day or returns -1

  private int GetDay(string testDay) {
    for (int j = 0; j < days.Length; j++) {
      if (days[j] == testDay) { return j; }
    }
    return 999;
  }

  public int this[string day] {
    get { return (GetDay(day)); }
  }
}

class Program {
  static void Main(string[] args) {
    DayCollection week = new DayCollection();
    System.Console.WriteLine(week["일"]);
    System.Console.WriteLine(week["Made-up Day"]);
  }
}