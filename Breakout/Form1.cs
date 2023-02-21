namespace Breakout;

public partial class Form1 : Form
{
  public Form1()
  {
    InitializeComponent();
    ball.Location = new Point(paddle.Location.X, Height - 200);
  }

  protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
  {
    switch (keyData)
    {
      case Keys.Left:
        MoveLeft();
        return true;

      case Keys.Right:
        MoveRight();
        return true;

      default:
        return base.ProcessCmdKey(ref msg, keyData);
    }
  }

  int PaddleSpeed = 50;

  private void MoveRight()
  {
    var oldLocation = paddle.Location;
    var maxX = Width - paddle.Width - 26;
    paddle.Location = new Point(Math.Min(oldLocation.X + PaddleSpeed, maxX), oldLocation.Y);
  }

  private void MoveLeft()
  {
    var oldLocation = paddle.Location;
    paddle.Location = new Point(Math.Max(0, oldLocation.X - PaddleSpeed), oldLocation.Y);
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
}