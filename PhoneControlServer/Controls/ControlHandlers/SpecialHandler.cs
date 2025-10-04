using Desktop.Robot;
using PhoneControlServer.Controls.Constants;

namespace PhoneControlServer.Controls.ControlHandlers
{
  public class SpecialHandler : IControlHandler
  {
    public void Handle(string eventData1, string? eventData2)
    {
      switch (eventData1)
      {
        case SpecialEventTargets.ApplicationWindow:
          HandleApplicationWindow(eventData2);
          break;
      }
    }

    public static void HandleApplicationWindow(string? eventData)
    {
      if (string.IsNullOrWhiteSpace(eventData)) return;

      switch (eventData)
      {
        case "left":
          ControlsManager.PressKeyCombination(Key.Command, Key.Shift, Key.Left);
          break;
        case "right":
          ControlsManager.PressKeyCombination(Key.Command, Key.Shift, Key.Right);
          break;
      }
    }
  }
}
