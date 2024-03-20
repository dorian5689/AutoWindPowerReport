using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoWindPowerReport
{
    public partial class HenanQxjc : Form
    {
        private string pythonRelativePathSdtz = @"auto\Python3911\python.exe";
        private string scriptRelativePathSdtz = @"auto\Runtask\run_henan_qxjc.py";

        private Process pythonProcess; // 存储启动的Python进程
        private System.Windows.Forms.Timer timer1MinuteCheck;
        private bool cmdOpenClose = true;
        public HenanQxjc()

        {

            timer1MinuteCheck = new System.Windows.Forms.Timer();
            timer1MinuteCheck.Interval = 1000; // 设置间隔为1秒（为了实时检测时间）
            timer1MinuteCheck.Tick += HeNanQxjcTimer1_Tick;
            timer1MinuteCheck.Start();
            InitializeComponent();
        }
        private void RunCommandAsAdministratorQxjc(string pythonRelativePathSdtz, string scriptRelativePathSdtz, bool cmdOpenClose)
        {
            try
            {

                // 带python 调试功能
                {

                    // 启动Python进程
                    // 启动Python进程
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = pythonRelativePathSdtz;
                    startInfo.Arguments = scriptRelativePathSdtz;
                    startInfo.CreateNoWindow = cmdOpenClose;
                    pythonProcess = Process.Start(startInfo);

                    // 记录进程ID
                    int processId = pythonProcess.Id;
                    // 可以在此处保存或显示进程ID以便调试

                    // 记录进程ID


                    //}
                    //{
                    // 不带python 调试功能 黑窗口隐藏了

                    //process.StartInfo.FileName = command;
                    //process.StartInfo.Arguments = arguments;
                    //process.StartInfo.UseShellExecute = false;
                    //process.StartInfo.CreateNoWindow = true;
                    //process.StartInfo.Verb = "runas";

                    //process.Start();
                    MessageBox.Show("python缺陷检测程序开始运行");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法以管理员权限运行命令: " + ex.Message);
            }
        }

        private void HeNanQxjcRun_Click(object sender, EventArgs e)
        {
            RunCommandAsAdministratorQxjc(pythonRelativePathSdtz, scriptRelativePathSdtz, cmdOpenClose);

            //MessageBox.Show("开始运行!");
            HeNanQxjcRun.Enabled = false;
            HeNanQxjcStop.Enabled = true;
        }

        private void HeNanQxjcStop_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("开始关闭!");

            if (pythonProcess != null && !pythonProcess.HasExited)
            {
                try
                {
                    // 结束Python进程
                    pythonProcess.Kill();
                    pythonProcess.WaitForExit(); // 等待进程完全退出
                    pythonProcess.Close();
                    pythonProcess.Dispose();
                    pythonProcess = null;

                    MessageBox.Show("Python脚本已成功终止");
                    HeNanQxjcRun.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"终止Python脚本失败: {ex.Message}");
                    HeNanQxjcStop.Enabled = true;


                }
            }
            else
            {
                MessageBox.Show("没有正在运行的程序可供终止");
                HeNanQxjcRun.Enabled = true;

            }

            HeNanQxjcRun.Enabled = true;
            HeNanQxjcStop.Enabled = false;
        }

        private void HeNanQxjcDebug_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要切换状态吗？", "确认操作", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 切换状态
                cmdOpenClose = !cmdOpenClose;

                // 根据状态更改按钮文本
                if (cmdOpenClose)
                {
                    ((Button)sender).Text = "现在是关闭状态";
                }
                else
                {
                    ((Button)sender).Text = "现在是开启状态";
                }
            }
        }
        public void HeNanQxjcTimer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            if (now.Hour == 15 && now.Minute == 00 && now.Second == 00)
            {
                this.QxjcNowTimeText.Text = DateTime.Now.ToString("HH:mm:ss");

                RunCommandAsAdministratorQxjc(pythonRelativePathSdtz, scriptRelativePathSdtz, cmdOpenClose);

                //MessageBox.Show("程序缺陷检测推送开始运行了！");
                //// 如果只需要在1:06显示一次，可以在此处停止定时器或添加一个开关变量
                HeNanQxjcRun.Enabled = false;
                HeNanQxjcStop.Enabled = true;
            }
            else
            {
                this.QxjcNowTimeText.Text = DateTime.Now.ToString("HH:mm:ss");

            }
        }
    }
}