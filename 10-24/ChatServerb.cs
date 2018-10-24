using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Windows.Forms;

namespace ChatServer {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    static Encoding encoding = Encoding.GetEncoding("euc-kr");
    static string ip = "192.168.0.205";
    TcpListener listener = new TcpListener(IPAddress.Parse(ip), 5001);
    List<Socket> socketList = new List<Socket>();

    private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
      Application.Exit();
      listener.Stop();
    }

    private void cmd_Start_Click(object sender, EventArgs e) {
      if (lbl_Message.Tag.ToString() == "Stop") {
        try {
          listener.Start();
          new Thread(listen).Start();
          lbl_Message.Text = "Server Start 상태 입니다.";
          lbl_Message.Tag = "Start";
          cmd_Start.Text = "서버 종료";
        } catch {
          MessageBox.Show("서버 IP (" + ip + ")가 맞지 않습니다.", "서버");
        }
      } else {
        Application.Exit();
        listener.Stop();
        // foreach (Socket socket in socketList) {
        //   socket.Close();
        // }
        // socketList.Clear();
        // lbl_Message.Text = "Server Stop 상태 입니다.";
        // lbl_Message.Tag = "Stop";
        // cmd_Start.Text = "서버 시작";
      }
    }

    private void listen() {
      try {
        while (true) {
          Socket socket = listener.AcceptSocket();
          new Thread(() => chat(socket)).Start();
        }
      } catch (Exception e) {
        MessageBox.Show("서버 오류:\n" + e.ToString(), "서버");
      }
    }

    private void chat(Socket socket) {
      try {
        socketList.Add(socket);
        StreamReader reader = new StreamReader(new NetworkStream(socket), encoding);
        if (reader != null) {
          string line;
          while ((line = reader.ReadLine()) != null) {
            SetText(line + "\r\n");
            lock (socketList) {
              foreach (Socket s in socketList) {
                NetworkStream stream = new NetworkStream(s);
                StreamWriter writer = new StreamWriter(stream, encoding) { AutoFlush = true };
                writer.WriteLine(line);
                writer.Close();
              }
            }
          }
        }
      } catch {
      } finally {
        socket.Close();
        socketList.Remove(socket);
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