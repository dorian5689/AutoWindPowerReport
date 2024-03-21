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
            HeNanSdtzButton = new Button();
            HeNanQxjcButton1 = new Button();
            HeNanSjtsButton = new Button();
            HeNanSxzButtonClose = new Button();
            HeNanSdtzButtonClose = new Button();
            HeNanQxjcButtonClose = new Button();
            HeNanSjtsButtonClose = new Button();
            HeNanUserButton = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // RunWind
            // 
            RunWind.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            RunWind.Location = new Point(124, 69);
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
            NowTimeText.Location = new Point(220, 9);
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
            label3.Location = new Point(315, 9);
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
            StopWind.Location = new Point(124, 221);
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
            DescriedSoft.Location = new Point(182, 419);
            DescriedSoft.Name = "DescriedSoft";
            DescriedSoft.Size = new Size(220, 22);
            DescriedSoft.TabIndex = 4;
            DescriedSoft.Text = "OMS默认运行时间:00:12:00";
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
            label1.Location = new Point(282, 41);
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
            label5.Location = new Point(547, 9);
            label5.Name = "label5";
            label5.Size = new Size(122, 22);
            label5.TabIndex = 8;
            label5.Text = "灰色表示不运行";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button1.Location = new Point(534, 393);
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
            label6.Location = new Point(534, 368);
            label6.Name = "label6";
            label6.Size = new Size(113, 22);
            label6.TabIndex = 10;
            label6.Text = "OMS调试按钮";
            // 
            // HeNanSxzButton
            // 
            HeNanSxzButton.Enabled = false;
            HeNanSxzButton.Location = new Point(534, 69);
            HeNanSxzButton.Name = "HeNanSxzButton";
            HeNanSxzButton.Size = new Size(135, 47);
            HeNanSxzButton.TabIndex = 11;
            HeNanSxzButton.Text = "双细则";
            HeNanSxzButton.UseVisualStyleBackColor = true;
            HeNanSxzButton.Click += button2_Click;
            // 
            // HeNanSdtzButton
            // 
            HeNanSdtzButton.Enabled = false;
            HeNanSdtzButton.Location = new Point(534, 134);
            HeNanSdtzButton.Name = "HeNanSdtzButton";
            HeNanSdtzButton.Size = new Size(135, 52);
            HeNanSdtzButton.TabIndex = 12;
            HeNanSdtzButton.Text = "省调通知";
            HeNanSdtzButton.UseVisualStyleBackColor = true;
            HeNanSdtzButton.Click += button3_Click;
            // 
            // HeNanQxjcButton1
            // 
            HeNanQxjcButton1.Enabled = false;
            HeNanQxjcButton1.Location = new Point(534, 221);
            HeNanQxjcButton1.Name = "HeNanQxjcButton1";
            HeNanQxjcButton1.Size = new Size(135, 52);
            HeNanQxjcButton1.TabIndex = 13;
            HeNanQxjcButton1.Text = "缺陷检测";
            HeNanQxjcButton1.UseVisualStyleBackColor = true;
            HeNanQxjcButton1.Click += button4_Click;
            // 
            // HeNanSjtsButton
            // 
            HeNanSjtsButton.Enabled = false;
            HeNanSjtsButton.Location = new Point(534, 298);
            HeNanSjtsButton.Name = "HeNanSjtsButton";
            HeNanSjtsButton.Size = new Size(131, 51);
            HeNanSjtsButton.TabIndex = 14;
            HeNanSjtsButton.Text = "数据推送";
            HeNanSjtsButton.UseVisualStyleBackColor = true;
            HeNanSjtsButton.Click += button5_Click;
            // 
            // HeNanSxzButtonClose
            // 
            HeNanSxzButtonClose.Location = new Point(713, 69);
            HeNanSxzButtonClose.Name = "HeNanSxzButtonClose";
            HeNanSxzButtonClose.Size = new Size(75, 47);
            HeNanSxzButtonClose.TabIndex = 15;
            HeNanSxzButtonClose.Text = "关闭状态";
            HeNanSxzButtonClose.UseVisualStyleBackColor = true;
            HeNanSxzButtonClose.Click += HeNanSxzButtonClose_Click;
            // 
            // HeNanSdtzButtonClose
            // 
            HeNanSdtzButtonClose.Location = new Point(713, 139);
            HeNanSdtzButtonClose.Name = "HeNanSdtzButtonClose";
            HeNanSdtzButtonClose.Size = new Size(75, 47);
            HeNanSdtzButtonClose.TabIndex = 16;
            HeNanSdtzButtonClose.Text = "关闭状态";
            HeNanSdtzButtonClose.UseVisualStyleBackColor = true;
            HeNanSdtzButtonClose.Click += HeNanSdtzButtonClose_Click;
            // 
            // HeNanQxjcButtonClose
            // 
            HeNanQxjcButtonClose.Location = new Point(713, 226);
            HeNanQxjcButtonClose.Name = "HeNanQxjcButtonClose";
            HeNanQxjcButtonClose.Size = new Size(75, 47);
            HeNanQxjcButtonClose.TabIndex = 17;
            HeNanQxjcButtonClose.Text = "关闭状态";
            HeNanQxjcButtonClose.UseVisualStyleBackColor = true;
            HeNanQxjcButtonClose.Click += HeNanQxjcButtonClose_Click;
            // 
            // HeNanSjtsButtonClose
            // 
            HeNanSjtsButtonClose.Location = new Point(713, 298);
            HeNanSjtsButtonClose.Name = "HeNanSjtsButtonClose";
            HeNanSjtsButtonClose.Size = new Size(75, 47);
            HeNanSjtsButtonClose.TabIndex = 18;
            HeNanSjtsButtonClose.Text = "关闭状态";
            HeNanSjtsButtonClose.UseVisualStyleBackColor = true;
            HeNanSjtsButtonClose.Click += HeNanSjtsButtonClose_Click;
            // 
            // HeNanUserButton
            // 
            HeNanUserButton.Location = new Point(124, 40);
            HeNanUserButton.Name = "HeNanUserButton";
            HeNanUserButton.Size = new Size(151, 23);
            HeNanUserButton.TabIndex = 19;
            HeNanUserButton.Text = "请选择需要运行的场站";
            HeNanUserButton.UseVisualStyleBackColor = true;
            HeNanUserButton.Click += HeNanUserButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HeNanUserButton);
            Controls.Add(HeNanSjtsButtonClose);
            Controls.Add(HeNanQxjcButtonClose);
            Controls.Add(HeNanSdtzButtonClose);
            Controls.Add(HeNanSxzButtonClose);
            Controls.Add(HeNanSjtsButton);
            Controls.Add(HeNanQxjcButton1);
            Controls.Add(HeNanSdtzButton);
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
        private Button HeNanSdtzButton;
        private Button HeNanQxjcButton1;
        private Button HeNanSjtsButton;
        private Button HeNanSxzButtonClose;
        private Button HeNanSdtzButtonClose;
        private Button HeNanQxjcButtonClose;
        private Button HeNanSjtsButtonClose;
        private Button HeNanUserButton;
    }
}
