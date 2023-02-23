using System.Drawing;

namespace BreakoutGame;

public class Paddle : GameObject {
  public Paddle(Point location, int width)
  {
    Width = width;
    Move(location);
  }

  /// <summary>
  /// Step speed of the paddle
  /// </summary>
  public int Step { get; set; } = 50;

  /// <summary>
  /// Width of the paddle
  /// </summary>
  public int Width { get; set; }

  public void MoveLeft()
  {
    Move(new Point(Math.Max(0, Location.X - Step), Location.Y));
  }

  public void MoveRight(int screenWidth)
  {
    var maxX = screenWidth - Width - 26;
    Move(new Point(Math.Min(Location.X + Step, maxX), Location.Y));
  }
}

