using System;

class Sort {
  static void Main() {
    Console.WriteLine("쉼표(,)로 구분하여 수열을 넣으시오: ");
    string[] strings = Console.ReadLine().Split(',');
    int[] a = Array.ConvertAll(strings, s => int.Parse(s));
    
    int[] b = (int[]) a.Clone();
    print(b, "정렬 전");

    bubbleSort(a);
    print(a, "버블 정렬");

    selectionSort(b);
    print(b, "선택 정렬");
  }

  static void print(int[] array, string label) {
    foreach (int i in array) {
      Console.Write(i + " ");
    }
    Console.WriteLine("-- " + label);
  }

  static void swap(ref int a, ref int b) {
    int a0 = a;
    a = b;
    b = a0;
  }

  static void bubbleSort(int[] array) {
    for (int jLast, i = array.Length - 1; 0 < i; i = jLast) {
      for (int j = jLast = 0; j < i; j++) {
        if (array[j] > array[j + 1]) {
          swap(ref array[j], ref array[j + 1]);
          jLast = j;
        }
      }
    }
  }

  static void selectionSort(int[] array) {
    int length = array.Length;
    for (int i = 0; i < length - 1; i++) {
      int jMin = i;
      for (int j = i + 1; j < length; j++) {
        if (array[jMin] > array[j]) {
          jMin = j;
        }
      }
      if (jMin != i) {
        swap(ref array[jMin], ref array[i]);
      }
    }
  }
}