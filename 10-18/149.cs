using System;
// using System.Windows.Forms;

// delegate void DisplayMessage(string message);
delegate void CharArrayAction(char[] a);

public class TestCustomDelegate {

  static string convert(string s, CharArrayAction f) {
    char[] a = s.ToCharArray();
    f(a);
    return new string(a);
  }

  public static void Main(string[] args) {
    if (0 < args.Length) {
      string s = args[0];
      Console.WriteLine(convert(s, a => a[0] = char.ToUpper(a[0])));
      Console.WriteLine(convert(s, a => a[a.Length - 1] = char.ToUpper(a[a.Length - 1])));
      // Console.WriteLine(s.ToUpper());
      Console.WriteLine(convert(s, a => {
        for (int i = 0; i < a.Length; i++) {
          a[i] = char.ToUpper(a[i]);
        }
      }));
      Console.WriteLine(convert(s, a => Array.Reverse(a)));
      Console.WriteLine(convert(s, a => Array.Sort(a)));
    }
  }
}