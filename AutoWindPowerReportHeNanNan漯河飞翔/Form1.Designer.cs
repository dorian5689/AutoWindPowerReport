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
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            TiaoShi = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // RunWind
            // 
            RunWind.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            RunWind.Location = new Point(109, 80);
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
            StopWind.Location = new Point(109, 250);
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
            DescriedSoft.Location = new Point(197, 407);
            DescriedSoft.Name = "DescriedSoft";
            DescriedSoft.Size = new Size(181, 22);
            DescriedSoft.TabIndex = 4;
            DescriedSoft.Text = "默认运行时间:00:20:00";
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "自动风电上报--河南平顶山--现场";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(542, 133);
            label1.Name = "label1";
            label1.Size = new Size(90, 22);
            label1.TabIndex = 5;
            label1.Text = "飞翔风电场";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label5.Location = new Point(542, 80);
            label5.Name = "label5";
            label5.Size = new Size(95, 22);
            label5.TabIndex = 8;
            label5.Text = "上报场站为:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.Location = new Point(542, 250);
            label2.Name = "label2";
            label2.Size = new Size(74, 22);
            label2.TabIndex = 10;
            label2.Text = "调试按钮";
            // 
            // TiaoShi
            // 
            TiaoShi.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            TiaoShi.Location = new Point(542, 320);
            TiaoShi.Name = "TiaoShi";
            TiaoShi.Size = new Size(135, 58);
            TiaoShi.TabIndex = 11;
            TiaoShi.Text = "关闭";
            TiaoShi.UseVisualStyleBackColor = true;
            TiaoShi.Click += TiaoShi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TiaoShi);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(DescriedSoft);
            Controls.Add(label3);
            Controls.Add(NowTimeText);
            Controls.Add(StopWind);
            Controls.Add(RunWind);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "自动风电上报--河南省漯河市--现场";
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
        private Label label1;
        private Label label5;
        private Label label2;
        private Button TiaoShi;
    }
}
