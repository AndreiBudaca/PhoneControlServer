using PhoneControll.Controls.Classes;

namespace PhoneControlServer.Controls.ControlHandlers
{
  public class MouseWheelHandler : IControlHandler
  {
    public void Handle(string eventData1, string? eventData2)
    {
      _ = float.TryParse(eventData1, out var movement);

      ControlsManager.Scroll((int)movement);
    }
  }
}
