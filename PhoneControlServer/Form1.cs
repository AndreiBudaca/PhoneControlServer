using PhoneControlServer.Network;
using System.Net.Sockets;
using System.Net;

namespace PhoneControll
{
  public partial class Form1 : Form
  {
    public int ConnectedClients { get; set; } = 0;

    public Form1()
    {
      InitializeComponent();
      NetworkComunicationWorker.RunWorkerAsync();

      string hostName = Dns.GetHostName(); // Get the local host name
      var addresses = Dns.GetHostAddresses(hostName).Where(addr => addr.AddressFamily == AddressFamily.InterNetwork).ToList();

      foreach (IPAddress address in addresses)
      {
        label_ip_addr.Text = address.ToString();
      }
    }

    private void ControlHandlerWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {

    }

    private void NetworkComunicationWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
      new Server().Start(client =>
      {
        NetworkComunicationWorker.ReportProgress(0, 1);
        var clientWorker = new System.ComponentModel.BackgroundWorker();
        clientWorker.DoWork += (sender, e) => { new ClientHandler(client).Handle(); };
        clientWorker.RunWorkerCompleted += (sender, e) =>
        {
          NetworkComunicationWorker.ReportProgress(0, -1);
          client.Dispose();
        };

        clientWorker.RunWorkerAsync();
      });
    }

    private void NetworkComunicationWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
    {
      var change = int.Parse(e.UserState?.ToString() ?? "0");

      ConnectedClients += change;
      label_connected_client_count.Text = $"{ConnectedClients}";
      notifyIcon.Text = $"Phone Control ({ConnectedClients})";
    }

    private void notifyIcon_DoubleClick(object sender, EventArgs e)
    {
      Show();
      WindowState = FormWindowState.Normal;
    }

    private void Form1_Resize(object sender, EventArgs e)
    {
      if (WindowState == FormWindowState.Minimized)
      {
        Hide();  // Hide the window
      }
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      WindowState = FormWindowState.Minimized;
    }
  }
}
