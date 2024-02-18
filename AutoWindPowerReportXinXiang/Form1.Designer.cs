namespace AutoWindPowerReport
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
            RunWind = new Button();
            NowTimeText = new Label();
            label3 = new Label();
            StopWind = new Button();
            DescriedSoft = new Label();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // RunWind
            // 
            RunWind.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            RunWind.Location = new Point(220, 80);
            RunWind.Name = "RunWind";
            RunWind.Size = new Size(345, 128);
            RunWind.TabIndex = 0;
            RunWind.Text = "运行";
            RunWind.UseVisualStyleBackColor = true;
            RunWind.Click += RunWind_Click;
            // 
            // NowTimeText
            // 
            NowTimeText.AutoSize = true;
            NowTimeText.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            NowTimeText.Location = new Point(220, 32);
            NowTimeText.Name = "NowTimeText";
            NowTimeText.Size = new Size(79, 22);
            NowTimeText.TabIndex = 2;
            NowTimeText.Text = "当前时间:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.Location = new Point(305, 32);
            label3.Name = "label3";
            label3.Size = new Size(48, 22);
            label3.TabIndex = 3;
            label3.Text = "QAQ";
            label3.Click += NowTime_Click;
            // 
            // StopWind
            // 
            StopWind.Enabled = false;
            StopWind.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            StopWind.Location = new Point(220, 259);
            StopWind.Name = "StopWind";
            StopWind.Size = new Size(345, 128);
            StopWind.TabIndex = 1;
            StopWind.Text = "停止";
            StopWind.UseVisualStyleBackColor = true;
            StopWind.Click += StopWind_Click;
            // 
            // DescriedSoft
            // 
            DescriedSoft.AutoSize = true;
            DescriedSoft.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            DescriedSoft.Location = new Point(220, 407);
            DescriedSoft.Name = "DescriedSoft";
            DescriedSoft.Size = new Size(181, 22);
            DescriedSoft.TabIndex = 4;
            DescriedSoft.Text = "默认运行时间:00:20:00";
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "自动风电上报--河南新乡--现场";
            notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(101, 70);
            contextMenuStrip1.Text = "自动风电上报--郑州";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(100, 22);
            toolStripMenuItem1.Text = "打开";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(100, 22);
            toolStripMenuItem2.Text = "隐藏";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(100, 22);
            toolStripMenuItem3.Text = "退出";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DescriedSoft);
            Controls.Add(label3);
            Controls.Add(NowTimeText);
            Controls.Add(StopWind);
            Controls.Add(RunWind);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "自动风电上报--河南新乡--现场";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RunWind;
        private Label NowTimeText;
        private Label label3;
        private Button StopWind;
        private Label DescriedSoft;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}
