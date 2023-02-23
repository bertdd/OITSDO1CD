using BreakoutGame;

namespace Breakout;

public partial class Form1 : Form {
  public Form1() {
    InitializeComponent();
    ball.Location = new Point(paddle.Location.X, Height - 200);

    game = new Game {
      Width = Width,
      Height = Height,
      Paddle = new Paddle(paddle.Location, paddle.Width),
      Ball = new Ball(ball.Width, ball.Height)
    };

    game.Paddle.Moved += ((o, e) => paddle.Location = e.Location);
    game.Ball.Moved += ((o, e) => ball.Location = e.Location);
  }

  protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
    switch (keyData) {
      case Keys.Left:
        game?.Paddle?.MoveLeft();
        return true;

      case Keys.Right:
        game?.Paddle?.MoveRight(Width);
        return true;

      default:
        return base.ProcessCmdKey(ref msg, keyData);
    }
  }

  private void timer_Tick(object sender, EventArgs e)
  {
    game?.Ball?.Kick(Width, Height);
  }

  private void Form1_Resize(object sender, EventArgs e) {
    if (game != null) {
      game.Resize(Width, Height);
    }
  }

  private readonly Game game;
}