using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCrm.Models; //Modelimizi çağırdık.

namespace MyFinancialCrm
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }

        private FinancialCrmDbEntities dataBase = new FinancialCrmDbEntities();

        private void btn_GetAll_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GetAll();
        }

        public void GetAll()
        {
            var values = dataBase.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            foreach (Control control in panel3.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_BillTitle.Text = row.Cells["BillTitle"].Value.ToString();
                txt_BillAmount.Text = row.Cells["BillAmount"].Value.ToString();
                txt_BillPeriod.Text = row.Cells["BillPeriod"].Value.ToString();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string title = txt_BillTitle.Text;
            decimal amount = Convert.ToDecimal(txt_BillAmount.Text);
            string period = txt_BillPeriod.Text;

            Bills bills = new Bills();
            bills.BillTitle = title;
            bills.BillAmount = amount;
            bills.BillPeriod = period;
            dataBase.Bills.Add(bills);
            dataBase.SaveChanges();

            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sisteme Eklendi","Ödeme & Faturalar",MessageBoxButtons.OK,MessageBoxIcon.Information);

            GetAll();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            // DataGridView'de tıklanan satırın ID değerini al
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BillId"].Value);

                var removeValues = dataBase.Bills.Find(id);
                dataBase.Bills.Remove(removeValues);
                dataBase.SaveChanges();

                MessageBox.Show("Ödeme Başarılı Bir Şekilde Sistemden Silindi","Ödeme & Faturalar",MessageBoxButtons.OK,MessageBoxIcon.Information);

                GetAll();

            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string title = txt_BillTitle.Text;
                decimal amount = Convert.ToDecimal(txt_BillAmount.Text);
                string period = txt_BillPeriod.Text;
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BillId"].Value);

                var values = dataBase.Bills.Find(id);


                values.BillTitle = title;
                values.BillAmount = amount;
                values.BillPeriod = period;
                dataBase.SaveChanges();

                MessageBox.Show("Ödeme Başarılı Bir Şekilde Sistemde Güncellendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                GetAll();
            }
        }

        private void btn_Banks_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
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

        private void btn_Categorys_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Hide();
        }

        private void btn_Spendings_Click(object sender, EventArgs e)
        {
            FrmSpendings frmSpendings = new FrmSpendings();
            frmSpendings.Show();
            this.Hide();
        }

        private void btn_BankProccesses_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frmBankProcesses = new FrmBankProcesses();
            frmBankProcesses.Show();
            this.Hide();
        }
    }
}
