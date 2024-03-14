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
            button1 = new Button();
            label6 = new Label();
            HeNanSxzButton = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // RunWind
            // 
            RunWind.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            RunWind.Location = new Point(124, 91);
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
            NowTimeText.Click += NowTimeText_Click;
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
            StopWind.Location = new Point(124, 237);
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
            DescriedSoft.Location = new Point(182, 407);
            DescriedSoft.Name = "DescriedSoft";
            DescriedSoft.Size = new Size(181, 22);
            DescriedSoft.TabIndex = 4;
            DescriedSoft.Text = "默认运行时间:00:20:00";
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "风电上报";
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
            label1.Location = new Point(239, 66);
            label1.Name = "label1";
            label1.Size = new Size(81, 22);
            label1.TabIndex = 5;
            label1.Text = "OMS填报";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label5.Location = new Point(581, 32);
            label5.Name = "label5";
            label5.Size = new Size(122, 22);
            label5.TabIndex = 8;
            label5.Text = "灰色表示不运行";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button1.Location = new Point(581, 374);
            button1.Name = "button1";
            button1.Size = new Size(135, 55);
            button1.TabIndex = 9;
            button1.Text = "关闭";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label6.Location = new Point(609, 343);
            label6.Name = "label6";
            label6.Size = new Size(74, 22);
            label6.TabIndex = 10;
            label6.Text = "调试按钮";
            // 
            // HeNanSxzButton
            // 
            HeNanSxzButton.Location = new Point(581, 91);
            HeNanSxzButton.Name = "HeNanSxzButton";
            HeNanSxzButton.Size = new Size(135, 63);
            HeNanSxzButton.TabIndex = 11;
            HeNanSxzButton.Text = "双细则";
            HeNanSxzButton.UseVisualStyleBackColor = true;
            HeNanSxzButton.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(581, 181);
            button3.Name = "button3";
            button3.Size = new Size(135, 63);
            button3.TabIndex = 12;
            button3.Text = "省调通知";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(581, 267);
            button4.Name = "button4";
            button4.Size = new Size(135, 63);
            button4.TabIndex = 13;
            button4.Text = "缺陷检测";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(37, 91);
            button5.Name = "button5";
            button5.Size = new Size(81, 280);
            button5.TabIndex = 14;
            button5.Text = "数据推送";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(HeNanSxzButton);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(DescriedSoft);
            Controls.Add(label3);
            Controls.Add(NowTimeText);
            Controls.Add(StopWind);
            Controls.Add(RunWind);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "风电上报";
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
        private Button button1;
        private Label label6;
        private Button HeNanSxzButton;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
