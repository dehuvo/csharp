using System;

class Program {
  static void ArrDisplay(params int[][] arr) {
    for (int i = 0; i < arr.Length; i++) {
      foreach (int j in arr[i]) {
        Console.Write(j + " ");
      }
      Console.WriteLine();
    }
    Console.WriteLine("----------");
  }

  static void ArrDisplay(int[,] arr) {
    foreach (int j in arr) {
      Console.Write(j + " ");
    }
    Console.WriteLine("----------");
  }

  static void ArrDisplay(params int[][][] arr) {
    for (int i = 0; i < arr.Length; i++) {
      for (int j = 0; j < arr[i].Length; j++) {
        foreach (int k in arr[i][j]) {
          Console.Write(k + " ");
        }
        Console.WriteLine();
      }
      Console.WriteLine("...");
    }
    Console.WriteLine("----------");    
  }

  static void ArrDisplay(params string[][] arr) {
    for (int i = 0; i < arr.Length; i++) {
      foreach (string j in arr[i]) {
        Console.Write(j + " ");
      }
      Console.WriteLine();
    }
    Console.WriteLine("----------");
  }

  static void Main(string[] args) {
    // 1차원배열 (numbers).
    int[] n1 = new int[3] { 2, 4, 6 }; 
    int[] n2 = new int[] { 2, 4, 6 };
    int[] n3 = { 2, 4, 6 };
    ArrDisplay(n1, n2, n3);
    // 1차원배열 (strings).
    string[] s1 = new string[3] { "onj1", "oraclejava1", "onjoracle1" };
    string[] s2 = new string[] { "onj2", "oraclejava2", "onjoracle2" };
    string[] s3 = { "onj3", "oraclejava3", "onjoracle3" };
    ArrDisplay(s1, s2, s3);
    // 다차원배열
    int[,] n4 = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } }; 
    int[,] n5 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
    int[,] n6 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
    ArrDisplay(n4); 
    ArrDisplay(n5); 
    ArrDisplay(n6);
    // 가변길이 배열
    int[][] n7 = new int[2][] { new int[] { 2, 4, 6 }, new int[] { 1, 3, 5 } };
    int[][] n8 = new int[][] { new int[] { 2, 4, 6 }, new int[] { 1, 3, 5 } };
    int[][] n9 = { new int[] { 2, 4, 6 }, new int[] { 1, 3, 5 } };
    ArrDisplay(n7, n8, n9);
  }
}