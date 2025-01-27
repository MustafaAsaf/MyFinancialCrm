using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCrm.Models;

namespace MyFinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        private FinancialCrmDbEntities dataBase = new FinancialCrmDbEntities();

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            BankaBakiyeleri();
            BankaHareketleri();
        }

        public void BankaBakiyeleri()
        {
            var ziraatBankBalance = dataBase.Banks.Where(x => x.BankTitle == "Ziraat Bankası")
                .Select(y => y.BankBalance).FirstOrDefault();

            var vakifBankBalance = dataBase.Banks.Where(x => x.BankTitle == "Vakıf Bankası").Select(y => y.BankBalance)
                .FirstOrDefault();

            var isBankBalance = dataBase.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance)
                .FirstOrDefault();

            lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + " ₺";
            lblVakifBankBalance.Text = vakifBankBalance.ToString() + " ₺";
            lblIsBankBalance.Text = isBankBalance.ToString() + " ₺";
        }

        /// <summary>
        /// Banka hareketleri BankProccesses tablosundaki verilerin güncel tarihten eski tarihe doğru sıralanmasıdır.
        /// </summary>
        public void BankaHareketleri()
        {
            //Kod içindeki Take(3).Skip(2) kodunda  take(3) ilk 3 veriyi al ama skip(2) ilk 2 veriyi atla. Bunun sonucunda 3. veriyi almış oluyor sadece. 
            var bankProcess1 = dataBase.BankProcesses.OrderByDescending(x => x.ProcessDate).Take(1).FirstOrDefault();
            lblBankProccess1.Text = bankProcess1.Description + ",  " + bankProcess1.Amount + " ₺  ," + bankProcess1.ProcessDate;

            var bankProccess2 = dataBase.BankProcesses.OrderByDescending(x => x.ProcessDate).Take(2).Skip(1)
                .FirstOrDefault();
            lblBankProccess2.Text = bankProccess2.Description + ",  " + bankProccess2.Amount + " ₺  ," + bankProccess2.ProcessDate;

            var bankProccess3 = dataBase.BankProcesses.OrderByDescending(x => x.ProcessDate).Take(3).Skip(2)
                .FirstOrDefault();
            lblBankProccess3.Text= bankProccess3.Description + ",  " + bankProccess3.Amount + " ₺  ," + bankProccess3.ProcessDate;

            var bankProccess4 = dataBase.BankProcesses.OrderByDescending(x => x.ProcessDate).Take(4).Skip(3)
                .FirstOrDefault();
            lblBankProccess4.Text = bankProccess4.Description + ",  " + bankProccess4.Amount + " ₺  ," + bankProccess4.ProcessDate;

            var bankProccess5 = dataBase.BankProcesses.OrderByDescending(x => x.ProcessDate).Take(5).Skip(4)
                .FirstOrDefault();
            lblBankProccess5.Text = bankProccess5.Description + ",  " + bankProccess5.Amount + " ₺  ," + bankProccess5.ProcessDate;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Spendings_Click(object sender, EventArgs e)
        {
            FrmSpendings frmSpendings = new FrmSpendings();
            frmSpendings.Show();
            this.Hide();
        }

        private void btn_Bills_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btn_BankProccesses_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frmBankProcesses = new FrmBankProcesses();
            frmBankProcesses.Show();
            this.Hide();

        }

        private void btn_Banks_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btn_Categorys_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Hide();
        }
    }
}
