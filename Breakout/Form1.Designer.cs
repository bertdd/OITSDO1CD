namespace Breakout {
  partial class Form1 {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      components = new System.ComponentModel.Container();
      paddle = new Label();
      ball = new Label();
      timer = new System.Windows.Forms.Timer(components);
      SuspendLayout();
      // 
      // paddle
      // 
      paddle.BackColor = Color.White;
      paddle.Location = new Point(215, 745);
      paddle.Margin = new Padding(2, 0, 2, 0);
      paddle.Name = "paddle";
      paddle.Size = new Size(60, 36);
      paddle.TabIndex = 0;
      // 
      // ball
      // 
      ball.BackColor = Color.IndianRed;
      ball.Location = new Point(330, 427);
      ball.Margin = new Padding(2, 0, 2, 0);
      ball.Name = "ball";
      ball.Size = new Size(49, 50);
      ball.TabIndex = 1;
      // 
      // timer
      // 
      timer.Enabled = true;
      timer.Interval = 25;
      timer.Tick += timer_Tick;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.Black;
      ClientSize = new Size(615, 820);
      Controls.Add(ball);
      Controls.Add(paddle);
      Margin = new Padding(2, 2, 2, 2);
      Name = "Form1";
      Text = "Breakout";
      Resize += Form1_Resize;
      ResumeLayout(false);
    }

    #endregion

    private Label paddle;
    private Label ball;
    private System.Windows.Forms.Timer timer;
  }
}