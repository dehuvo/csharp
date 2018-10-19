using System;
using System.Collections.Generic;
using System.Linq;

class OnjProfile {
  public string Name { get; set; }
  public string Url { get; set; }
  public int Age { get; set; }
}
class Onj {
  static void Main(string[] args) {
    int[] scores = { 70, 99, 59, 88, 81, 97 };
    //최고점수
    int maxScore = (from score in scores select score).Max();
    Console.WriteLine("최고점수 : {0}", maxScore);
    //아래처럼 쿼리식을 분리해도 된다.
    IEnumerable<int> scoreQuery = from score in scores select score;
    int lowScore = scoreQuery.Min();
    Console.WriteLine("최소점수 : {0}", lowScore);

    OnjProfile[] onjProfile = {
      new OnjProfile() { Name="ONJSYSTEM", Url="onjsystems.co.kr", Age=7 },
      new OnjProfile() { Name="오라클자바커뮤니티실무학원", Url="onjprogramming.co.kr", Age=6 },
      new OnjProfile() { Name="오라클자바커뮤니티", Url="oraclejavanew.kr", Age=16 }
    };
    var onjs = from onj in onjProfile
              where onj.Name.Contains("오")
            orderby onj.Age
             select new {
                 Name = onj.Name,
                 Url = onj.Url,
                 Age = onj.Age
             };
    foreach (var o in onjs) {
      Console.WriteLine("{0}, {1}, {2}", o.Name, o.Url, o.Age);
    }
  }
}