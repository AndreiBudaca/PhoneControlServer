using PhoneControlServer.Controls.Classes;
using PhoneControlServer.Controls.ControlHandlers;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PhoneControll
{
  public static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    /// [STAThread]
    static void Main()
    {
      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      //ApplicationConfiguration.Initialize();
      //Application.Run(new Form1());

      const int port = 34999;
      var server = new TcpListener(IPAddress.Any, port);
      server.Start();
      Console.WriteLine("Server is listening....");

      while (true)
      {
        using TcpClient client = server.AcceptTcpClient();
        client.ReceiveBufferSize = 1024;
        client.ReceiveTimeout = 5000;

        Console.WriteLine("Client connected!");

        NetworkStream stream = client.GetStream();

        while (client.Client.IsConnected())
        {
          byte[] buffer = new byte[1024];
          try
          {
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            if (bytesRead > 0)
            {
              string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
              var jsons = message.Split('}', StringSplitOptions.RemoveEmptyEntries).Select(message => message + "}").ToList();

              foreach (var json in jsons)
              {
                var controlEvent = JsonDocument.Parse(json).Deserialize(typeof(ControlEvent)) as ControlEvent;
                if (controlEvent != null)
                {
                  ControlHandlerFactory.GetControlHandler(controlEvent.EventType)?.Handle(controlEvent.Data1, controlEvent.Data2);
                }
              }
            }
          }
          catch (IOException) { Console.WriteLine("Timeout"); }
          catch (Exception e) { Console.WriteLine(e); }
        }

        Console.WriteLine("Client disconnected");
      }
    }
  }

  static class SocketExtensions
  {
    public static bool IsConnected(this Socket socket)
    {
      try
      {
        return !(socket.Poll(1, SelectMode.SelectRead) && socket.Available == 0);
      }
      catch (SocketException) { return false; }
    }
  }
}