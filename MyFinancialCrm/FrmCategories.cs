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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        private FinancialCrmDbEntities dataBase = new FinancialCrmDbEntities(); 

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btn_Bills_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
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

        private void btn_GetAll_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        public void GetAll()
        {
                var categories = dataBase.Categories
                    .Select(c => new
                    {
                        c.CategoryId,
                        c.CategoryName
                    })
                    .ToList();

                dataGridView1.DataSource = categories;
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GetAll();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_CategoryName.Text = row.Cells["CategoryName"].Value.ToString();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string categoryName = txt_CategoryName.Text;
            Categories categories = new Categories();
            categories.CategoryName = categoryName;
            dataBase.Categories.Add(categories);
            dataBase.SaveChanges();
            MessageBox.Show("Yeni Kategori Eklendi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetAll();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CategoryId"].Value);
                var removeValues = dataBase.Categories.Find(id);
                dataBase.Categories.Remove(removeValues);
                dataBase.SaveChanges();

                MessageBox.Show("Kategori Silindi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAll();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string categoryName = txt_CategoryName.Text;
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CategoryId"].Value);
                var values = dataBase.Categories.Find(id);

                values.CategoryName = categoryName;

                dataBase.SaveChanges();

                MessageBox.Show("Kategori Başarılı Bir Şekilde Sistemde Güncellendi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);


                GetAll();
            }
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
