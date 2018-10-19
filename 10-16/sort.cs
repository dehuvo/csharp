using System;

class Program {
  static void Main() {
    Console.WriteLine("쉼표(,)로 구분하여 수열을 넣으시오: ");
    string[] strings = Console.ReadLine().Split(',');
    int[] a = Array.ConvertAll(strings, s => int.Parse(s));
    
    int[] b = (int[]) a.Clone();
    print(a);

    bubbleSort(a);
    print(a);

    selectionSort(b);
    print(b);
  }

  static void swap(ref int a, ref int b) {
    int a1 = a;
    a = b;
    b = a1;
  }

  static void print(int[] array) {
    foreach (int i in array) {
      Console.Write(i + " ");
    }
    Console.WriteLine();
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
  	for (int i = 0, j; i < length - 1; i++) {
	  	int jMin = i;
		  for (j = i + 1; j < length; j++) {
			  if (array[j] < array[jMin]) {
				  jMin = j;
			  }
		  }
		  if (jMin != i) {
			  swap(ref array[i], ref array[jMin]);
		  }
	  }
  }
}