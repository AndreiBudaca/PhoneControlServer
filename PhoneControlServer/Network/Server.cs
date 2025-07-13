using System.Net.Sockets;
using System.Net;

namespace PhoneControlServer.Network
{
  public class Server(ushort port)
  {
    private readonly TcpListener tcpListener = new TcpListener(IPAddress.Any, port);

    public void Start(Action<TcpClient>? onClientConnect)
    {
      tcpListener.Start();

      while (true)
      {
        var client = tcpListener.AcceptTcpClient();
        onClientConnect?.Invoke(client);
      }
    }
  }
}
