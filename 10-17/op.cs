using System;

public class AddClass1 {
  public int val;

  public static AddClass1 operator +(AddClass1 op1, AddClass1 op2) {
    AddClass1 obj = new AddClass1();
    obj.val = op1.val + op2.val;
    return obj;
  }
  public static bool operator > (AddClass1 op1, AddClass1 op2) {
    return (op1.val > op2.val);
  }
  public static bool operator < (AddClass1 op1, AddClass1 op2) {
    return !(op1 > op2);
  }

  public static bool operator ==(AddClass1 op1, AddClass1 op2) {
    return (op1.val == op2.val);
  }
  public static bool operator !=(AddClass1 op1, AddClass1 op2) {
    return !(op1 == op2);
  }
  public override bool Equals(object op1) {
    return val == ((AddClass1)op1).val;
  }
  //GetHashCode 는 개체의 상태에 기반한 고유한 int 값을 얻는데 사용 한다.
  public override int GetHashCode() {
    return val;
  }
}

class Test {
  static void Main() {
    AddClass1 op1 = new AddClass1(); op1.val = 1;
    AddClass1 op2 = new AddClass1(); op2.val = 2;
    AddClass1 op3 = op1 + op2;
    Console.WriteLine("op1 + op2 = {0}", op3.val);
  }
}