using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCrm.Models;

namespace MyFinancialCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private FinancialCrmDbEntities database = new FinancialCrmDbEntities();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            using (var context = new FinancialCrmDbEntities())
            {
                var user = context.Users
                    .FirstOrDefault(u => u.UserName == userName && u.Password == password);

                if (user != null)
                {
                    MessageBox.Show("Giriş başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Ana formu açın veya bir sonraki işlemi başlatın.
                    FrmBanks frmBanks = new FrmBanks();
                    frmBanks.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FrmNewUsers frmNewUsers = new FrmNewUsers();
            frmNewUsers.Show();
            this.Hide();
        }
    }
}
