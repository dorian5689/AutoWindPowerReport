
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;

namespace AutoWindPowerReportCloseScene
{
    public partial class Form1 : Form
    {

        private string connectionString = "server=soam-mysql-13965e014815e193.elb.cn-northwest-1.amazonaws.com.cn;user id=nanfang;password=5yY7WtANHx2kpc5H;database=nanfang;persistsecurityinfo=True;charset=utf8;";



        private string YaRun = "�����糡";
        private string TaoRun = "����糡";
        private string QuanShan = "Ȫɽ��糡";
        private string JinYan = "�����糡";
        private string KaiRun = "�����糡";
        private string RunQing = "�����糡";
        private string FeiXiang = "�����糡";
        private string JiaRun = "�����糡";
        private string YuFeng = "Ԧ���糡";
        private string RunJin = "����糡";
        private string ZeRun = "�����糡";



        public Form1()
        {
            InitializeComponent();
            AutoScale(this);// ��������Ӧ
                            // �Զ������п�����Ӧ����

            LoadYesterdayData();
            LoadTodayCount(connectionString);

        }
        public void AutoScale(Form frm)
        {
            frm.Tag = frm.Width.ToString() + "," + frm.Height.ToString();
            frm.SizeChanged += new EventHandler(frmScreen_SizeChanged);
        }
        private void frmScreen_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                string[] tmp = ((Form)sender).Tag.ToString().Split(',');
                float width = (float)((Form)sender).Width / (float)Convert.ToInt16(tmp[0]);
                float heigth = (float)((Form)sender).Height / (float)Convert.ToInt16(tmp[1]);
                ((Form)sender).Tag = ((Form)sender).Width.ToString() + "," + ((Form)sender).Height;
                foreach (Control control in ((Form)sender).Controls)
                {
                    control.Scale(new SizeF(width, heigth));
                }
            }
            catch (System.Exception ex)
            {

                // 

            }

        }

        private void LoadYesterdayData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT �糡����,����,���ʼʱ��,�����ʱ��,�Ƿ������ FROM data_oms WHERE ���� = @TargetDate";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@TargetDate", DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"));

                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        { }
        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "UPDATE data_oms SET ���ʼʱ�� = '', �����ʱ�� = '', �Ƿ������ = 0 WHERE ���� = @TargetDate";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@TargetDate", DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"));

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    LoadYesterdayData();
                    // rowsAffected��������Ӱ�������
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error executing SQL: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "UPDATE data_oms SET ���ʼʱ�� = '2000-01-01', �����ʱ�� = '2000-01-01', �Ƿ������ = 1 WHERE ���� = @TargetDate";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@TargetDate", DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"));

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    LoadYesterdayData();
                    // rowsAffected��������Ӱ�������
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error executing SQL: " + ex.Message);
                }
            }
        }

        private void LoadTodayCount(string connStr)
        {
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                try
                {
                    connection.Open();

                    // ��ѯ����ʾMySQL�������汾
                    var serverVersion = connection.ServerVersion;
                    //MessageBox.Show($"MySQL Server Version: {serverVersion}", "MySQL Version", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DateTime today = DateTime.Today.AddDays(-1);
                    string formattedDate = today.ToString("yyyy-MM-dd");

                    string query = $"SELECT COUNT(*) FROM data_oms WHERE ���� = '{formattedDate}'";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // ����label���ı�������todayCountLabel�Ѵ��ڣ�
                    label1.Text = $"�����¼����{count}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"�޷����ӵ����ݿ���ѯʧ�ܣ�{ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenDataOne(KaiRun);
        }

        private void button42_Click(object sender, EventArgs e)
        {

            CloseDataOne(KaiRun);
        }
        private void CloseDataOne(string Wfname)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = $"UPDATE data_oms SET ���ʼʱ�� = '2000-01-01', �����ʱ�� = '2000-01-01', �Ƿ������ = 1 WHERE �糡����=@FieldName and ���� = @TargetDate";
                MySqlCommand command = new MySqlCommand(query, connection);
                // ����Ƿ��裬��ֱ���·���ͷ������ڴ��ܵ�����
                if (Wfname == "�����糡")
                {
                    command.Parameters.AddWithValue("@FieldName", "�����糡");
                    command.Parameters.AddWithValue("@TargetDate", DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"));

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    // ���·������ڴ��ܵ�����
                    command.Parameters["@FieldName"].Value = "�������ڴ���";
                    rowsAffected += command.ExecuteNonQuery();
                }
                else
                {
                    command.Parameters.AddWithValue("@FieldName", Wfname);
                    command.Parameters.AddWithValue("@TargetDate", DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"));

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                }

                LoadYesterdayData(); // ���º����¼���������ʵ��ʵʱ����
            }
        }
        private void OpenDataOne(string Wfname)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = $"UPDATE data_oms SET ���ʼʱ�� = '', �����ʱ�� = '', �Ƿ������ = 0 WHERE �糡����=@FieldName and ���� = @TargetDate";
                MySqlCommand command = new MySqlCommand(query, connection);

                // ����Ƿ��裬��ֱ���·���ͷ������ڴ��ܵ�����
                if (Wfname == "�����糡")
                {
                    command.Parameters.AddWithValue("@FieldName", "�����糡");
                    command.Parameters.AddWithValue("@TargetDate", DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"));

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    // ���·������ڴ��ܵ�����
                    command.Parameters["@FieldName"].Value = "�������ڴ���";
                    rowsAffected += command.ExecuteNonQuery();
                }
                else
                {
                    command.Parameters.AddWithValue("@FieldName", Wfname);
                    command.Parameters.AddWithValue("@TargetDate", DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"));

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                }

                LoadYesterdayData(); // ���º����¼���������ʵ��ʵʱ����
            }
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            OpenDataOne(JiaRun);
        }

        private void button42_Click_1(object sender, EventArgs e)
        {
            CloseDataOne(KaiRun);
        }

        private void button22_Click_2(object sender, EventArgs e)
        {
            OpenDataOne(JiaRun);

        }

        private void button41_Click(object sender, EventArgs e)
        {
            CloseDataOne(JiaRun);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            OpenDataOne(QuanShan);

        }

        private void button40_Click(object sender, EventArgs e)
        {
            CloseDataOne(QuanShan);

        }

        private void button23_Click(object sender, EventArgs e)
        {
            OpenDataOne(ZeRun);

        }

        private void button26_Click(object sender, EventArgs e)
        {
            OpenDataOne(RunQing);

        }

        private void button25_Click(object sender, EventArgs e)
        {
            OpenDataOne(RunJin);

        }

        private void button28_Click(object sender, EventArgs e)
        {
            OpenDataOne(JinYan);

        }

        private void button27_Click(object sender, EventArgs e)
        {
            OpenDataOne(YaRun);

        }

        private void button30_Click(object sender, EventArgs e)
        {
            OpenDataOne(TaoRun);

        }

        private void button29_Click(object sender, EventArgs e)
        {
            OpenDataOne(FeiXiang);

        }

        private void button31_Click(object sender, EventArgs e)
        {
            OpenDataOne(YuFeng);

        }

        private void button32_Click(object sender, EventArgs e)
        {
            CloseDataOne(YuFeng);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            CloseDataOne(TaoRun);

        }

        private void button33_Click(object sender, EventArgs e)
        {
            CloseDataOne(FeiXiang);

        }

        private void button39_Click(object sender, EventArgs e)
        {
            CloseDataOne(ZeRun);

        }

        private void button38_Click(object sender, EventArgs e)
        {
            CloseDataOne(RunQing);

        }

        private void button37_Click(object sender, EventArgs e)
        {
            CloseDataOne(RunJin);

        }

        private void button36_Click(object sender, EventArgs e)
        {
            CloseDataOne(JinYan);

        }

        private void button35_Click(object sender, EventArgs e)
        {
            CloseDataOne(YaRun);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filePath = @"����֣������̨����ʹ��˵��.pdf";

            if (File.Exists(filePath))
            {
                try
                {
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                catch (Win32Exception ex)
                {
                    MessageBox.Show($"�޷��򿪰����ĵ���{ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("�Ҳ��������ĵ��������ļ�·���Ƿ���ȷ��");
            }
        }
    }
}
