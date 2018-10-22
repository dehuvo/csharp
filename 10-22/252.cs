using System;
using System.Windows.Forms;

class OnjMessageFilter : IMessageFilter {
  public bool PreFilterMessage(ref Message m) {
    if (m.Msg == 0x201) {  // 마우스 클릭 이벤트
      Console.WriteLine("마우스 클릭 필터링됨...");
      // return true;  // 필터링 -- 이벤트 흡수
    }
    return false;
  }
}

class Program : Form {
  static void Main(string[] args) {
    Application.AddMessageFilter(new OnjMessageFilter());
    Program p = new Program();
    p.Click += new EventHandler(p.Form_Click);
    Application.Run(p);
  }

  void Form_Click(object sender, EventArgs e) {
    Console.WriteLine("마우스 클릭 이벤트 발생...");
    Application.Exit();
  }
}