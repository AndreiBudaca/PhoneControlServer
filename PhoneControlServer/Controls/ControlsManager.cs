using PhoneControll.Controls.Classes;
using PhoneControll.Controls.Constants;
using System.Runtime.InteropServices;

namespace PhoneControll.Controls
{
  public static partial class ControlsManager
  {
    [LibraryImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial bool SetCursorPos(int x, int y);

    [LibraryImport("user32.dll")]
    private static partial void mouse_event(uint dwFlags, uint dx, uint dy, int dwData, int dwExtraInfo);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

    private const uint KEYEVENTF_KEYUP = 0x0002;

    public static void MoveMouse(MouseMovement movement)
    {
      var currentPosition = Cursor.Position;
      int newX = currentPosition.X + movement.XMovement;
      int newY = currentPosition.Y - movement.YMovement;
      SetCursorPos(newX, newY);
    }

    public static void RightClick()
    {
      mouse_event(MouseEventFlag.RightDown, 0, 0, 0, 0);
      mouse_event(MouseEventFlag.RightUp, 0, 0, 0, 0);
    }

    public static void LeftClick()
    {
      mouse_event(MouseEventFlag.LeftDown, 0, 0, 0, 0);
      mouse_event(MouseEventFlag.LeftUp, 0, 0, 0, 0);
    }

    public static void DoubleClick()
    {
      LeftClick();
      LeftClick();
    }

    public static void Scroll(int ammount)
    {
      mouse_event(MouseEventFlag.Scroll, 0, 0, ammount, 0);
    }

    public static void PressKey(string key)
    {
      SendKeys.SendWait(key);
    }

    public static void PressKeyCombination(params byte[] keyFlags)
    {
      // Press key down
      foreach (var keyFlag in keyFlags)
      {
        keybd_event(keyFlag, 0, 0, 0);
      }

      Thread.Sleep(1);

      // Press key up
      foreach (var keyFlag in keyFlags.Reverse())
      {
        keybd_event(keyFlag, 0, KEYEVENTF_KEYUP, 0);
      }
    }
  }
}
