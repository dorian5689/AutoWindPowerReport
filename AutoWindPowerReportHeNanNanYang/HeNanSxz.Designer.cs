namespace AutoWindPowerReport
{
    partial class HeNanSxz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HeNanSxzRun = new Button();
            HeNanSxzStop = new Button();
            HeNanSxzDebug = new Button();
            NowTimeLable = new Label();
            SxzNowTimeText = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // HeNanSxzRun
            // 
            HeNanSxzRun.Location = new Point(186, 69);
            HeNanSxzRun.Name = "HeNanSxzRun";
            HeNanSxzRun.Size = new Size(361, 104);
            HeNanSxzRun.TabIndex = 0;
            HeNanSxzRun.Text = "运行";
            HeNanSxzRun.UseVisualStyleBackColor = true;
            HeNanSxzRun.Click += HeNanSxzRun_Click;
            // 
            // HeNanSxzStop
            // 
            HeNanSxzStop.Enabled = false;
            HeNanSxzStop.Location = new Point(186, 231);
            HeNanSxzStop.Name = "HeNanSxzStop";
            HeNanSxzStop.Size = new Size(361, 110);
            HeNanSxzStop.TabIndex = 1;
            HeNanSxzStop.Text = "停止";
            HeNanSxzStop.UseVisualStyleBackColor = true;
            HeNanSxzStop.Click += HeNanSxzStop_Click;
            // 
            // HeNanSxzDebug
            // 
            HeNanSxzDebug.Location = new Point(593, 257);
            HeNanSxzDebug.Name = "HeNanSxzDebug";
            HeNanSxzDebug.Size = new Size(158, 84);
            HeNanSxzDebug.TabIndex = 2;
            HeNanSxzDebug.Text = "现在是关闭状态";
            HeNanSxzDebug.UseVisualStyleBackColor = true;
            HeNanSxzDebug.Click += HeNanSxzDebug_Click;
            // 
            // NowTimeLable
            // 
            NowTimeLable.AutoSize = true;
            NowTimeLable.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            NowTimeLable.Location = new Point(265, 17);
            NowTimeLable.Name = "NowTimeLable";
            NowTimeLable.Size = new Size(93, 26);
            NowTimeLable.TabIndex = 3;
            NowTimeLable.Text = "当前时间:";
            // 
            // SxzNowTimeText
            // 
            SxzNowTimeText.AutoSize = true;
            SxzNowTimeText.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            SxzNowTimeText.Location = new Point(375, 17);
            SxzNowTimeText.Name = "SxzNowTimeText";
            SxzNowTimeText.Size = new Size(58, 26);
            SxzNowTimeText.TabIndex = 4;
            SxzNowTimeText.Text = "QAQ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(642, 231);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 5;
            label1.Text = "开发者模式";
            // 
            // button1
            // 
            button1.Location = new Point(186, 391);
            button1.Name = "button1";
            button1.Size = new Size(361, 47);
            button1.TabIndex = 6;
            button1.Text = "默认运行时间17:00:00";
            button1.UseVisualStyleBackColor = true;
            // 
            // HeNanSxz
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(SxzNowTimeText);
            Controls.Add(NowTimeLable);
            Controls.Add(HeNanSxzDebug);
            Controls.Add(HeNanSxzStop);
            Controls.Add(HeNanSxzRun);
            Name = "HeNanSxz";
            Text = "HeNanSxz";
            Load += HeNanSxz_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HeNanSxzRun;
        private Button HeNanSxzStop;
        private Button HeNanSxzDebug;
        private Label NowTimeLable;
        private Label SxzNowTimeText;
        private Label label1;
        private Button button1;
    }
}