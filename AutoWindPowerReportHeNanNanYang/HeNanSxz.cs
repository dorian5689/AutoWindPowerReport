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
    public partial class HeNanSxz : Form
    {
  
        private string pythonRelativePathSxz = @"auto\Python3911\python.exe";
        private string scriptRelativePathSxz = @"auto\RunTask\run_henan_oms.py";
  
        private Process pythonProcess; // 存储启动的Python进程
        private bool cmdOpenClose = true;
        public HeNanSxz()
        {
            InitializeComponent();
 
        }

        private void HeNanSxz_Load(object sender, EventArgs e)
        {
        }
        private void RunCommandAsAdministratorSzx(string pythonRelativePathSxz, string scriptRelativePathSxz, bool cmdOpenClose)
        {
            try
            {

                // 带python 调试功能
                {

                    // 启动Python进程
                    // 启动Python进程
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = pythonRelativePathSxz;
                    startInfo.Arguments = scriptRelativePathSxz;
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
                    MessageBox.Show("程序开始运行");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法以管理员权限运行命令: " + ex.Message);
            }
        }

        private void HeNanSxzRun_Click(object sender, EventArgs e)
        {
            RunCommandAsAdministratorSzx(pythonRelativePathSxz, scriptRelativePathSxz, cmdOpenClose);

            //MessageBox.Show("开始运行!");
            HeNanSxzRun.Enabled = false;
            HeNanSxzStop.Enabled = true;
        }



        private void HeNanSxzStop_Click(object sender, EventArgs e)
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
                    HeNanSxzRun.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"终止Python脚本失败: {ex.Message}");
                    HeNanSxzStop.Enabled = true;


                }
            }
            else
            {
                MessageBox.Show("没有正在运行的程序可供终止");
                HeNanSxzRun.Enabled = true;

            }

            HeNanSxzRun.Enabled = true;
            HeNanSxzStop.Enabled = false;
        }

        private void HeNanSxzDebug_Click(object sender, EventArgs e)
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

        public void HeNanSxzTimer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            if (now.Hour == 17&& now.Minute == 00 && now.Second == 00)
            {
                this.SxzNowTimeText.Text = DateTime.Now.ToString("HH:mm:ss");

                RunCommandAsAdministratorSzx(pythonRelativePathSxz, scriptRelativePathSxz, cmdOpenClose);

                MessageBox.Show("程序双细则开始运行了！");
                //// 如果只需要在1:06显示一次，可以在此处停止定时器或添加一个开关变量
                HeNanSxzRun.Enabled = false;
                HeNanSxzStop.Enabled = true;
            }
            else
            {
                this.SxzNowTimeText.Text = DateTime.Now.ToString("HH:mm:ss");

            }
        }

    }
}
