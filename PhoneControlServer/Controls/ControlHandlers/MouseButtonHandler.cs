using PhoneControll.Controls;

namespace PhoneControlServer.Controls.ControlHandlers
{
  public class MouseButtonHandler : IControlHandler
  {
    public void Handle(string eventData1, string? eventData2)
    {
      _ = float.TryParse(eventData1, out var click);

      if (click > 0) ControlsManager.LeftClick();
      else ControlsManager.RightClick();
    }
  }
}
