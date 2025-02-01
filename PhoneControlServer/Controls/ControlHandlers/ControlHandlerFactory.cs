using PhoneControlServer.Controls.Classes;

namespace PhoneControlServer.Controls.ControlHandlers
{
  public static class ControlHandlerFactory
  {
    private static readonly IControlHandler keyboard = new KeyboardHandler();
    private static readonly IControlHandler mouseMovement = new MouseMovementHandler();
    private static readonly IControlHandler mouseWheel = new MouseWheelHandler();
    private static readonly IControlHandler mouseButton = new MouseButtonHandler();
    private static readonly IControlHandler special = new SpecialHandler();

    public static IControlHandler? GetControlHandler(ControlEventType eventType)
    {
      return eventType switch
      {
        ControlEventType.Keyboard => keyboard,
        ControlEventType.Mouse => mouseMovement,
        ControlEventType.MouseWheel => mouseWheel,
        ControlEventType.MouseButton => mouseButton,
        ControlEventType.Special => special,
        _ => null,
      };
    }
  }
}
