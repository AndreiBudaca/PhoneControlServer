﻿using PhoneControll.Controls.Classes;
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

    [LibraryImport("user32.dll")]
    private static partial short GetAsyncKeyState(int vKey);

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
  }
}
