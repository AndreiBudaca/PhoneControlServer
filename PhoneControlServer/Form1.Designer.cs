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
      components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      NetworkComunicationWorker = new System.ComponentModel.BackgroundWorker();
      titleLabel = new Label();
      label_connected_clients = new Label();
      label_connected_client_count = new Label();
      label1 = new Label();
      label_ip_addr = new Label();
      notifyIcon = new NotifyIcon(components);
      contextMenuStrip1 = new ContextMenuStrip(components);
      closeToolStripMenuItem = new ToolStripMenuItem();
      contextMenuStrip1.SuspendLayout();
      SuspendLayout();
      // 
      // NetworkComunicationWorker
      // 
      NetworkComunicationWorker.WorkerReportsProgress = true;
      NetworkComunicationWorker.DoWork += NetworkComunicationWorker_DoWork;
      NetworkComunicationWorker.ProgressChanged += NetworkComunicationWorker_ProgressChanged;
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
      // label_connected_clients
      // 
      label_connected_clients.AutoSize = true;
      label_connected_clients.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      label_connected_clients.Location = new Point(12, 215);
      label_connected_clients.Name = "label_connected_clients";
      label_connected_clients.Size = new Size(233, 37);
      label_connected_clients.TabIndex = 1;
      label_connected_clients.Text = "Connected clients:";
      // 
      // label_connected_client_count
      // 
      label_connected_client_count.AutoSize = true;
      label_connected_client_count.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      label_connected_client_count.Location = new Point(251, 215);
      label_connected_client_count.Name = "label_connected_client_count";
      label_connected_client_count.Size = new Size(32, 37);
      label_connected_client_count.TabIndex = 2;
      label_connected_client_count.Text = "0";
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      label1.Location = new Point(12, 261);
      label1.Name = "label1";
      label1.Size = new Size(132, 37);
      label1.TabIndex = 3;
      label1.Text = "Server IP: ";
      // 
      // label_ip_addr
      // 
      label_ip_addr.AutoSize = true;
      label_ip_addr.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      label_ip_addr.Location = new Point(150, 261);
      label_ip_addr.Name = "label_ip_addr";
      label_ip_addr.Size = new Size(142, 37);
      label_ip_addr.TabIndex = 4;
      label_ip_addr.Text = "(unknown)";
      label_ip_addr.TextAlign = ContentAlignment.TopRight;
      // 
      // notifyIcon
      // 
      notifyIcon.ContextMenuStrip = contextMenuStrip1;
      notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
      notifyIcon.Text = "Phone Control (0)";
      notifyIcon.Visible = true;
      notifyIcon.DoubleClick += notifyIcon_DoubleClick;
      // 
      // contextMenuStrip1
      // 
      contextMenuStrip1.Items.AddRange(new ToolStripItem[] { closeToolStripMenuItem });
      contextMenuStrip1.Name = "contextMenuStrip1";
      contextMenuStrip1.Size = new Size(181, 48);
      // 
      // closeToolStripMenuItem
      // 
      closeToolStripMenuItem.Name = "closeToolStripMenuItem";
      closeToolStripMenuItem.Size = new Size(180, 22);
      closeToolStripMenuItem.Text = "Close";
      closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(513, 450);
      Controls.Add(label_ip_addr);
      Controls.Add(label1);
      Controls.Add(label_connected_client_count);
      Controls.Add(label_connected_clients);
      Controls.Add(titleLabel);
      Name = "Form1";
      Text = "Form1";
      Shown += Form1_Shown;
      Resize += Form1_Resize;
      contextMenuStrip1.ResumeLayout(false);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private System.ComponentModel.BackgroundWorker NetworkComunicationWorker;
    private Label titleLabel;
    private Label label_connected_clients;
    private Label label_connected_client_count;
    private Label label1;
    private Label label_ip_addr;
    private NotifyIcon notifyIcon;
    private ContextMenuStrip contextMenuStrip1;
    private ToolStripMenuItem closeToolStripMenuItem;
  }
}
