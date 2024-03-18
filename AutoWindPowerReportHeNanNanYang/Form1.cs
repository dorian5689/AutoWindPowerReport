using System.Diagnostics;
using System.Threading;

namespace AutoWindPowerReport
{
    public partial class Form1 : Form
    {

        private Mutex mutex;
        private string currentPath; // ����    
        private string pythonRelativePath = @"auto\Python3911\python.exe";
        private string scriptRelativePath = @"auto\RunTask\run_henan_oms.py";
        private string pythonPath;
        private string scriptPath;
        private Process pythonProcess; // �洢������Python����
        private System.Windows.Forms.Timer timer1MinuteCheck;
        private System.Windows.Forms.Timer timer1MinuteCheck2;
        private System.Windows.Forms.Timer timer1MinuteCheck3;
        private System.Windows.Forms.Timer timer1MinuteCheckSjts;
        private System.Windows.Forms.Timer timer1MinuteCheckQxjc;
        private bool cmdOpenClose = true;
        private bool isButtonEnabledSxz = true; // ����һ������������¼��ť״̬��Ĭ��Ϊtrue��������
        private bool isButtonEnabledSdtz = true; // ����һ������������¼��ť״̬��Ĭ��Ϊtrue��������
        private bool isButtonEnabledSjts = true; // ����һ������������¼��ť״̬��Ĭ��Ϊtrue��������
        private bool isButtonEnabledQxjc = true; // ����һ������������¼��ť״̬��Ĭ��Ϊtrue��������


