using System.Drawing;

namespace BreakoutGame;

public class Game
{
  /// <summary>
  /// Width of the game window
  /// </summary>
  public int Width { get; set; }

  /// <summary>
  /// Height of the game window
  /// </summary>
  public int Height { get; set; }

  public void Resize(int width, int height)
  {
    Width = width;
    Height = height;
    Paddle?.Move(new Point(Paddle.Location.X, Height - 200));
  }

  public Paddle? Paddle;

  public Ball? Ball;
}

