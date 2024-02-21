using System.Diagnostics;
using System.Reflection.Emit;
using System.Threading;
using System.Windows.Forms;

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
        private bool cmdOpenClose = true;
        private string _pythonExePath = null;
        private bool _button2EnabledState = true;
        private string pythonPath1;
        private string pathToScript2;


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
            // 初始化时禁用button2和button3
            button2.Enabled = true;
            button3.Enabled = false;
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            // 为DateTimePicker的ValueChanged事件绑定处理程序
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;

            this.FormClosing += MainForm_FormClosing;
        }
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // 获取当前选择的日期时间值
            DateTime selectedDate = dateTimePicker1.Value;

            // 将选择的日期时间格式化为字符串，并添加到label1中
            string formattedDate = selectedDate.ToString("yyyy-MM-dd HH:mm:ss"); // 根据需要调整格式
            RunCodePath.Text += $"\n定时执行的日期: {formattedDate}";

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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要切换状态吗？", "确认操作", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 切换状态
                cmdOpenClose = !cmdOpenClose;

                // 根据状态更改按钮文本
                if (cmdOpenClose)
                {
                    ((Button)sender).Text = "关闭";
                }
                else
                {
                    ((Button)sender).Text = "开启";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 当button1被点击时，切换button2的启用状态

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable Files (*.exe)|*.exe";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(filePath);


                // 检查所选文件是否是python.exe
                if (Path.GetFileName(filePath).ToLower() == "python.exe")
                {
                    _pythonExePath = filePath;
                    // 确保".py"文件选择按钮可用
                    labelFilePath.Text = fileName;
                    button2.Enabled = false;
                    button3.Enabled = true;


                    toolTip.SetToolTip(labelFilePath, filePath);
                    pathToScript2 = filePath;
                    RunCodePath.Text = $"选择解释器: {filePath}";
                }

                else
                {
                    button3.Enabled = false;
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_pythonExePath == null)
            {
                MessageBox.Show("请先选择Python解释器！");
                return;
            }

            OpenFileDialog scriptOpenFileDialog = new OpenFileDialog();
            scriptOpenFileDialog.Filter = "Python Script (*.py)|*.py";

            if (scriptOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = scriptOpenFileDialog.FileName;
                string fileName = Path.GetFileName(filePath);


                // 检查选定的文件是否确实是以.py结尾
                if (!filePath.EndsWith(".py", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("请选择一个正确的Python脚本文件（.py）！");
                }
                else
                {
                    pycode.Text = fileName; // 假设'pycode'是显示脚本路径的控件
                    toolTip.SetToolTip(pycode, filePath);

                    button3.Enabled = false;
                    pythonPath1 = filePath;
                    RunCodePath.Text += $"\n选择脚本: {filePath}";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RunCommandAsAdministrator(pythonPath1, pathToScript2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChoosePy();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void ChoosePy()
        {
            // 当button1被点击时，切换button2的启用状态

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable Files (*.exe)|*.exe";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(filePath);


                // 检查所选文件是否是python.exe
                if (Path.GetFileName(filePath).ToLower() == "python.exe")
                {
                    _pythonExePath = filePath;
                    // 确保".py"文件选择按钮可用
                    labelFilePath.Text = fileName;
                    button2.Enabled = false;
                    button3.Enabled = true;


                    toolTip.SetToolTip(labelFilePath, filePath);
                    pathToScript2 = filePath;
                    RunCodePath.Text = $"选择解释器: {filePath}";
                }

                else
                {
                    button3.Enabled = false;
                }

            }
        }

        private void RunPyPath(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable Files (*.exe)|*.exe";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(filePath);


                // 检查所选文件是否是python.exe
                if (Path.GetFileName(filePath).ToLower() == "python.exe")
                {
                    _pythonExePath = filePath;
                    // 确保".py"文件选择按钮可用
                    labelFilePath.Text = fileName;
                    button2.Enabled = false;
                    button3.Enabled = true;


                    toolTip.SetToolTip(labelFilePath, filePath);
                    pathToScript2 = filePath;
                    RunCodePath.Text = $"选择解释器: {filePath}";
                }

                else
                {
                    button3.Enabled = false;
                }

            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pycode_Click(object sender, EventArgs e)
        {

        }
    }

}
