using System;

[AttributeUsage(AttributeTargets.Class)]
class AdditionalInfoAttribute : Attribute {
  string name;
  string update;
  string download;
  //생성자에 있는 두개의 인자는 위치지정 파라미터 이다.
  //즉 위치지정 파라미터는 클래스에 어트리뷰트를 붙일때 반드시 넘겨 줘야 한다.
  //항상 생성자에서 값을 넘겨 주게 되어 있으므로 name, update인 경우 Property에서 set이 없다.
  public AdditionalInfoAttribute(string name, string update) {
    this.name = name;
    this.update = update;
  }
  public string Name { get { return name; } }
  public string Update { get { return update; } }
  public string Download {
    set { download = value; }
    get { return download; }
  }
}

[AdditionalInfoAttribute("jclee","2018 - 01 - 01", Download = "http://ojc.asia")]
class Test {

}

public class AttrInfo {
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