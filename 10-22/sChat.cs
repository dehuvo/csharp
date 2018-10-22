using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

class Server {
  static List<Socket> clientSockets = new List<Socket>();

  public static void Main() {
    IPAddress ip = IPAddress.Parse("127.0.0.1");
    try {
      TcpListener listener = new TcpListener(ip, 5001);
      listener.Start();
      while (true) {
        Socket socket = listener.AcceptSocket();
        new Thread(() => chat(socket)).Start();
      }
    } catch (Exception e) {
      Console.WriteLine(e);
    }
  }

  static void chat(Socket socket) {
    Encoding encoding = Encoding.GetEncoding("euc-kr");
    try {
      clientSockets.Add(socket);
      StreamReader reader = new StreamReader(new NetworkStream(socket), encoding);
      string line;
      while (readLine(reader, out line)) {
        Console.WriteLine(line);
        foreach (Socket clientSocket in clientSockets) {
          NetworkStream stream = new NetworkStream(clientSocket);
          StreamWriter writer = new StreamWriter(stream, encoding) { AutoFlush = true };
          writer.WriteLine(line);
          writer.Close();
        }
      }
    } catch (Exception e) {
      Console.WriteLine(e.ToString());
    } finally {
      clientSockets.Remove(socket);
      socket.Close();
      socket = null;
    }
  }

  static bool readLine(StreamReader reader, out string line) {
    try {
      line = reader.ReadLine();
      return true;
    } catch {
      Console.WriteLine("== 클라이언트 하나가 종료되었습니다.");
      line = null;
      return false;
    }
  }
}