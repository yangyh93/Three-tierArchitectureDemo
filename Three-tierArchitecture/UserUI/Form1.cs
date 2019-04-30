using BLL;
using Model;
using System;
using System.Windows.Forms;
namespace UserUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击按钮添加用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ID = Convert.ToInt32(this.tbID.Text.Trim());
            user.Name = this.tbName.Text.Trim().ToString();
            UserBLL ub = new UserBLL();
            if (ub.IsAddUser(user))
            {
                MessageBox.Show("添加成功", "提示");
            }
            else
            {
                MessageBox.Show("用户id号冲突","提示");
            }
        }
    }
}
