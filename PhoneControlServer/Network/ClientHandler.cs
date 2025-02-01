using PhoneControlServer.Controls.Classes;
using PhoneControlServer.Controls.ControlHandlers;
using PhoneControlServer.Network.Extensions;
using System.Net.Sockets;
using System.Text.Json;
using System.Text;

namespace PhoneControlServer.Network
{
  public class ClientHandler(TcpClient client)
  {
    public void Handle()
    {
      client.ReceiveBufferSize = 1024;
      client.ReceiveTimeout = 5000;

      Console.WriteLine("Client connected!");

      NetworkStream stream = client.GetStream();
      string excess = string.Empty;

      while (client.Client.IsConnected())
      {
        byte[] buffer = new byte[1024];
        try
        {
          int bytesRead = stream.Read(buffer, 0, buffer.Length);
          if (bytesRead > 0)
          {
            string message = excess + Encoding.ASCII.GetString(buffer, 0, bytesRead);
            excess = string.Empty;

            var jsons = message.Split('}', StringSplitOptions.RemoveEmptyEntries).Select(message => message + "}").ToList();

            foreach (var json in jsons)
            {
              try
              {
                if (JsonDocument.Parse(json).Deserialize(typeof(ControlEvent)) is ControlEvent controlEvent)
                {
                  ControlHandlerFactory.GetControlHandler(controlEvent.EventType)?.Handle(controlEvent.Data1, controlEvent.Data2);
                }
              }
              catch (JsonException)
              {
                excess += json[..^1];
              }
            }
          }
        }
        catch (IOException) { }
        catch (Exception e) { Console.WriteLine(e); }
      }
    }
  }
}
