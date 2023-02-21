using System.Drawing;

namespace BreakoutGame;

public class MoveEventArgs : EventArgs
{
  public MoveEventArgs(Point location)
  { 
    Location = location;
  }

  public Point Location { get; }
}
