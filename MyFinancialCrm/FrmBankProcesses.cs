using MyFinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    public partial class FrmBankProcesses : Form
    {
        public FrmBankProcesses()
        {
            InitializeComponent();
        }

        private FinancialCrmDbEntities dataBase = new FinancialCrmDbEntities();


        /// <summary>
        /// BankProcesses tablosu ile Banks tablosunu birleştirerek BankTitle bilgisini
        /// DataGridView üzerinde gösterebiliriz.
        /// Bunun için LINQ sorgusu kullanıldı.
        /// </summary>
        public void GetAll()
        {
            using (var values = new FinancialCrmDbEntities())
            {
                var spendingList = values.BankProcesses.Select(bp => new
                {
                    bp.BankProccessId,
                    bp.Description,
                    bp.ProcessDate,
                    bp.ProcessType,
                    bp.Amount,
                    bp.Banks.BankTitle
                }).ToList();
                dataGridView1.DataSource = spendingList;
            }
        }

        /// <summary>
        /// Combobox nesnemize vt'nin Bank tablosundaki BankTitle alanlarını ekledik.
        /// </summary>
        public void GetBanks()
        {
            var values = dataBase.Banks.Select(b => new { b.BankId, b.BankTitle }).ToList();
            cmb_Bank.DataSource = values;
            cmb_Bank.DisplayMember = "BankTitle"; //ComboBox'ta görüntülenecek metin olarak, her öğenin BankTitle özelliği belirlenir.
            cmb_Bank.ValueMember = "BankId"; //ComboBox'taki her öğenin arka planda tutulacak değeri olarak BankId özelliği atanır.
            cmb_Bank.SelectedIndex = -1;// Varsayılan olarak hiçbir şey seçili olmasın
        }

        /// <summary>
        /// Formdaki bütün nesneleri temizleyen metot.
        /// </summary>
        public void ClearForm()
        {
            foreach (Control control in panel3.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
            cmb_Bank.SelectedIndex = -1;
            cmb_ProcessType.SelectedIndex = -1;
            dateTimePicker_ProcessDate.Value = DateTime.Now;
        }

        #region MenüKodları
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

        private void FrmBankProcesses_Load(object sender, EventArgs e)
        {
            GetBanks();
            GetAll();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #region CRUD İşlemleri
        private void btn_GetAll_Click(object sender, EventArgs e)
        {
            GetAll();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                // ComboBox verisi kontrolü
                if (cmb_ProcessType.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen işlem tipini seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // İşlem tipi seçimini al
                string processType = cmb_ProcessType.SelectedItem.ToString();

                BankProcesses bankProcesses = new BankProcesses();
                string description = txt_ProcessDescription.Text;
                DateTime processDate = dateTimePicker_ProcessDate.Value;
                decimal amount = Convert.ToDecimal(txt_ProcessAmount.Text);
                int bankId = (int)cmb_Bank.SelectedValue;

                // Yeni işlem ekle
                bankProcesses.Description = description;
                bankProcesses.ProcessDate = processDate;
                bankProcesses.ProcessType = processType; 
                bankProcesses.Amount = amount;
                bankProcesses.BankId = bankId;

                dataBase.BankProcesses.Add(bankProcesses);
                dataBase.SaveChanges();

                MessageBox.Show("Yeni Veri Eklendi!", "Banka Hareketleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAll(); // Listeyi yeniler
                ClearForm(); // Formu temizler
            }
            catch (Exception exception)
            {
                Console.WriteLine("Hatalı Veri Girişi. Lütfen Bilgileri Kontrol Ediniz!");
                Console.WriteLine(exception.Message);
                throw;
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow!=null)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BankProccessId"].Value);
                    var removeValues = dataBase.BankProcesses.Find(id);
                    dataBase.BankProcesses.Remove(removeValues);
                    dataBase.SaveChanges();

                    MessageBox.Show("Kayıt Silindi", "Banka Hareketleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetAll();
                    ClearForm();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Hatalı İşlem Lütfen Silinecek Kaydı Kontrol Ediniz !");
                throw;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                // DataGridView'den seçili BankProccessId kontrolü
                if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Cells["BankProccessId"].Value == null)
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz kaydı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int bankProccessId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BankProccessId"].Value);

                // ProcessType (ComboBox) seçimi kontrolü
                if (cmb_ProcessType.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen işlem tipini seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string processType = cmb_ProcessType.SelectedItem.ToString(); // ProcessType doğru bir şekilde alındı.

                // Diğer alanlar
                string description = txt_ProcessDescription.Text;
                DateTime processDate = dateTimePicker_ProcessDate.Value;
                decimal amount = Convert.ToDecimal(txt_ProcessAmount.Text);
                int bankId = (int)cmb_Bank.SelectedValue;

                // Veritabanından güncellenecek kaydı bul
                var values = dataBase.BankProcesses.Find(bankProccessId);
                if (values == null)
                {
                    MessageBox.Show("Seçilen kayıt bulunamadı. Lütfen işlemi kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Güncelleme işlemleri
                values.Description = description;
                values.ProcessDate = processDate;
                values.ProcessType = processType;
                values.Amount = amount;
                values.BankId = bankId;

                // Değişiklikleri kaydet
                dataBase.SaveChanges();

                MessageBox.Show("Kayıt başarılı bir şekilde güncellendi.", "Banka Hareketleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetAll(); // Listeyi yeniler
                ClearForm(); // Formu temizler
            }
            catch (Exception exception)
            {
                Console.WriteLine("Hatalı işlem. Lütfen bilgileri kontrol ediniz.");
                Console.WriteLine(exception.Message); // Hata mesajını yazdır
                MessageBox.Show("Beklenmedik bir hata oluştu. Hata: " + exception.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion


        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    txt_ProcessDescription.Text = row.Cells["Description"].Value.ToString();
                    dateTimePicker_ProcessDate.Value = Convert.ToDateTime(row.Cells["ProcessDate"].Value);
                    cmb_ProcessType.Text = row.Cells["ProcessType"].Value.ToString();
                    txt_ProcessAmount.Text = row.Cells["Amount"].Value.ToString();
                    cmb_Bank.Text = row.Cells["BankTitle"].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Hatalı Alan Seçimi");
                throw;
            }
        }
    }
}
