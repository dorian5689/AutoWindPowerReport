using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
namespace AutoWindPowerReport
{



    public partial class HeNanUser : Form
    {
        // 储存Form1实例引用
        private readonly Form1 parentForm;



        public HeNanUser(Form1 parent)
        {
            InitializeComponent();
            if (parent != null)
            {
                this.parentForm = parent;
            }

            FlowLayoutPanel radioButtonPanel = new FlowLayoutPanel();
            radioButtonPanel.FlowDirection = FlowDirection.TopDown;
            radioButtonPanel.WrapContents = false; // 不自动换行，以展示滚动条
            radioButtonPanel.AutoSize = true;
            radioButtonPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            radioButtonPanel.AutoScroll = true;

            // 将FlowLayoutPanel添加到groupBox1内
            groupBox1.Controls.Add(radioButtonPanel);

            string[] dataList = { "河南省郑州市集控", "河南省濮阳市润清风电场", "河南省濮阳市韬润风电场", "河南省濮阳市雅润风电场",
                                  "河南省南阳市凯润风电场", "河南省南阳市泉山风电场", "河南省安阳市润金风电场", "河南省安阳市驭风风电场",
                                  "河南省平顶山市金燕风电场", "河南省漯河市飞翔风电场", "河南省新乡市泽润风电场" };
            foreach (string data in dataList)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Text = data;
                radioButton.Tag = data;
                radioButton.AutoSize = true;
                radioButton.CheckedChanged += RadioButton_CheckedChanged;
                radioButtonPanel.Controls.Add(radioButton);
            }
        }


        // 公开访问选中数据的属性
        public string SelectedData
        {
            get => selectedData;
            set
            {
                selectedData = value;
                UpdateLabels(); // 更新所有关联的标签
            }
        }

        private string selectedData;



        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                selectedData = ((RadioButton)sender).Text;
                UpdateLabels(); // 当RadioButton状态改变时，立即更新两个窗体的Label

                if (sender is RadioButton rb && rb.Checked)
                {
                    string name_fdc = rb.Text; // 直接赋值
      

                    UpdateConfigFile(name_fdc);
                }
            }
        }
        private void UpdateConfigFile(string name_fdc)
        {
            string filePath = @"auto\Config\ConfigHenanOmsUser.py";
            string contentToWrite = ""; // 给contentToWrite一个初始值

            // 清空文件内容（如果文件存在）
            if (File.Exists(filePath))
            {
                File.WriteAllText(filePath, "");
            }

            // 检查并更新contentToWrite（如果需要）
            if (!string.IsNullOrEmpty(name_fdc) && name_fdc.Contains("润清"))
            {
                contentToWrite = "henan_wfname_dict_num = { 1: 25 }" + Environment.NewLine +
                                 "get_henan_url = 'https://172.21.10.3:19070/app-portal/index.html'";
            }
            // 检查并更新contentToWrite（如果需要）
            if (!string.IsNullOrEmpty(name_fdc) && name_fdc.Contains("韬润"))
            {
                contentToWrite = "henan_wfname_dict_num = { 2: 13 }" + Environment.NewLine +
                                 "get_henan_url = 'https://172.21.10.3:19070/app-portal/index.html'";
            }
            // 检查并更新contentToWrite（如果需要）
            if (!string.IsNullOrEmpty(name_fdc) && name_fdc.Contains("雅润"))
            {
                contentToWrite = "henan_wfname_dict_num = { 3: 12 }" + Environment.NewLine +
                                 "get_henan_url = 'https://172.21.10.3:19070/app-portal/index.html'";
            }
            // 检查并更新contentToWrite（如果需要）
            if (!string.IsNullOrEmpty(name_fdc) && name_fdc.Contains("凯润"))
            {
                contentToWrite = "henan_wfname_dict_num = { 2: 22 }" + Environment.NewLine +
                                 "get_henan_url = 'https://172.21.10.3:19070/app-portal/index.html'";
            }
            // 检查并更新contentToWrite（如果需要）
            if (!string.IsNullOrEmpty(name_fdc) && name_fdc.Contains("嘉润"))
            {
                contentToWrite = "henan_wfname_dict_num = { 3: 23 }" + Environment.NewLine +
                                 "get_henan_url = 'https://172.21.10.3:19070/app-portal/index.html'";
            }
            // 检查并更新contentToWrite（如果需要）
            if (!string.IsNullOrEmpty(name_fdc) && name_fdc.Contains("泉山"))
            {
                contentToWrite = "henan_wfname_dict_num = { 1: 21 }" + Environment.NewLine +
                                 "get_henan_url = 'https://172.21.10.3:19070/app-portal/index.html'";
            }
            // 检查并更新contentToWrite（如果需要）
            if (!string.IsNullOrEmpty(name_fdc) && name_fdc.Contains("润金"))
            {
                contentToWrite = "henan_wfname_dict_num = { 7: 14 }" + Environment.NewLine +
                                    "get_henan_url = 'https://172.21.10.3:19070/app-portal/index.html'";
            }
            // 检查并更新contentToWrite（如果需要）
            if (!string.IsNullOrEmpty(name_fdc) && name_fdc.Contains("驭风"))
            {
                contentToWrite = "henan_wfname_dict_num = { 8: 8 }" + Environment.NewLine +
                                 "get_henan_url = 'https://172.21.10.3:19070/app-portal/index.html'";
            }
            // 检查并更新contentToWrite（如果需要）
            if (!string.IsNullOrEmpty(name_fdc) && name_fdc.Contains("金燕"))
            {
                contentToWrite = "henan_wfname_dict_num = { 9: 26 }" + Environment.NewLine +
                                    "get_henan_url = 'https://172.21.10.3:19070/app-portal/index.html'";
            }
            // 检查并更新contentToWrite（如果需要）
            if (!string.IsNullOrEmpty(name_fdc) && name_fdc.Contains("飞翔"))
            {
                contentToWrite = "henan_wfname_dict_num = { 10: 27 }" + Environment.NewLine +
                                    "get_henan_url = 'https://172.21.10.3:19070/app-portal/index.html'";
            }

            // 检查并更新contentToWrite（如果需要）
            if (!string.IsNullOrEmpty(name_fdc) && name_fdc.Contains("泽润"))
            {
                contentToWrite = "henan_wfname_dict_num = { 11: 24 }" + Environment.NewLine +
                                    "get_henan_url = 'https://172.21.10.3:19070/app-portal/index.html'";
            }
            // 检查并更新contentToWrite（如果需要）
            if (!string.IsNullOrEmpty(name_fdc) && name_fdc.Contains("郑州"))
            {
                contentToWrite = "henan_wfname_dict_num = {1: 1,2: 2,3: 3, 4: 4, 5: 5, 6: 6,7: 7, 8: 8, 9: 9,10: 10,11: 11,}" + Environment.NewLine +
                                    "get_henan_url = 'https://172.21.10.3:19070/app-portal/index.html'";
            }



            // 确保只有当contentToWrite非空时才执行写入操作
            {
                File.WriteAllText(filePath, contentToWrite);
            }
            
        }

        private void UpdateLabels()
        {

            // 更新Form2自身的Label
            label1.Text = $"你选择的是：{selectedData}";

            // 更新Form1的Label
            if (parentForm != null) // 检查引用是否有效
            {
                parentForm.UpdateLabelInForm1($"{selectedData}");
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UpdateSelectedDataLabel()
        {
            label1.Text = $"已选择:{selectedData}";
        }
    }
}
