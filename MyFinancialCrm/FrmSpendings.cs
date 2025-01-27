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
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }

        private FinancialCrmDbEntities dataBase = new FinancialCrmDbEntities();

        #region Menü Butonları
        private void btn_Categorys_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Hide();
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

        private void btn_BankProccesses_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frmBankProcesses = new FrmBankProcesses();
            frmBankProcesses.Show();
            this.Hide();
        }

        private void btn_Spendings_Click(object sender, EventArgs e)
        {
            FrmSpendings frmSpendings = new FrmSpendings();
            frmSpendings.Show();
            this.Hide();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion


        public void ClearForm()
        {
            foreach (Control control in panel3.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
            cmb_Category.SelectedIndex = -1;
            dateTimePicker_SpendingDate.Value = DateTime.Now;
        }

        /// <summary>
        /// Combobox nesnemize vt'nin Category tablosundaki CategoryName alanlarını ekledik.
        /// </summary>
        public void GetCategory()
        {
            var values = dataBase.Categories.Select(c=>new{c.CategoryId,c.CategoryName}).ToList();
            cmb_Category.DataSource = values;
            cmb_Category.DisplayMember = "CategoryName"; //ComboBox'ta görüntülenecek metin olarak, her öğenin CategoryName özelliği belirlenir.
            cmb_Category.ValueMember = "CategoryId"; //ComboBox'taki her öğenin arka planda tutulacak değeri olarak CategoryId özelliği atanır.
            cmb_Category.SelectedIndex = -1; // Varsayılan olarak hiçbir şey seçili olmasın
        }

        /// <summary>
        /// Spendings tablosu ile Categories tablosunu birleştirerek CategoryName bilgisini
        /// DataGridView üzerinde gösterebiliriz.
        /// Bunun için LINQ sorgusu kullanıldı.
        /// </summary>
        public void getAll()
        {
            using (var values = new FinancialCrmDbEntities())
            {
                var spendingList = values.Spendings.Select(s => new
                {
                    s.SpendingId,
                    s.SpendingTitle,
                    s.SpendingAmount,
                    s.SpendingDate,
                    s.Categories.CategoryName 
                }).ToList();
                dataGridView1.DataSource = spendingList;
            }
           
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Spendings spendings = new Spendings();
            
            string spendingTitle = txt_SpendingTitle.Text;
            decimal spendingAmount = Convert.ToDecimal(txt_SpendingAmount.Text);
            DateTime spendingDate = dateTimePicker_SpendingDate.Value;
            int categoryId = (int)cmb_Category.SelectedValue; // ComboBox üzerinden seçilen kategori ID'si

            spendings.SpendingTitle = spendingTitle;
            spendings.SpendingAmount = spendingAmount;
            spendings.SpendingDate = spendingDate;
            spendings.CategoryId = categoryId;

            dataBase.Spendings.Add(spendings);
            dataBase.SaveChanges();
            MessageBox.Show("Yeni Gider Eklendi", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            getAll();
            ClearForm();


        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SpendingId"].Value);
                var removeValues = dataBase.Spendings.Find(id);
                dataBase.Spendings.Remove(removeValues);
                dataBase.SaveChanges();

                MessageBox.Show("Gider Silindi", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getAll();
                ClearForm();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    txt_SpendingTitle.Text = row.Cells["SpendingTitle"].Value.ToString();
                    txt_SpendingAmount.Text = row.Cells["SpendingAmount"].Value.ToString();
                    dateTimePicker_SpendingDate.Value = Convert.ToDateTime(row.Cells["SpendingDate"].Value);
                    cmb_Category.Text = row.Cells["CategoryName"].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Hatalı Alan Seçimi");
                throw;
            }

           
        }

        private void btn_GetAll_Click(object sender, EventArgs e)
        {
            getAll();
        }

        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            getAll();
            GetCategory();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                int spendingId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SpendingId"].Value);
                string spendingTitle = txt_SpendingTitle.Text;
                decimal spendingAmount = Convert.ToDecimal(txt_SpendingAmount.Text);
                DateTime spendingDate = dateTimePicker_SpendingDate.Value;
                int categoryId = Convert.ToInt32(cmb_Category.SelectedValue); // ComboBox üzerinden seçilen kategori ID'si
                
                var values = dataBase.Spendings.Find(spendingId);

                values.SpendingTitle = spendingTitle;
                values.SpendingAmount = spendingAmount;
                values.SpendingDate = spendingDate;
                values.CategoryId = categoryId;

                dataBase.SaveChanges();

                MessageBox.Show("Kayıt Başarılı Bir Şekilde Sistemde Güncellendi", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

                getAll();
                ClearForm();
                
            }
        }
    }
}
