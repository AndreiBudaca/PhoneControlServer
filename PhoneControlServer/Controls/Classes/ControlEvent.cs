using System.Text.Json.Serialization;

namespace PhoneControlServer.Controls.Classes
{
  public class ControlEvent(ControlEventType eventType, string data1, string? data2)
  {
    [JsonPropertyName("eventType")]
    public ControlEventType EventType { get; set; } = eventType;

    [JsonPropertyName("data1")]
    public string Data1 { get; set; } = data1;

    [JsonPropertyName("data2")]
    public string? Data2 { get; set; } = data2;
  }

  public enum ControlEventType
  {
    Keyboard = 1,
    Mouse = 2,
    MouseWheel = 3,
    MouseButton = 4,
    Special = 5,
  }
}
