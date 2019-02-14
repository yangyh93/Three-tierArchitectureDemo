using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using DAL;
using BLL;
namespace UserUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ID = Convert.ToInt32(this.tbID.Text.Trim());
            user.Name = this.tbName.Text.Trim();
            UserBLL ub = new UserBLL();
            if (ub.addUser(user))
            {
                MessageBox.Show("添加成功", "提示");
            }
            else
            {
                MessageBox.Show("添加失败","提示");
            }
        }
    }
}
