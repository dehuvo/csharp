using System;
using System.Windows.Forms;

class Program : Form {
  static void Main() {
    Form form = new Program();
    form.Click += new EventHandler((sender, eventArgs) => {
      Console.WriteLine("폼클릭 이벤트...");
      Application.Exit();
    });
    Console.WriteLine("윈도우 시작...");
    Application.Run(form);
    Console.WriteLine("윈도우 종료...");
  }
}