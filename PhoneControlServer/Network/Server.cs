﻿using System.Net.Sockets;
using System.Net;

namespace PhoneControlServer.Network
{
  public class Server
  {
    public void Start(Action<TcpClient>? onClientConnect)
    {
      const int port = 34999;
      var server = new TcpListener(IPAddress.Any, port);
      server.Start();

      while (true)
      {
        var client = server.AcceptTcpClient();
        onClientConnect?.Invoke(client);
      }
    }
  }
}
