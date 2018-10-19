//#define SOUNDCARD // 이 부분을 지운 후 실행 해 보자
using System;
using System.Diagnostics;
class Test {
  //Conditional Attribute인 경우 지정된 위치지정 파라미터가 정의 되어
  //있을 때 실행이 되는 것이다.
  [Conditional("SOUNDCARD")]
  static void print() { 
    Console.WriteLine("도레미..."); 
  }
  static void Main() {
    print();
  }
}