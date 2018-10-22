using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

class Client {
  static void Main() {
    Encoding encoding = Encoding.GetEncoding("euc-kr");
    TcpClient client = new TcpClient();
    try {
      client.Connect("localhost", 5001);
      // client.Connect("192.168.0.15", 5001);
      NetworkStream stream = client.GetStream();
      StreamReader reader = new StreamReader(stream, encoding);
      new Thread(() => post(reader)).Start();
      
      StreamWriter writer = new StreamWriter(stream, encoding) { AutoFlush = true };
      string line;
      do {
        line = Console.ReadLine();
        writer.WriteLine(line);
      } while (line.IndexOf("<EOF>") < 0);
    } catch (Exception e) {
      Console.WriteLine(e);
    }
  }

  static void post(StreamReader reader) {
    try {
      string line;
      while ((line = reader.ReadLine()) != null) {
        Console.WriteLine("\n= " + line);
      }
    } catch (Exception e) {
      Console.WriteLine(e.ToString());
    } finally {
      reader.Close();
      reader = null;
    }
  }
}