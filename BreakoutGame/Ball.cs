using System.Drawing;

namespace BreakoutGame;

public class Ball : GameObject {
  public Ball(int width, int height) {
    Width = width;
    Height = height;
  }

  public int DirX { get; set; } = 1;

  public int DirY { get; set; } = 1;

  public int BallStep { get; set; } = 20;
  public int Width { get; }

  public int Height { get; }

  public void Kick(int screenWidth, int screenHeight) {
    var maxX = screenWidth - Width - 20;
    var newX = Location.X + DirX * BallStep;
    if (newX < 0 || newX >= maxX) {
      DirX = -DirX;
    }

    var maxY = screenHeight - Height - 40;
    var newY = Location.Y + DirY * BallStep;
    if (newY < 0 || newY >= maxY) {
      DirY = -DirY;
    }

    Move(new Point(Math.Min(newX, maxX), Math.Min(newY, maxY)));
  }
}

