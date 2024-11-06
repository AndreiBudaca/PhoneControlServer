using PhoneControll.Controls;

namespace PhoneControlServer.Controls.ControlHandlers
{
  public class KeyboardHandler : IControlHandler
  {
    public void Handle(string eventData1, string? eventData2)
    {
      if (eventData1 == "ENTER") ControlsManager.PressKey("{ENTER}");
      else if (eventData1 == "DELETE") ControlsManager.PressKey("{BKSP}");
      else ControlsManager.PressKey(eventData1);
    }
  }
}
