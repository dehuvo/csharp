using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;

class Server {
  public static void Main() {
    Socket clientsocket = null;
    try {
      //IP주소를 나타내는 객체를 생성,TcpListener를 생성시 인자로 사용할려고
      IPAddress ipAd = IPAddress.Parse("127.0.0.1");
      //TcpListener Class를 이용하여 클라이언트의 연결을 받아 들인다.
      TcpListener tcpListener = new TcpListener(ipAd, 5001);
      tcpListener.Start();
      //Client의 접속이 올때 까지 Block 되는 부분, 대개 이부분을 Thread로 만들어 보내 버린다.
      //백그라운드 Thread에 처리를 맡긴다.
      clientsocket = tcpListener.AcceptSocket();
      //클라이언트의 데이터를 읽고, 쓰기 위한 스트림을 만든다.
      NetworkStream stream = new NetworkStream(clientsocket);
      Encoding encode = Encoding.GetEncoding("utf-8");
      StreamReader reader = new StreamReader(stream, encode);
      string s;
      while (true) {
        s = reader.ReadLine();
        if (s != null)
        Console.WriteLine(s);
      } //while (s.IndexOf("<EOF>") < 0);
    } catch (Exception e) {
      Console.WriteLine(e);
    } finally {
      clientsocket.Close();
    }
  }
}