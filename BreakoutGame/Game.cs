using System;
using System.Drawing;
using System.Reflection.Metadata;

namespace BreakoutGame;

public class Game
{
  /// <summary>
  /// Position of the paddle
  /// </summary>
  public Point PaddleLocation { get; set; }


  /// <summary>
  /// Step speed of the paddle
  /// </summary>
  public int PaddleStep { get; set; } = 50;

  public void MoveLeft()
  {
    PaddleLocation = new Point(Math.Max(0, PaddleLocation.X - PaddleStep), PaddleLocation.Y);
    PaddleMoved?.Invoke(this, new MoveEventArgs(PaddleLocation));
  }

  public void MoveRight(int width, int paddleWidth)
  {
    var maxX = width - paddleWidth - 26;
    PaddleLocation = new Point(Math.Min(PaddleLocation.X + PaddleStep, maxX), PaddleLocation.Y);
    PaddleMoved?.Invoke(this, new MoveEventArgs(PaddleLocation));
  }

  public event EventHandler<MoveEventArgs> PaddleMoved;
}

