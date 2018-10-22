using System;
using System.IO;
using System.Net.Sockets;

class TcpClientTest {
  static void Main() {
    TcpClient client = null;
    try {
      //LocalHost에 지정 포트로 TCP Connection을 생성하고 데이터를 송수신 하기
      //위한 스트림을 얻는다.
      client = new TcpClient();
      client.Connect("localhost", 5001);
      NetworkStream stream = client.GetStream();
      StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };
      string dataToSend;
      do {
        dataToSend = Console.ReadLine();
        writer.WriteLine(dataToSend);
      } while (dataToSend.IndexOf("<EOF>") < 0);
    } catch (Exception e) {
      Console.WriteLine(e);
    } finally {
      client.Close();
    }
  }
}