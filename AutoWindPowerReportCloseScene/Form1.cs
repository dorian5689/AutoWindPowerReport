
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;

namespace AutoWindPowerReportCloseScene
{
    public partial class Form1 : Form
    {

        private string connectionString = "server=soam-mysql-13965e014815e193.elb.cn-northwest-1.amazonaws.com.cn;user id=nanfang;password=5yY7WtANHx2kpc5H;database=nanfang;persistsecurityinfo=True;charset=utf8;";



        private string YaRun = "雅润风电场";
        private string TaoRun = "韬润风电场";
        private string QuanShan = "泉山风电场";
        private string JinYan = "金燕风电场";
        private string KaiRun = "凯润风电场";
        private string RunQing = "润清风电场";
        private string FeiXiang = "飞翔风电场";
        private string JiaRun = "嘉润风电场";
        private string YuFeng = "驭风风电场";
        private string RunJin = "润金风电场";
        private string ZeRun = "泽润风电场";



        public Form1()
        {
            InitializeComponent();
            AutoScale(this);// 窗体自适应
                            // 自动调整列宽以适应内容

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
                string query = "SELECT 电场名称,日期,填报开始时间,填报结束时间,是否已完成 FROM data_oms WHERE 日期 = @TargetDate";
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
                string query = "UPDATE data_oms SET 填报开始时间 = '', 填报结束时间 = '', 是否已完成 = 0 WHERE 日期 = @TargetDate";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@TargetDate", DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"));

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    LoadYesterdayData();
                    // rowsAffected将包含受影响的行数
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
                string query = "UPDATE data_oms SET 填报开始时间 = '2000-01-01', 填报结束时间 = '2000-01-01', 是否已完成 = 1 WHERE 日期 = @TargetDate";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@TargetDate", DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"));

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    LoadYesterdayData();
                    // rowsAffected将包含受影响的行数
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

                    // 查询并显示MySQL服务器版本
                    var serverVersion = connection.ServerVersion;
                    //MessageBox.Show($"MySQL Server Version: {serverVersion}", "MySQL Version", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DateTime today = DateTime.Today.AddDays(-1);
                    string formattedDate = today.ToString("yyyy-MM-dd");

                    string query = $"SELECT COUNT(*) FROM data_oms WHERE 日期 = '{formattedDate}'";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // 更新label的文本（假设todayCountLabel已存在）
                    label1.Text = $"当天记录数：{count}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"无法连接到数据库或查询失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string query = $"UPDATE data_oms SET 填报开始时间 = '2000-01-01', 填报结束时间 = '2000-01-01', 是否已完成 = 1 WHERE 电场名称=@FieldName and 日期 = @TargetDate";
                MySqlCommand command = new MySqlCommand(query, connection);
                // 如果是飞翔，则分别更新飞翔和飞翔三期储能的数据
                if (Wfname == "飞翔风电场")
                {
                    command.Parameters.AddWithValue("@FieldName", "飞翔风电场");
                    command.Parameters.AddWithValue("@TargetDate", DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"));

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    // 更新飞翔三期储能的数据
                    command.Parameters["@FieldName"].Value = "飞翔三期储能";
                    rowsAffected += command.ExecuteNonQuery();
                }
                else
                {
                    command.Parameters.AddWithValue("@FieldName", Wfname);
                    command.Parameters.AddWithValue("@TargetDate", DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"));

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                }

                LoadYesterdayData(); // 更新后重新加载数据以实现实时更新
            }
        }
        private void OpenDataOne(string Wfname)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = $"UPDATE data_oms SET 填报开始时间 = '', 填报结束时间 = '', 是否已完成 = 0 WHERE 电场名称=@FieldName and 日期 = @TargetDate";
                MySqlCommand command = new MySqlCommand(query, connection);

                // 如果是飞翔，则分别更新飞翔和飞翔三期储能的数据
                if (Wfname == "飞翔风电场")
                {
                    command.Parameters.AddWithValue("@FieldName", "飞翔风电场");
                    command.Parameters.AddWithValue("@TargetDate", DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"));

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    // 更新飞翔三期储能的数据
                    command.Parameters["@FieldName"].Value = "飞翔三期储能";
                    rowsAffected += command.ExecuteNonQuery();
                }
                else
                {
                    command.Parameters.AddWithValue("@FieldName", Wfname);
                    command.Parameters.AddWithValue("@TargetDate", DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"));

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                }

                LoadYesterdayData(); // 更新后重新加载数据以实现实时更新
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
            string filePath = @"河南郑州市中台调度使用说明.pdf";

            if (File.Exists(filePath))
            {
                try
                {
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                catch (Win32Exception ex)
                {
                    MessageBox.Show($"无法打开帮助文档：{ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("找不到帮助文档，请检查文件路径是否正确！");
            }
        }
    }
}
