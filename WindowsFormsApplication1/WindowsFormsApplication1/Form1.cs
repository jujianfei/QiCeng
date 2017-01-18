using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //新增用户按钮
            User user = new User();
            user.ID = Convert.ToInt32(txtId1.Text.Trim());
            user.Name = txtName1.Text.Trim();

            SqlserverUser su = new SqlserverUser();
            su.Insert(user);
            //su.GetUser(1);
            MessageBox.Show("插入数据成功！","温馨提示");
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            //得到用户按钮
            int id = Convert.ToInt32(txtId2.Text.Trim());
            SqlserverUser su = new SqlserverUser();
            txtName2.Text= su.GetUser(id);

        }
    }
}
