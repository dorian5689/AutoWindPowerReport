namespace AutoWindPowerReport
{
    partial class HeNanSjts
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
            SjtsNowTimeText = new Label();
            SjtsNowTimeLable = new Label();
            HeNanSjtsDebug = new Button();
            HeNanSjtsStop = new Button();
            HeNanSjtsRun = new Button();
            SuspendLayout();
            // 
            // SjtsMoRenButton
            // 
            SjtsMoRenButton.Location = new Point(118, 389);
            SjtsMoRenButton.Name = "SjtsMoRenButton";
            SjtsMoRenButton.Size = new Size(361, 47);
            SjtsMoRenButton.TabIndex = 20;
            SjtsMoRenButton.Text = "默认运行时间00:01:00";
            SjtsMoRenButton.UseVisualStyleBackColor = true;
            // 
            // SjtsKfzms
            // 
            SjtsKfzms.AutoSize = true;
            SjtsKfzms.Location = new Point(574, 229);
            SjtsKfzms.Name = "SjtsKfzms";
            SjtsKfzms.Size = new Size(68, 17);
            SjtsKfzms.TabIndex = 19;
            SjtsKfzms.Text = "开发者模式";
            // 
            // SjtsNowTimeText
            // 
            SjtsNowTimeText.AutoSize = true;
            SjtsNowTimeText.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            SjtsNowTimeText.Location = new Point(307, 15);
            SjtsNowTimeText.Name = "SjtsNowTimeText";
            SjtsNowTimeText.Size = new Size(58, 26);
            SjtsNowTimeText.TabIndex = 18;
            SjtsNowTimeText.Text = "QAQ";
            // 
            // SjtsNowTimeLable
            // 
            SjtsNowTimeLable.AutoSize = true;
            SjtsNowTimeLable.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            SjtsNowTimeLable.Location = new Point(197, 15);
            SjtsNowTimeLable.Name = "SjtsNowTimeLable";
            SjtsNowTimeLable.Size = new Size(93, 26);
            SjtsNowTimeLable.TabIndex = 17;
            SjtsNowTimeLable.Text = "当前时间:";
            // 
            // HeNanSjtsDebug
            // 
            HeNanSjtsDebug.Location = new Point(525, 255);
            HeNanSjtsDebug.Name = "HeNanSjtsDebug";
            HeNanSjtsDebug.Size = new Size(158, 84);
            HeNanSjtsDebug.TabIndex = 16;
            HeNanSjtsDebug.Text = "现在是关闭状态";
            HeNanSjtsDebug.UseVisualStyleBackColor = true;
            HeNanSjtsDebug.Click += HeNanSjtsDebug_Click;
            // 
            // HeNanSjtsStop
            // 
            HeNanSjtsStop.Enabled = false;
            HeNanSjtsStop.Location = new Point(118, 229);
            HeNanSjtsStop.Name = "HeNanSjtsStop";
            HeNanSjtsStop.Size = new Size(361, 110);
            HeNanSjtsStop.TabIndex = 15;
            HeNanSjtsStop.Text = "停止";
            HeNanSjtsStop.UseVisualStyleBackColor = true;
            HeNanSjtsStop.Click += HeNanSjtsStop_Click;
            // 
            // HeNanSjtsRun
            // 
            HeNanSjtsRun.Location = new Point(118, 67);
            HeNanSjtsRun.Name = "HeNanSjtsRun";
            HeNanSjtsRun.Size = new Size(361, 104);
            HeNanSjtsRun.TabIndex = 14;
            HeNanSjtsRun.Text = "运行";
            HeNanSjtsRun.UseVisualStyleBackColor = true;
            HeNanSjtsRun.Click += HeNanSjtsRun_Click;
            // 
            // HeNanSjts
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SjtsMoRenButton);
            Controls.Add(SjtsKfzms);
            Controls.Add(SjtsNowTimeText);
            Controls.Add(SjtsNowTimeLable);
            Controls.Add(HeNanSjtsDebug);
            Controls.Add(HeNanSjtsStop);
            Controls.Add(HeNanSjtsRun);
            Name = "HeNanSjts";
            Text = "HeNanSjts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SjtsMoRenButton;
        private Label SjtsKfzms;
        private Label SjtsNowTimeText;
        private Label SjtsNowTimeLable;
        private Button HeNanSjtsDebug;
        private Button HeNanSjtsStop;
        private Button HeNanSjtsRun;
    }
}