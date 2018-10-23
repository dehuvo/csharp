using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

class Client {
  static StreamReader reader = null;

  static void Main() {
    Encoding encoding = Encoding.GetEncoding("euc-kr");
    TcpClient client = new TcpClient();
    try {
      client.Connect("localhost", 5001);
      NetworkStream stream = client.GetStream();
      reader = new StreamReader(stream, encoding);
      new Thread(post).Start();
      
      StreamWriter writer = new StreamWriter(stream, encoding) { AutoFlush = true };
      int i;
      do {
        string line = Console.ReadLine();
        if (0 <= (i = line.IndexOf("<EOF>"))) {
          line = line.Substring(0, i);
        }
        if (0 < line.Length) {
          writer.WriteLine(line);
        }
      } while (i < 0);
    } catch {
      Console.WriteLine("서버에 전송할 수 없습니다.");
    } finally {
      reader = null;
      client.Close();
      client = null;
    }
  }

  static void post() {
    try {
      string line;
      while (reader != null && (line = reader.ReadLine()) != null) {
        Console.WriteLine("=> " + line);
      }
    } catch {
    }
  }
}