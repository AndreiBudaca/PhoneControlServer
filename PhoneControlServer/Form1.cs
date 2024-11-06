using PhoneControll.Controls;

namespace PhoneControll
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void ControlHandlerWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {

    }

    private void startButton_Click(object sender, EventArgs e)
    {
      if (!ControlHandlerWorker.IsBusy)
      {
        ControlHandlerWorker.RunWorkerAsync();
      }
    }
  }
}
