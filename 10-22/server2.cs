using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

class ClientHandler {
  readonly Socket socket = null;

  public ClientHandler(Socket socket) {
    this.socket = socket;
  }
  
  public void chat() {
    NetworkStream stream = new NetworkStream(socket);
    Encoding encode = Encoding.GetEncoding("utf-8");
    StreamReader reader = new StreamReader(stream, encode);
    StreamWriter writer = new StreamWriter(stream, encode) { AutoFlush = true };
    string s;
    while ((s = reader.ReadLine()) != null) {
      Console.WriteLine(s);
      writer.WriteLine(s);
    }
    socket.Close();
  }
}

class Server {
  public static void Main() {
    try {
      IPAddress ipAd = IPAddress.Parse("127.0.0.1");
      TcpListener listener = new TcpListener(ipAd, 5001);
      listener.Start();
      while (true) {
        Socket clientsocket = listener.AcceptSocket();
        ClientHandler clientHandler = new ClientHandler(clientsocket);
        new Thread(clientHandler.chat).Start();
      }
    } catch (Exception e) {
      Console.WriteLine(e.ToString());
    } finally {
      // clientsocket.Close();
    }
  }
}