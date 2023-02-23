using System.Drawing;

namespace BreakoutGame;

public class GameObject
{
  public event EventHandler<MoveEventArgs>? Moved;

  public void Move(Point location) 
  {
    Location = location;
    Moved?.Invoke(this, new MoveEventArgs(Location));
  }

  /// <summary>
  /// Location of the ball
  /// </summary>
  public Point Location { get; set; }
}
