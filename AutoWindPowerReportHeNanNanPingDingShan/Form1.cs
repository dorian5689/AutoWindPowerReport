using System.Diagnostics;
using System.Threading;

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
        private bool cmdOpenClose = false;



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

            this.FormClosing += MainForm_FormClosing;
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

        private void TiaoShi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ȷ��Ҫ�л�״̬��", "ȷ�ϲ���", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // �л�״̬
                cmdOpenClose = !cmdOpenClose;

                // ����״̬���İ�ť�ı�
                if (cmdOpenClose)
                {
                    ((Button)sender).Text = "����";
                }
                else
                {
                    ((Button)sender).Text = "�ر�";
                }
            }

        }
    }

}
