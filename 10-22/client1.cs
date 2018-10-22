using System;
using System.Text;
using System.IO;
using System.Net.Sockets;

class TcpClientTest {
  static void Main() {
    TcpClient client = null;
    try {
      client = new TcpClient();
      // client.Connect("localhost", 5001);
      client.Connect("192.168.0.15", 5001);
      NetworkStream stream = client.GetStream();
      Encoding encode = Encoding.GetEncoding("utf-8");
      StreamReader reader = new StreamReader(stream, encode);
      StreamWriter writer = new StreamWriter(stream, encode) { AutoFlush = true };
      string dataToSend;
      do {
        dataToSend = Console.ReadLine();
        writer.WriteLine(dataToSend);
        String str = reader.ReadLine();
        Console.WriteLine(str);
      } while (dataToSend.IndexOf("<EOF>") < 0);
    } catch (Exception e) {
      Console.WriteLine(e);
    } finally {
      client.Close();
    }
  }
}