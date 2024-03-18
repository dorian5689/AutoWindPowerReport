namespace AutoWindPowerReport
{
    partial class HenanQxjc
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
            SjtsMoRenButton = new Button();
            SjtsKfzms = new Label();
            QxjcNowTimeText = new Label();
            QxjcNowTimeLable = new Label();
            HeNanQxjcDebug = new Button();
            HeNanQxjcStop = new Button();
            HeNanQxjcRun = new Button();
            SuspendLayout();
            // 
            // SjtsMoRenButton
            // 
            SjtsMoRenButton.Location = new Point(118, 389);
            SjtsMoRenButton.Name = "SjtsMoRenButton";
            SjtsMoRenButton.Size = new Size(361, 47);
            SjtsMoRenButton.TabIndex = 27;
            SjtsMoRenButton.Text = "默认运行时间15:00:00";
            SjtsMoRenButton.UseVisualStyleBackColor = true;
            // 
            // SjtsKfzms
            // 
            SjtsKfzms.AutoSize = true;
            SjtsKfzms.Location = new Point(574, 229);
            SjtsKfzms.Name = "SjtsKfzms";
            SjtsKfzms.Size = new Size(68, 17);
            SjtsKfzms.TabIndex = 26;
            SjtsKfzms.Text = "开发者模式";
            // 
            // QxjcNowTimeText
            // 
            QxjcNowTimeText.AutoSize = true;
            QxjcNowTimeText.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            QxjcNowTimeText.Location = new Point(307, 15);
            QxjcNowTimeText.Name = "QxjcNowTimeText";
            QxjcNowTimeText.Size = new Size(58, 26);
            QxjcNowTimeText.TabIndex = 25;
            QxjcNowTimeText.Text = "QAQ";
            // 
            // QxjcNowTimeLable
            // 
            QxjcNowTimeLable.AutoSize = true;
            QxjcNowTimeLable.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            QxjcNowTimeLable.Location = new Point(197, 15);
            QxjcNowTimeLable.Name = "QxjcNowTimeLable";
            QxjcNowTimeLable.Size = new Size(93, 26);
            QxjcNowTimeLable.TabIndex = 24;
            QxjcNowTimeLable.Text = "当前时间:";
            // 
            // HeNanQxjcDebug
            // 
            HeNanQxjcDebug.Location = new Point(525, 255);
            HeNanQxjcDebug.Name = "HeNanQxjcDebug";
            HeNanQxjcDebug.Size = new Size(158, 84);
            HeNanQxjcDebug.TabIndex = 23;
            HeNanQxjcDebug.Text = "现在是关闭状态";
            HeNanQxjcDebug.UseVisualStyleBackColor = true;
            HeNanQxjcDebug.Click += HeNanQxjcDebug_Click;
            // 
            // HeNanQxjcStop
            // 
            HeNanQxjcStop.Enabled = false;
            HeNanQxjcStop.Location = new Point(118, 229);
            HeNanQxjcStop.Name = "HeNanQxjcStop";
            HeNanQxjcStop.Size = new Size(361, 110);
            HeNanQxjcStop.TabIndex = 22;
            HeNanQxjcStop.Text = "停止";
            HeNanQxjcStop.UseVisualStyleBackColor = true;
            HeNanQxjcStop.Click += HeNanQxjcStop_Click;
            // 
            // HeNanQxjcRun
            // 
            HeNanQxjcRun.Location = new Point(118, 67);
            HeNanQxjcRun.Name = "HeNanQxjcRun";
            HeNanQxjcRun.Size = new Size(361, 104);
            HeNanQxjcRun.TabIndex = 21;
            HeNanQxjcRun.Text = "运行";
            HeNanQxjcRun.UseVisualStyleBackColor = true;
            HeNanQxjcRun.Click += HeNanQxjcRun_Click;
            // 
            // HenanQxjc
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SjtsMoRenButton);
            Controls.Add(SjtsKfzms);
            Controls.Add(QxjcNowTimeText);
            Controls.Add(QxjcNowTimeLable);
            Controls.Add(HeNanQxjcDebug);
            Controls.Add(HeNanQxjcStop);
            Controls.Add(HeNanQxjcRun);
            Name = "HenanQxjc";
            Text = "HenanQxjc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SjtsMoRenButton;
        private Label SjtsKfzms;
        private Label QxjcNowTimeText;
        private Label QxjcNowTimeLable;
        private Button HeNanQxjcDebug;
        private Button HeNanQxjcStop;
        private Button HeNanQxjcRun;
    }
}