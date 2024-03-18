namespace AutoWindPowerReport
{
    partial class HeNanSdtz
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
            SdtzMoRenButton = new Button();
            SdtzKfzms = new Label();
            SdtzNowTimeText = new Label();
            SdtzNowTimeLable = new Label();
            HeNanSdtzDebug = new Button();
            HeNanSdtzStop = new Button();
            HeNanSdtzRun = new Button();
            SuspendLayout();
            // 
            // SdtzMoRenButton
            // 
            SdtzMoRenButton.Location = new Point(118, 389);
            SdtzMoRenButton.Name = "SdtzMoRenButton";
            SdtzMoRenButton.Size = new Size(361, 47);
            SdtzMoRenButton.TabIndex = 13;
            SdtzMoRenButton.Text = "默认运行时间09:00:00";
            SdtzMoRenButton.UseVisualStyleBackColor = true;
            // 
            // SdtzKfzms
            // 
            SdtzKfzms.AutoSize = true;
            SdtzKfzms.Location = new Point(574, 229);
            SdtzKfzms.Name = "SdtzKfzms";
            SdtzKfzms.Size = new Size(68, 17);
            SdtzKfzms.TabIndex = 12;
            SdtzKfzms.Text = "开发者模式";
            // 
            // SdtzNowTimeText
            // 
            SdtzNowTimeText.AutoSize = true;
            SdtzNowTimeText.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            SdtzNowTimeText.Location = new Point(307, 15);
            SdtzNowTimeText.Name = "SdtzNowTimeText";
            SdtzNowTimeText.Size = new Size(58, 26);
            SdtzNowTimeText.TabIndex = 11;
            SdtzNowTimeText.Text = "QAQ";
            // 
            // SdtzNowTimeLable
            // 
            SdtzNowTimeLable.AutoSize = true;
            SdtzNowTimeLable.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            SdtzNowTimeLable.Location = new Point(197, 15);
            SdtzNowTimeLable.Name = "SdtzNowTimeLable";
            SdtzNowTimeLable.Size = new Size(93, 26);
            SdtzNowTimeLable.TabIndex = 10;
            SdtzNowTimeLable.Text = "当前时间:";
            // 
            // HeNanSdtzDebug
            // 
            HeNanSdtzDebug.Location = new Point(525, 255);
            HeNanSdtzDebug.Name = "HeNanSdtzDebug";
            HeNanSdtzDebug.Size = new Size(158, 84);
            HeNanSdtzDebug.TabIndex = 9;
            HeNanSdtzDebug.Text = "现在是关闭状态";
            HeNanSdtzDebug.UseVisualStyleBackColor = true;
            HeNanSdtzDebug.Click += HeNanSdtzDebug_Click;
            // 
            // HeNanSdtzStop
            // 
            HeNanSdtzStop.Enabled = false;
            HeNanSdtzStop.Location = new Point(118, 229);
            HeNanSdtzStop.Name = "HeNanSdtzStop";
            HeNanSdtzStop.Size = new Size(361, 110);
            HeNanSdtzStop.TabIndex = 8;
            HeNanSdtzStop.Text = "停止";
            HeNanSdtzStop.UseVisualStyleBackColor = true;
            HeNanSdtzStop.Click += HeNanSdtzStop_Click;
            // 
            // HeNanSdtzRun
            // 
            HeNanSdtzRun.Location = new Point(118, 67);
            HeNanSdtzRun.Name = "HeNanSdtzRun";
            HeNanSdtzRun.Size = new Size(361, 104);
            HeNanSdtzRun.TabIndex = 7;
            HeNanSdtzRun.Text = "运行";
            HeNanSdtzRun.UseVisualStyleBackColor = true;
            HeNanSdtzRun.Click += HeNanSdtzRun_Click;
            // 
            // HeNanSdtz
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SdtzMoRenButton);
            Controls.Add(SdtzKfzms);
            Controls.Add(SdtzNowTimeText);
            Controls.Add(SdtzNowTimeLable);
            Controls.Add(HeNanSdtzDebug);
            Controls.Add(HeNanSdtzStop);
            Controls.Add(HeNanSdtzRun);
            Name = "HeNanSdtz";
            Text = "HeNanSdtz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SdtzMoRenButton;
        private Label SdtzKfzms;
        private Label SdtzNowTimeText;
        private Label SdtzNowTimeLable;
        private Button HeNanSdtzDebug;
        private Button HeNanSdtzStop;
        private Button HeNanSdtzRun;
    }
}