        public Form1()
        {
            // ���������Ի�ȡ������
            bool createdNewsxz;
            mutex = new Mutex(true, "{�Զ�����ϱ�--����ʡ�������ֳ�}", out createdNewsxz);
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



            // ˫ϸ��
            timer1MinuteCheck2 = new System.Windows.Forms.Timer();
            timer1MinuteCheck2.Interval = 1000;
            // ����HeNanSxzʵ����ȷ�����캯��û���׳��쳣
            HeNanSxz Sxz = new HeNanSxz();
            // ���¼�
            timer1MinuteCheck2.Tick += Sxz.HeNanSxzTimer1_Tick;
            // ������ʱ��
            timer1MinuteCheck2.Start();



            //ʡ��֪ͨtimer��ʼ��
            timer1MinuteCheck3 = new System.Windows.Forms.Timer();
            timer1MinuteCheck3.Interval = 1000;
            // ����HeNanSxzʵ����ȷ�����캯��û���׳��쳣
            HeNanSdtz Sdtz = new HeNanSdtz();
            // ���¼�
            timer1MinuteCheck3.Tick += Sdtz.HeNanSdtzTimer1_Tick;
            // ������ʱ��
            timer1MinuteCheck3.Start();


            //��������timer��ʼ��
            timer1MinuteCheckSjts = new System.Windows.Forms.Timer();
            timer1MinuteCheckSjts.Interval = 1000;
            // ����HeNanSxzʵ����ȷ�����캯��û���׳��쳣
            HeNanSjts Sjts = new HeNanSjts();
            // ���¼�
            timer1MinuteCheckSjts.Tick += Sjts.HeNanSjtsTimer1_Tick;
            // ������ʱ��
            timer1MinuteCheckSjts.Start();



            //ȱ�ݼ��timer��ʼ��
            timer1MinuteCheckQxjc = new System.Windows.Forms.Timer();
            timer1MinuteCheckQxjc.Interval = 1000;
            // ����HeNanSxzʵ����ȷ�����캯��û���׳��쳣
            HenanQxjc Qxjc = new HenanQxjc();
            // ���¼�
            timer1MinuteCheckQxjc.Tick += Qxjc.HeNanQxjcTimer1_Tick;
            // ������ʱ��
            timer1MinuteCheckQxjc.Start();


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

            if     if ((now.Hour == 00 && now.Minute == 12 && now.Second == 00) || (now.Hour == 00 && now.Minute == 40 && now.Second == 00))
                {
                this.label3.Text = DateTime.Now.ToString("HH:mm:ss");

                RunCommandAsAdministrator(pythonPath, scriptPath);

                MessageBox.Show("����OMS��ʼ�����ˣ�");
                // ���ֻ��Ҫ��1:06��ʾһ�Σ������ڴ˴�ֹͣ��ʱ�������һ�����ر���
                // timer1MinuteCheck.Stop();
                RunWind.Enabled = false;
                StopWind.Enabled = true;
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HeNanSxz f2 = new HeNanSxz();
            this.Hide();
            f2.ShowDialog();
            //this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HeNanSdtz f2 = new HeNanSdtz();
            this.Hide();
            f2.ShowDialog();
            //this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HeNanSjts f2 = new HeNanSjts();
            this.Hide();
            f2.ShowDialog();
            //this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HenanQxjc f2 = new HenanQxjc();
            this.Hide();
            f2.ShowDialog();
            //this.Dispose();
        }

        private void NowTimeText_Click(object sender, EventArgs e)
        {

        }

        private void HeNanSxzButtonClose_Click(object sender, EventArgs e)
        {
            if (isButtonEnabledSxz)
            {
                HeNanSxzButton.Enabled = false; // ��ǰ״̬Ϊ������������Ϊ�ر�
                HeNanSxzButtonClose.Text = "�ر�״̬";
                isButtonEnabledSxz = false; // ���²�������״̬Ϊfalse
            }
            else
            {
                HeNanSxzButton.Enabled = true; // ��ǰ״̬Ϊ�رգ�������Ϊ����
                HeNanSxzButtonClose.Text = "����״̬";
                isButtonEnabledSxz = true; // ���²�������״̬Ϊtrue
            }



        }

        private void HeNanSdtzButtonClose_Click(object sender, EventArgs e)
        {

            if (isButtonEnabledSdtz)
            {
                HeNanSdtzButton.Enabled = false; // ��ǰ״̬Ϊ������������Ϊ�ر�
                HeNanSdtzButtonClose.Text = "�ر�״̬";
                isButtonEnabledSdtz = false; // ���²�������״̬Ϊfalse
            }
            else
            {
                HeNanSdtzButton.Enabled = true; // ��ǰ״̬Ϊ�رգ�������Ϊ����
                HeNanSdtzButtonClose.Text = "����״̬";
                isButtonEnabledSdtz = true; // ���²�������״̬Ϊtrue
            }



        }

        private void HeNanQxjcButtonClose_Click(object sender, EventArgs e)
        {
            if (isButtonEnabledQxjc)
            {
                HeNanQxjcButton1.Enabled = false; // ��ǰ״̬Ϊ������������Ϊ�ر�
                HeNanQxjcButtonClose.Text = "�ر�״̬";
                isButtonEnabledQxjc = false; // ���²�������״̬Ϊfalse
            }
            else
            {
                HeNanQxjcButton1.Enabled = true; // ��ǰ״̬Ϊ�رգ�������Ϊ����
                HeNanQxjcButtonClose.Text = "����״̬";
                isButtonEnabledQxjc = true; // ���²�������״̬Ϊtrue
            }


        }

        private void HeNanSjtsButtonClose_Click(object sender, EventArgs e)
        {
            if (isButtonEnabledSjts)
            {
                HeNanSjtsButton.Enabled = false; // ��ǰ״̬Ϊ������������Ϊ�ر�
                HeNanSjtsButtonClose.Text = "�ر�״̬";
                isButtonEnabledSjts = false; // ���²�������״̬Ϊfalse
            }
            else
            {
                HeNanSjtsButton.Enabled = true; // ��ǰ״̬Ϊ�رգ�������Ϊ����
                HeNanSjtsButtonClose.Text = "����״̬";
                isButtonEnabledSjts = true; // ���²�������״̬Ϊtrue
            }

        }
    }

}
