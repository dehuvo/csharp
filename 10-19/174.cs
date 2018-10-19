using System;
using System.Linq;

class OnjProfile {
  public string Name { get; set; }
  public string Url { get; set; }
  public int[] Num { get; set; }
}

class Onj {
  static void Main() {
    OnjProfile[] onjProfile = {
      new OnjProfile() {Name="ONJSYSTEM", Url="onjsystems.co.kr", Num=new int[] {5919, 4790}},
      new OnjProfile() {Name="오라클자바커뮤니티실무학원", Url="onjprogramming.co.kr", Num=new int[] {8888, 9999}},
      new OnjProfile() {Name="오라클자바커뮤니티", Url="oraclejavanew.kr", Num=new int[] {1111, 2222}}
    };
    var onjs = from onj in onjProfile
               from num in onj.Num
              where num > 1111
            orderby num
             select new { onj.Name, Lowest = num };
    foreach (var o in onjs) {
      Console.WriteLine("{0}, {1}", o.Name, o.Lowest);
    }
  }
}