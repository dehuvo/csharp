using System;
using System.Linq;

class LinqAggregationExam {
  static void Main(string[] args) {
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    //------------------------------------------------------------
    //그룹핑의 기준이 2로 나누어서 나머지가 0이므로
    //나머지가 0인것과 아닌것 2개의 그룹으로 나뉘어 지며
    //각각 그룹핑의 KEY(그룹핑의 기준)를 가진다.
    //조건으로 그룹핑 한다면 key는 true 또는 false
    //------------------------------------------------------------
    var result = numbers.GroupBy(n => n % 2 == 0);
    Console.WriteLine("2로 나누어 떨어지는 것과 아닌것 두개의 그룹으로 나뉨");

    foreach (IGrouping<bool, int> group in result) {
      if (group.Key) {
        Console.WriteLine("2로 나누어 떨어지는 것:");
      } else {
        Console.WriteLine("2로 나누어 떨어지지 않는 것:");
      }
      foreach (int num in group) {
        Console.Write(" " + num);
      }
      Console.WriteLine();
    }
  }
}