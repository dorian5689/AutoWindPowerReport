using System.Diagnostics;
using System.Reflection.Emit;
using System.Threading;
using System.Windows.Forms;

namespace AutoWindPowerReport
{
    public partial class Form1 : Form
    {

        private Mutex mutex;
        private string currentPath; // ����    
        private string pythonRelativePath = @"C:\Python3911\python.exe";
        private string scriptRelativePath = @"henan_oms_zz\Runtask\run.py";
        private string pythonPath;
        private string scriptPath;
        private Process pythonProcess; // �洢������Python����
        private System.Windows.Forms.Timer timer1MinuteCheck;
        private bool cmdOpenClose = true;
        private string _pythonExePath = null;
        private bool _button2EnabledState = true;
        private string pythonPath1;
        private string pathToScript2;


        public Form1()
        {
            // ���������Ի�ȡ������
            bool createdNewsxz;
            mutex = new Mutex(true, "{�Զ�����ϱ�--���������ֳ�}", out createdNewsxz);
            if (!createdNewsxz)
            {
                // �������Ѿ����ڣ�˵���Ѿ���ʵ��������
                MessageBox.Show("�����������У������ظ��򿪣�");
                Environment.Exit(0);
            }

            try
            {
                currentPath = Directory.GetCurrentDirectory(); // �ڹ��캯���г�ʼ��      
                pythonPath = CombinePath(currentPath, pythonRelativePath);
                scriptPath = CombinePath(currentPath, scriptRelativePath);
                // GetExePath();
            }
            catch (Exception ex)
            {
                // ������Լ�¼�������ʾ������Ϣ���û�  
                MessageBox.Show("��ʼ��·��ʱ����: " + ex.Message);
            }

            timer1MinuteCheck = new System.Windows.Forms.Timer();
            timer1MinuteCheck.Interval = 1000; // ���ü��Ϊ1�루Ϊ��ʵʱ���ʱ�䣩
            timer1MinuteCheck.Tick += timer1_Tick;
            timer1MinuteCheck.Start();
            InitializeComponent();
            // ��ʼ��ʱ����button2��button3
            button2.Enabled = true;
            button3.Enabled = false;
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            // ΪDateTimePicker��ValueChanged�¼��󶨴������
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;

            this.FormClosing += MainForm_FormClosing;
        }
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // ��ȡ��ǰѡ�������ʱ��ֵ
            DateTime selectedDate = dateTimePicker1.Value;

            // ��ѡ�������ʱ���ʽ��Ϊ�ַ���������ӵ�label1��
            string formattedDate = selectedDate.ToString("yyyy-MM-dd HH:mm:ss"); // ������Ҫ������ʽ
            RunCodePath.Text += $"\n��ʱִ�е�����: {formattedDate}";

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // ��������������ǹر�
                this.Hide();

                // ����FormClosing�¼���������ֹ���屻�ر�
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

                MessageBox.Show("����ʼ�����ˣ�");
                // ���ֻ��Ҫ��1:06��ʾһ�Σ������ڴ˴�ֹͣ��ʱ�������һ�����ر���
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

                // ��python ���Թ���
                {

                    // ����Python����
                    // ����Python����
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = pythonRelativePath;
                    startInfo.Arguments = scriptRelativePath;
                    startInfo.CreateNoWindow = cmdOpenClose;
                    pythonProcess = Process.Start(startInfo);

                    // ��¼����ID
                    int processId = pythonProcess.Id;
                    // �����ڴ˴��������ʾ����ID�Ա����

                    // ��¼����ID


                    //}
                    //{
                    // ����python ���Թ��� �ڴ���������

                    //process.StartInfo.FileName = command;
                    //process.StartInfo.Arguments = arguments;
                    //process.StartInfo.UseShellExecute = false;
                    //process.StartInfo.CreateNoWindow = true;
                    //process.StartInfo.Verb = "runas";

                    //process.Start();
                    //MessageBox.Show("����ʼ����");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("�޷��Թ���ԱȨ����������: " + ex.Message);
            }
        }
        private void RunWind_Click(object sender, EventArgs e)
        {
            RunCommandAsAdministrator(pythonPath, scriptPath);

            //MessageBox.Show("��ʼ����!");
            RunWind.Enabled = false;
            StopWind.Enabled = true;

        }

        private void StopWind_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("��ʼ�ر�!");

