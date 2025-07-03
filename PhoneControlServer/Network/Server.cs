using System.Net.Sockets;
using System.Net;
using Makaretu.Dns;

namespace PhoneControlServer.Network
{
  public class Server
  {
    public void Start(Action<TcpClient>? onClientConnect)
    {
      const int port = 34999;
      var server = new TcpListener(IPAddress.Any, port);
      server.Start();

      var service = new ServiceProfile("phone.control", "_tcp", port);
      var sd = new ServiceDiscovery();
      sd.Advertise(service);

      while (true)
      {
        var client = server.AcceptTcpClient();
        onClientConnect?.Invoke(client);
      }
    }
  }
}
