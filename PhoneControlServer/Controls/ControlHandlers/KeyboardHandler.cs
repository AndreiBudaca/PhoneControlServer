using Desktop.Robot;

namespace PhoneControlServer.Controls.ControlHandlers
{
  public class KeyboardHandler : IControlHandler
  {
    public void Handle(string eventData1, string? eventData2)
    {
      if (eventData1 == "ENTER") ControlsManager.PressKeyCombination(Key.Enter);
      else if (eventData1 == "DELETE") ControlsManager.PressKeyCombination(Key.Backspace);
      else ControlsManager.PressKey(eventData1);
    }
  }
}
