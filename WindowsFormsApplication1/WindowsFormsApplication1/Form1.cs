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

            //SqlserverUser su = new SqlserverUser();
            IFactory factory = new SqlServerFactory(); //若要更改成Access数据库，只需要将本句改成IFactory factory=new AccessFactory();即可
            IUser su = factory.CreateUser();
            su.Insert(user);
            //su.GetUser(1);
            MessageBox.Show("插入数据成功！","温馨提示");
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            //得到用户按钮
            int id = Convert.ToInt32(txtId2.Text.Trim());
            //SqlserverUser su = new SqlserverUser();
            IFactory factory = new SqlServerFactory();
            IUser su = factory.CreateUser();
            txtName2.Text= su.GetUser(id);
        }

        private void btnAddDep_Click(object sender, EventArgs e)
        {
            //添加部门
            
            Department dept = new Department();
            dept.ID = Convert.ToInt32(txtDepId1.Text.Trim());
            dept.Name = txtDepName1.Text.Trim();
            IFactory factory = new AccessFactory();

            IDepartment id = factory.CreateDepartment();
            id.Insert(dept);
            //id.GetDepartment(1);
            MessageBox.Show("插入数据成功！", "温馨提示");
        }
    }
}
