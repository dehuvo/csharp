using System;

class OnjOutTest {
  //초기화안된 배열을 받아서 초기화
  //out 매개변수의 경우 초기화시킨 배열을 넘길 수도 있다.
  static void FillArray1(out int[] arr) {
    //배열 초기화
    arr = new int[3] { 5919, 4790, 4791 };
  }

  //초기화된 배열을 받아서 값 변경
  static void FillArray2(ref int[] arr) {
    if (arr == null) { 
      arr = new int[3]; 
    }
    arr[0] = 1111; 
    arr[1] = 2222;
  }

  static void Main() {
    int[] onjArray;
    FillArray1(out onjArray);
    //배열출력
    Console.WriteLine("배열(out parameter) : ");
    for (int i = 0; i < onjArray.Length; i++) { 
      Console.Write(onjArray[i] + " "); 
    }
    Console.WriteLine("Press Any Key to Next"); 
    Console.ReadKey();
    FillArray2(ref onjArray);
    //배열출력
    Console.WriteLine("배열(ref parameter) : ");
    for (int i = 0; i < onjArray.Length; i++) { 
      Console.Write(onjArray[i] + " "); 
    }
    Console.WriteLine("Press Any Key to Next"); 
    Console.ReadKey();
    FillArray2(ref onjArray);
  }
}