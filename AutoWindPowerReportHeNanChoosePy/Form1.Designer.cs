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
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            button2 = new Button();
            labelFilePath = new Label();
            button3 = new Button();
            pycode = new Label();
            PathJueDui = new Label();
            toolTip = new ToolTip(components);
            button7 = new Button();
            button4 = new Button();
            RunCodePath = new Label();
            label1 = new Label();
            button5 = new Button();
            button6 = new Button();
            button8 = new Button();
            label7 = new Label();
            label8 = new Label();
            button9 = new Button();
            button10 = new Button();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label10 = new Label();
            label11 = new Label();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // RunWind
            // 
            RunWind.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            RunWind.Location = new Point(1125, 559);
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
            NowTimeText.Location = new Point(1033, 746);
            NowTimeText.Name = "NowTimeText";
            NowTimeText.Size = new Size(79, 22);
            NowTimeText.TabIndex = 2;
            NowTimeText.Text = "当前时间:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.Location = new Point(926, 746);
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
            StopWind.Location = new Point(1235, 746);
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
            DescriedSoft.Location = new Point(1309, 703);
            DescriedSoft.Name = "DescriedSoft";
            DescriedSoft.Size = new Size(181, 22);
            DescriedSoft.TabIndex = 4;
            DescriedSoft.Text = "默认运行时间:00:20:00";
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "自动风电上报--河南南阳--现场";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.Location = new Point(1600, 541);
            label2.Name = "label2";
            label2.Size = new Size(42, 22);
            label2.TabIndex = 6;
            label2.Text = "凯润";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label4.Location = new Point(1493, 550);
            label4.Name = "label4";
            label4.Size = new Size(42, 22);
            label4.TabIndex = 7;
            label4.Text = "嘉润";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label5.Location = new Point(1485, 491);
            label5.Name = "label5";
            label5.Size = new Size(95, 22);
            label5.TabIndex = 8;
            label5.Text = "上报场站为:";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button1.Location = new Point(1143, 181);
            button1.Name = "button1";
            button1.Size = new Size(123, 55);
            button1.TabIndex = 9;
            button1.Text = "关闭";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label6.Location = new Point(1143, 110);
            label6.Name = "label6";
            label6.Size = new Size(74, 22);
            label6.TabIndex = 10;
            label6.Text = "调试按钮";
            label6.Click += label6_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button2.Location = new Point(46, 173);
            button2.Name = "button2";
            button2.Size = new Size(208, 63);
            button2.TabIndex = 11;
            button2.Text = "点击需要运行的py解释器";
            toolTip.SetToolTip(button2, "111");
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelFilePath
            // 
            labelFilePath.AutoSize = true;
            labelFilePath.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            labelFilePath.Location = new Point(312, 110);
            labelFilePath.Name = "labelFilePath";
            labelFilePath.Size = new Size(74, 22);
            labelFilePath.TabIndex = 12;
            labelFilePath.Text = "选择代码";
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button3.Location = new Point(312, 173);
            button3.Name = "button3";
            button3.Size = new Size(221, 63);
            button3.TabIndex = 13;
            button3.Text = "点击需要运行的py代码";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pycode
            // 
            pycode.AutoSize = true;
            pycode.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            pycode.Location = new Point(1012, 475);
            pycode.Name = "pycode";
            pycode.Size = new Size(74, 22);
            pycode.TabIndex = 14;
            pycode.Text = "运行状态";
            pycode.Click += pycode_Click;
            // 
            // PathJueDui
            // 
            PathJueDui.AutoSize = true;
            PathJueDui.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            PathJueDui.Location = new Point(1272, 521);
            PathJueDui.Name = "PathJueDui";
            PathJueDui.Size = new Size(74, 22);
            PathJueDui.TabIndex = 15;
            PathJueDui.Text = "调试按钮";
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button7.Location = new Point(46, 287);
            button7.Name = "button7";
            button7.Size = new Size(208, 63);
            button7.TabIndex = 19;
            button7.Text = "点击需要运行的py解释器";
            toolTip.SetToolTip(button7, "111");
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button4.Location = new Point(942, 173);
            button4.Name = "button4";
            button4.Size = new Size(120, 63);
            button4.TabIndex = 16;
            button4.Text = "运行";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // RunCodePath
            // 
            RunCodePath.AutoSize = true;
            RunCodePath.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            RunCodePath.Location = new Point(1351, 181);
            RunCodePath.Name = "RunCodePath";
            RunCodePath.Size = new Size(106, 22);
            RunCodePath.TabIndex = 17;
            RunCodePath.Text = "显示运行代码";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(1351, 290);
            label1.Name = "label1";
            label1.Size = new Size(106, 22);
            label1.TabIndex = 22;
            label1.Text = "显示运行代码";
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button5.Location = new Point(942, 287);
            button5.Name = "button5";
            button5.Size = new Size(120, 63);
            button5.TabIndex = 21;
            button5.Text = "运行";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button6.Location = new Point(312, 287);
            button6.Name = "button6";
            button6.Size = new Size(221, 63);
            button6.TabIndex = 20;
            button6.Text = "点击需要运行的py代码";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button8.Location = new Point(1143, 290);
            button8.Name = "button8";
            button8.Size = new Size(123, 55);
            button8.TabIndex = 18;
            button8.Text = "关闭";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label7.Location = new Point(46, 110);
            label7.Name = "label7";
            label7.Size = new Size(90, 22);
            label7.TabIndex = 23;
            label7.Text = "选择解释器";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label8.Location = new Point(563, 110);
            label8.Name = "label8";
            label8.Size = new Size(74, 22);
            label8.TabIndex = 24;
            label8.Text = "定时任务";
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button9.Location = new Point(729, 287);
            button9.Name = "button9";
            button9.Size = new Size(120, 63);
            button9.TabIndex = 27;
            button9.Text = "取消";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button10.Location = new Point(729, 173);
            button10.Name = "button10";
            button10.Size = new Size(120, 63);
            button10.TabIndex = 26;
            button10.Text = "开启";
            button10.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label9.Location = new Point(729, 110);
            label9.Name = "label9";
            label9.Size = new Size(106, 22);
            label9.TabIndex = 25;
            label9.Text = "定时任务操作";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(539, 180);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(155, 23);
            dateTimePicker1.TabIndex = 28;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(678, 643);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label10.Location = new Point(854, 449);
            label10.Name = "label10";
            label10.Size = new Size(42, 22);
            label10.TabIndex = 30;
            label10.Text = "凯润";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label11.Location = new Point(945, 104);
            label11.Name = "label11";
            label11.Size = new Size(88, 26);
            label11.TabIndex = 31;
            label11.Text = "运行状态";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1751, 921);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(RunCodePath);
            Controls.Add(button4);
            Controls.Add(PathJueDui);
            Controls.Add(pycode);
            Controls.Add(button3);
            Controls.Add(labelFilePath);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(DescriedSoft);
            Controls.Add(label3);
            Controls.Add(NowTimeText);
            Controls.Add(StopWind);
            Controls.Add(RunWind);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "自动风电上报--河南南阳--现场";
            Load += Form1_Load;
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
        private Label label2;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label label6;
        private Button button2;
        private Label labelFilePath;
        private Button button3;
        private Label pycode;
        private Label PathJueDui;
        private ToolTip toolTip;
        private Button button4;
        private Label RunCodePath;
        private Label label1;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label7;
        private Label label8;
        private Button button9;
        private Button button10;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label10;
        private Label label11;
    }
}
