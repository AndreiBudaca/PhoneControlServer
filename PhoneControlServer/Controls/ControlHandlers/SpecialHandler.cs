using PhoneControll.Controls;
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
          ControlsManager.PressKeyCombination(CustomKeyFlag.Windows, CustomKeyFlag.Shift, CustomKeyFlag.LeftArrow);
          break;
        case "right":
          ControlsManager.PressKeyCombination(CustomKeyFlag.Windows, CustomKeyFlag.Shift, CustomKeyFlag.RightArrow);
          break;
      }
    }
  }
}
