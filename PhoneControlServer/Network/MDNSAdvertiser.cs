using Makaretu.Dns;

namespace PhoneControlServer.Network
{
  public class MDNSAdvertiser
  {
    private readonly ServiceDiscovery serviceDiscovery = new();

    public void StartAdvertising(string instance, string service, ushort port)
    {
      serviceDiscovery.Advertise(new ServiceProfile(instance, service, port));
    }
  }
}
