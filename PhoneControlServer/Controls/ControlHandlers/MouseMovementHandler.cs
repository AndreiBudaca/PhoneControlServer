using PhoneControll.Controls;
using PhoneControll.Controls.Classes;

namespace PhoneControlServer.Controls.ControlHandlers
{
  public class MouseMovementHandler : IControlHandler
  {
    public void Handle(string eventData1, string? eventData2)
    {
      _ = float.TryParse(eventData1, out var xMovement);
      _ = float.TryParse(eventData2 ?? "0", out var yMovement);

      ControlsManager.MoveMouse(new MouseMovement { XMovement = (int)xMovement, YMovement = (int)yMovement });
    }
  }
}
