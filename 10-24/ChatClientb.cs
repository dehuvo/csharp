using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ChatClient {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    static Encoding encoding = Encoding.GetEncoding("euc-kr");
    TcpClient tcpClient;
    StreamReader reader;
    StreamWriter writer;

    private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
      if (cmd_Connect.Text != "로그인") {
        sendlogout();
      }
    }

    private void cmd_Connect_Click(object sender, EventArgs e) {
      if (cmd_Connect.Text == "로그인") {
        try {
          tcpClient = new TcpClient();
          tcpClient.Connect(IPAddress.Parse(txt_Server_IP.Text), 5001);
          NetworkStream stream = tcpClient.GetStream();
          reader = new StreamReader(stream, encoding);
          writer = new StreamWriter(stream, encoding) { AutoFlush = true };
          new Thread(post).Start();
          send("<" + txt_Name.Text + "> 님이 들어오셨습니다.", true);
          cmd_Connect.Text = "로그아웃";
        } catch (Exception ex) {
          MessageBox.Show("서버가 가동 중이 아니거나 오류 발생\n\n" + ex.Message, "클라이언트");
        }
      } else {
        SetText(sendlogout() + "\r\n");
        cmd_Connect.Text = "로그인";
      }
    }

    private void txt_Msg_KeyPress(object sender, KeyPressEventArgs e) {
      if (e.KeyChar == (char) Keys.Enter) {
        if (cmd_Connect.Text == "로그아웃") {
          send("<" + txt_Name.Text + "> " + txt_Msg.Text, true);
        }
        txt_Msg.Text = "";
        e.Handled = true;
      }
    }

    public string sendlogout() {
      string message = "<" + txt_Name.Text + "> 님이 나가셨습니다.";
      send(message, false);
      logout();
      return message;
    }

    public void logout() {
      reader.Close();
      reader = null;
    }

    private void send(string message, bool showErrorMessage) {
      try {
        writer.WriteLine(message);
      } catch (Exception e) {
        if (showErrorMessage) {
          MessageBox.Show("서버가 가동 중이 아니거나 오류 발생\n\n" + e.Message, "클라이언트");
          cmd_Connect.Text = "로그인";
          logout();
        }
      }
    }

    public void post() {
      try {
        string line;
        while (reader != null && (line = reader.ReadLine()) != null) {
          if (line != "") {
            SetText(line + "\r\n");
          }
        }
      } catch {
      } finally {
        if (reader != null) {
          reader.Close();
          reader = null;
        }
        tcpClient.Close();
      }
    }

    public void SetText(string text) {
      if (this.txt_Chat.InvokeRequired) {
        this.Invoke((Action<string>) SetText, text);
      } else {
        this.txt_Chat.AppendText(text);
      }
    }
  }
}