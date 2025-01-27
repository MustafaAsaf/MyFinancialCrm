using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using MyFinancialCrm.Models;

namespace MyFinancialCrm
{
    public partial class FrmNewUsers : Form
    {
        public FrmNewUsers()
        {
            InitializeComponent();
        }

        private FinancialCrmDbEntities database = new FinancialCrmDbEntities();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            FrmLogin frmLogin = new FrmLogin();
            try
            {
                string userName = txtUserName.Text;
                string password = txtPassword.Text;

                users.UserName = userName;
                users.Password = password;
                database.Users.Add(users);
                database.SaveChanges(); 

                MessageBox.Show("Kayıt başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmLogin.Show();
                this.Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Hatalı İşlem.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
    }
}
