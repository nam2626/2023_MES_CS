using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Step03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.comboBox1.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("버튼 클릭");
            //MessageBox.Show("버튼 클릭");
            this.checkBox1.Checked = !this.checkBox1.Checked;
            MessageBox.Show(this.txtInputBox.Text 
                + " " + this.comboBox1.SelectedItem);
            string[] arr =
            {
                this.comboBox1.SelectedIndex.ToString(),
                this.comboBox1.SelectedItem.ToString()
            };
            ListViewItem item = new ListViewItem(arr);
            this.listView1.Items.Add(item);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; 
            //MessageBox.Show(comboBox.SelectedItem + " 선택");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //현재 선택된 리스트 아이템을 삭제
            int idx = listView1.FocusedItem.Index;
            MessageBox.Show(idx.ToString());
        }
    }
}
