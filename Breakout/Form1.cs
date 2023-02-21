using BreakoutGame;

namespace Breakout;

public partial class Form1 : Form
{
  public Form1()
  {
    InitializeComponent();
    ball.Location = new Point(paddle.Location.X, Height - 200);
    game.PaddleLocation = paddle.Location;
    game.PaddleMoved += Game_PaddleMoved;
  }

  private void Game_PaddleMoved(object? sender, MoveEventArgs e)
  {
    paddle.Location = e.Location;
  }

  protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
  {
    switch (keyData)
    {
      case Keys.Left:
        game.MoveLeft();
        return true;

      case Keys.Right:
        game.MoveRight(Width, paddle.Width);
        return true;

      default:
        return base.ProcessCmdKey(ref msg, keyData);
    }
  }

  int DirX = 1;
  int DirY = 1;
  int BallStep = 20;

  private void timer_Tick(object sender, EventArgs e)
  {
    var location = ball.Location;
    var maxX = Width - ball.Width - 20;
    var newX = location.X + DirX * BallStep;
    if (newX < 0 || newX >= maxX)
    {
      DirX = -DirX;
    }

    var maxY = Height - ball.Height - 40;
    var newY = location.Y + DirY * BallStep;
    if (newY < 0 || newY >= maxY)
    {
      DirY = -DirY;
    }

    var newLocation = new Point(Math.Min(newX, maxX), Math.Min(newY, maxY));
    ball.Location = newLocation;
  }

  private void Form1_Resize(object sender, EventArgs e)
  {
    paddle.Location = new Point(paddle.Location.X, Height - 200);
  }

  private Game game = new();
}