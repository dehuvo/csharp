using System;
using System.Runtime.InteropServices;

class TypeCastExample1 {
  static void Main(string[] args) {

    Console.WriteLine("int형 바이트길이 : {0}", sizeof(int));
    Console.WriteLine("typeof(int) : {0}", typeof(int));
    int i = 10;
    Type myType2 = i.GetType();
    Console.WriteLine("i.GetType() : {0}", myType2);
    int j = 99;
    Console.WriteLine("Size of j : {0}", Marshal.SizeOf(j));
  }
}