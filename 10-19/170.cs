using System;
using System.Collections.Generic;
using System.Linq;

namespace from {
  class Onj {
    static void Main(string[] args) {
      int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
      var onjQuery1 = from n in num
                      where n % 2 == 1
                      orderby n
                      select n;
      foreach (int i in onjQuery1) {
        Console.WriteLine("홀수 : {0}", i);
      }

      IEnumerable<int> onjQuery2 = 
         from n in num
        where n > 3
      orderby n descending
       select n;
      foreach (int i in onjQuery2) {
        Console.WriteLine(i);
      }
    }
  }
}