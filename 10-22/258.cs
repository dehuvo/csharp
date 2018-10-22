using System;
using System.Windows.Forms;

class Program : Form {
  static void Main() {
    Button button1 = new Button();
    button1.Text = "메시지";
    button1.Left = 50;
    button1.Top = 50;
    button1.Click += (object sender, EventArgs e) => {
      MessageBox.Show("버튼 클릭~");
    };
    Button button2 = new Button();
    button2.Text = "종료";
    button2.Left = 150;
    button2.Top = 50;
    button2.Click += (object sender, EventArgs e) => {
      MessageBox.Show("종료됩니다.~");
      Application.Exit();
    };
    Form p = new Program();
    p.Text = "윈폼 버튼 예제"; //윈도우 타이틀
    p.Height = 150;
    p.Controls.Add(button1);
    p.Controls.Add(button2);
    Application.Run(p);
  }
}