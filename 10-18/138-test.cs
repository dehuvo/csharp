using System;

[AdditionalInfo("홍길동","2018-10-18", Download = "http://ojc.asia")]
class Test {
  public static void Main() {
    Type type = typeof(Test);
    foreach (Attribute attr in type.GetCustomAttributes(true)) {
      AdditionalInfoAttribute info = attr as AdditionalInfoAttribute;
      if (info != null) {
        Console.WriteLine("Name={0}, Update={1}, DownLoad={2}",
        info.Name, info.Update, info.Download);
      }
    }
  }
}

// csc 138-test.cs 138-att.cs
// 138-test