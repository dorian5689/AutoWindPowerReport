using System.Diagnostics;
using System.Threading;

namespace AutoWindPowerReport
{
    public partial class Form1 : Form
    {

        private Mutex mutex;
        private string currentPath; // 声明    
        private string pythonRelativePath = @"C:\Python3911\python.exe";
        private string scriptRelativePath = @"henan_oms_zz\Runtask\run.py";
        private string pythonPath;
        private string scriptPath;
        private Process pythonProcess; // 存储启动的Python进程
        private System.Windows.Forms.Timer timer1MinuteCheck;
        private bool cmdOpenClose = false;



        public Form1()
        {
            // 创建并尝试获取互斥体
            bool createdNewsxz;
            mutex = new Mutex(true, "{自动风电上报--河南南阳现场}", out createdNewsxz);
            if (!createdNewsxz)
            {
                // 互斥体已经存在，说明已经有实例在运行
                MessageBox.Show("程序已在运行，请勿重复打开！");
                Environment.Exit(0);
            }

            try
            {
                currentPath = Directory.GetCurrentDirectory(); // 在构造函数中初始化      
                pythonPath = CombinePath(currentPath, pythonRelativePath);
                scriptPath = CombinePath(currentPath, scriptRelativePath);
                // GetExePath();
            }
            catch (Exception ex)
            {
                // 这里可以记录错误或显示错误消息给用户  
                MessageBox.Show("初始化路径时出错: " + ex.Message);
            }

            timer1MinuteCheck = new System.Windows.Forms.Timer();
            timer1MinuteCheck.Interval = 1000; // 设置间隔为1秒（为了实时检测时间）
            timer1MinuteCheck.Tick += timer1_Tick;
            timer1MinuteCheck.Start();
            InitializeComponent();

            this.FormClosing += MainForm_FormClosing;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // 隐藏主窗体而不是关闭
                this.Hide();

                // 设置FormClosing事件参数，防止窗体被关闭
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            if (now.Hour == 00 && now.Minute == 20 && now.Second == 00)
            {
                this.label3.Text = DateTime.Now.ToString("HH:mm:ss");

                RunCommandAsAdministrator(pythonPath, scriptPath);

                MessageBox.Show("程序开始运行了！");
                // 如果只需要在1:06显示一次，可以在此处停止定时器或添加一个开关变量
                // timer1MinuteCheck.Stop();
            }
            else
            {
                this.label3.Text = DateTime.Now.ToString("HH:mm:ss");

            }
        }
        private string CombinePath(string basePath, string relativePath)
        {
            return Path.Combine(basePath, relativePath);
        }
        private void RunCommandAsAdministrator(string command, string arguments)
        {
            try
            {

                // 带python 调试功能
                {

                    // 启动Python进程
                    // 启动Python进程
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = pythonRelativePath;
                    startInfo.Arguments = scriptRelativePath;
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
                    //MessageBox.Show("程序开始运行");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法以管理员权限运行命令: " + ex.Message);
            }
        }
        private void RunWind_Click(object sender, EventArgs e)
        {
            RunCommandAsAdministrator(pythonPath, scriptPath);

            //MessageBox.Show("开始运行!");
            RunWind.Enabled = false;
            StopWind.Enabled = true;

        }

        private void StopWind_Click(object sender, EventArgs e)
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
                    RunWind.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"终止Python脚本失败: {ex.Message}");
                    RunWind.Enabled = true;


                }
            }
            else
            {
                MessageBox.Show("没有正在运行的程序可供终止");
                RunWind.Enabled = true;

            }

            RunWind.Enabled = true;
            StopWind.Enabled = false;



        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Show(); //窗体显示
            this.WindowState = FormWindowState.Normal; //窗体状态默认大小
            this.Activate(); //激活窗体给予焦点
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide(); //隐藏窗体

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出程序?", "安全提示",
                System.Windows.Forms.MessageBoxButtons.YesNo,
                System.Windows.Forms.MessageBoxIcon.Warning)
                    == System.Windows.Forms.DialogResult.Yes)
                notifyIcon1.Visible = false; //设置图标不可见
            this.Close(); //关闭窗体
            this.Dispose(); //释放资源
            Application.Exit(); //关闭应用程序窗体
        }

        private void NowTime_Click(object sender, EventArgs e)
        {

        }

        private void TiaoShi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要切换状态吗？", "确认操作", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 切换状态
                cmdOpenClose = !cmdOpenClose;

                // 根据状态更改按钮文本
                if (cmdOpenClose)
                {
                    ((Button)sender).Text = "开启";
                }
                else
                {
                    ((Button)sender).Text = "关闭";
                }
            }

        }
    }

}
