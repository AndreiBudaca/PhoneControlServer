namespace PhoneControll
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      NetworkComunicationWorker = new System.ComponentModel.BackgroundWorker();
      ControlHandlerWorker = new System.ComponentModel.BackgroundWorker();
      titleLabel = new Label();
      startButton = new Button();
      SuspendLayout();
      // 
      // ControlHandlerWorker
      // 
      ControlHandlerWorker.DoWork += ControlHandlerWorker_DoWork;
      // 
      // titleLabel
      // 
      titleLabel.AutoSize = true;
      titleLabel.Font = new Font("Segoe UI", 36F);
      titleLabel.Location = new Point(87, 83);
      titleLabel.Name = "titleLabel";
      titleLabel.Size = new Size(333, 65);
      titleLabel.TabIndex = 0;
      titleLabel.Text = "Phone Control";
      // 
      // startButton
      // 
      startButton.Location = new Point(210, 249);
      startButton.Name = "startButton";
      startButton.Size = new Size(75, 23);
      startButton.TabIndex = 1;
      startButton.Text = "Start";
      startButton.UseVisualStyleBackColor = true;
      startButton.Click += startButton_Click;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(513, 450);
      Controls.Add(startButton);
      Controls.Add(titleLabel);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private System.ComponentModel.BackgroundWorker NetworkComunicationWorker;
    private System.ComponentModel.BackgroundWorker ControlHandlerWorker;
    private Label titleLabel;
    private Button startButton;
  }
}
