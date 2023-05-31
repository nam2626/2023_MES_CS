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

        private void lstStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStudent.SelectedItems.Count != 0)
            {
                int idx = lstStudent.FocusedItem.Index;
                txtStudentNo.Text = lstStudent.Items[idx].SubItems[0].Text;
                txtStudentName.Text = lstStudent.Items[idx].SubItems[1].Text;
                cbxMajor.SelectedItem = lstStudent.Items[idx].SubItems[2].Text;
                txtScore.Text = lstStudent.Items[idx].SubItems[3].Text;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstStudent.SelectedItems.Count != 0)
            {
                int idx = lstStudent.FocusedItem.Index;
                lstStudent.Items[idx].SubItems[0].Text = txtStudentNo.Text;
                lstStudent.Items[idx].SubItems[1].Text = txtStudentName.Text;
                lstStudent.Items[idx].SubItems[2].Text= cbxMajor.SelectedItem.ToString();
                lstStudent.Items[idx].SubItems[3].Text = txtScore.Text;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lstStudent.Items.Count; i++)
            {
                if (lstStudent.Items[i].SubItems[0].Text.Equals(txtSearch.Text))
                {
                    lstStudent.Items[i].Focused = true;
                    lstStudent.Items[i].Selected = true;
                }
                else
                {
                    lstStudent.Items[i].Focused = false;
                    lstStudent.Items[i].Selected = false;
                }
            }
        }
    }
}
