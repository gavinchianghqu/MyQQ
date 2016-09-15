using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string nickName = txtRegisterNickName.Text;
            int age = int.Parse(txtRegisterAge.Text);
            string sex = rdoRegisterMale.Checked ? rdoRegisterMale.Text : rdoRegisterFemale.Text;
            string registerPwd = txtRegisterPwd.Text;
            string registerPwdRepeat = txtRegisterPwdRepeat.Text;
            string realName = txtRegisterRealName.Text;
            string star = cmbRegisterStar.Text;
            string bloodType = cmbRegisterBloodType.Text;
            if (registerPwd!=registerPwdRepeat)
            {
                MessageBox.Show("两次输入的密码不同", "输入提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRegisterPwdRepeat.Focus();
            }
            if (nickName!=null && age!=null && sex!=null && registerPwd!=null)
            {
                string sqlToUsers = string.Format(
                    "INSERT INTO Users(NickName,Age,Sex,LoginPwd,Name,Star,BloodType)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                    nickName,age,sex,registerPwd,realName,star,bloodType);
            }
        }
    }
}