            if (pythonProcess != null && !pythonProcess.HasExited)
            {
                try
                {
                    // ����Python����
                    pythonProcess.Kill();
                    pythonProcess.WaitForExit(); // �ȴ�������ȫ�˳�
                    pythonProcess.Close();
                    pythonProcess.Dispose();
                    pythonProcess = null;

                    MessageBox.Show("Python�ű��ѳɹ���ֹ");
                    RunWind.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"��ֹPython�ű�ʧ��: {ex.Message}");
                    RunWind.Enabled = true;


                }
            }
            else
            {
                MessageBox.Show("û���������еĳ���ɹ���ֹ");
                RunWind.Enabled = true;

            }

            RunWind.Enabled = true;
            StopWind.Enabled = false;



        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Show(); //������ʾ
            this.WindowState = FormWindowState.Normal; //����״̬Ĭ�ϴ�С
            this.Activate(); //�������轹��
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide(); //���ش���

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ȷ��Ҫ�˳�����?", "��ȫ��ʾ",
                System.Windows.Forms.MessageBoxButtons.YesNo,
                System.Windows.Forms.MessageBoxIcon.Warning)
                    == System.Windows.Forms.DialogResult.Yes)
                notifyIcon1.Visible = false; //����ͼ�겻�ɼ�
            this.Close(); //�رմ���
            this.Dispose(); //�ͷ���Դ
            Application.Exit(); //�ر�Ӧ�ó�����
        }

        private void NowTime_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ȷ��Ҫ�л�״̬��", "ȷ�ϲ���", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // �л�״̬
                cmdOpenClose = !cmdOpenClose;

                // ����״̬���İ�ť�ı�
                if (cmdOpenClose)
                {
                    ((Button)sender).Text = "�ر�";
                }
                else
                {
                    ((Button)sender).Text = "����";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ��button1�����ʱ���л�button2������״̬

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable Files (*.exe)|*.exe";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(filePath);


                // �����ѡ�ļ��Ƿ���python.exe
                if (Path.GetFileName(filePath).ToLower() == "python.exe")
                {
                    _pythonExePath = filePath;
                    // ȷ��".py"�ļ�ѡ��ť����
                    labelFilePath.Text = fileName;
                    button2.Enabled = false;
                    button3.Enabled = true;


                    toolTip.SetToolTip(labelFilePath, filePath);
                    pathToScript2 = filePath;
                    RunCodePath.Text = $"ѡ�������: {filePath}";
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
                MessageBox.Show("����ѡ��Python��������");
                return;
            }

            OpenFileDialog scriptOpenFileDialog = new OpenFileDialog();
            scriptOpenFileDialog.Filter = "Python Script (*.py)|*.py";

            if (scriptOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = scriptOpenFileDialog.FileName;
                string fileName = Path.GetFileName(filePath);


                // ���ѡ�����ļ��Ƿ�ȷʵ����.py��β
                if (!filePath.EndsWith(".py", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("��ѡ��һ����ȷ��Python�ű��ļ���.py����");
                }
                else
                {
                    pycode.Text = fileName; // ����'pycode'����ʾ�ű�·���Ŀؼ�
                    toolTip.SetToolTip(pycode, filePath);

                    button3.Enabled = false;
                    pythonPath1 = filePath;
                    RunCodePath.Text += $"\nѡ��ű�: {filePath}";
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
            // ��button1�����ʱ���л�button2������״̬

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable Files (*.exe)|*.exe";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(filePath);


                // �����ѡ�ļ��Ƿ���python.exe
                if (Path.GetFileName(filePath).ToLower() == "python.exe")
                {
                    _pythonExePath = filePath;
                    // ȷ��".py"�ļ�ѡ��ť����
                    labelFilePath.Text = fileName;
                    button2.Enabled = false;
                    button3.Enabled = true;


                    toolTip.SetToolTip(labelFilePath, filePath);
                    pathToScript2 = filePath;
                    RunCodePath.Text = $"ѡ�������: {filePath}";
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


                // �����ѡ�ļ��Ƿ���python.exe
                if (Path.GetFileName(filePath).ToLower() == "python.exe")
                {
                    _pythonExePath = filePath;
                    // ȷ��".py"�ļ�ѡ��ť����
                    labelFilePath.Text = fileName;
                    button2.Enabled = false;
                    button3.Enabled = true;


                    toolTip.SetToolTip(labelFilePath, filePath);
                    pathToScript2 = filePath;
                    RunCodePath.Text = $"ѡ�������: {filePath}";
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
