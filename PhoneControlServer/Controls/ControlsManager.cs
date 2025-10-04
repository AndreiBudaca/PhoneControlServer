using Desktop.Robot;
using Desktop.Robot.Clicks;
using Desktop.Robot.Extensions;
using PhoneControll.Controls.Classes;

namespace PhoneControlServer.Controls
{
  public static partial class ControlsManager
  {
    private readonly static Robot robot = new Robot();
    private readonly static TimeSpan inputDuration = TimeSpan.FromMilliseconds(5); 

    public static void MoveMouse(MouseMovement movement)
    {
      robot.BezierMovement(
        robot.GetMousePosition(), 
        new Point
        {
          X = robot.GetMousePosition().X + movement.XMovement,
          Y = robot.GetMousePosition().Y - movement.YMovement
        },
        inputDuration
      );
    }

    public static void RightClick()
    {
      robot.Click(Mouse.RightButton());
    }

    public static void LeftClick()
    {
      robot.Click(Mouse.LeftButton());
    }

    public static void DoubleClick()
    {
      LeftClick();
      LeftClick();
    }

    public static void Scroll(int ammount)
    {
      robot.MouseScroll(ammount);
    }

    public static void PressKey(string key)
    {
      robot.Type(key);
    }

    public static void PressKeyCombination(params Key[] keyFlags)
    {
      robot.CombineKeys(keyFlags);
    }
  }
}
