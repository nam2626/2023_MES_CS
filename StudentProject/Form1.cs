using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] arr =
            {
                txtStudentNo.Text,
                txtStudentName.Text,
                cbxMajor.SelectedItem.ToString(),
                txtScore.Text
            };
            ListViewItem item = new ListViewItem(arr);
            lstStudent.Items.Add(item);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lstStudent.SelectedItems.Count != 0)
            {
                lstStudent.Items.RemoveAt(lstStudent.FocusedItem.Index);
                MessageBox.Show("삭제가 완료되었습니다.");
            }
        }
    }
}
