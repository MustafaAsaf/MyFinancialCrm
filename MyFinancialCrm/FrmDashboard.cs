using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCrm.Models;

namespace MyFinancialCrm
{
    
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities dataBase = new FinancialCrmDbEntities();

        private void FrmDashboard_Load(object sender, EventArgs e)
        {

            Metotlar metotlar = new Metotlar();
            metotlar.ToplamBakiye(this);
            metotlar.GelenSonHavale(this);
            metotlar.Grafik1(this);
            metotlar.Grafik2(this);

          

            
        }

        #region SolMenü
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
        #endregion

        #region Bütün Faturaları Timer İle Gösterme
        int count = 0;
        /// <summary>
        /// Bu yöntem, Timer bileşeninin her tetiklendiğinde çalıştırdığı kod bloğudur.
        /// Burada 2 saniyede bir  veritabanından yeni bir kayıt çekilir ve formdaki Fatura Başlığı alanına yazdırılır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            using (var context = new FinancialCrmDbEntities())
            {
                // Sıradaki veriyi çek
                var bill = context.Bills.OrderBy(b => b.BillId).Skip(count % context.Bills.Count()).FirstOrDefault();

                if (bill != null)
                {
                    lblBillTitle.Text = bill.BillTitle; // Fatura başlığını yazdır
                    lblBillAmount.Text = $"{bill.BillAmount:0.00} ₺"; // Fatura tutarını yazdır
                }
            }

            count++; // Sıradaki veriye geçmek için artır
        }
        #endregion

        public class Metotlar
        {
            FinancialCrmDbEntities dataBase = new FinancialCrmDbEntities();

            public void ToplamBakiye(FrmDashboard frmDashboard)
            {
                //Toplam Bakiye
                var totalBalance = dataBase.Banks.Sum(x => x.BankBalance);
                frmDashboard.lblTotalBankBalance.Text = totalBalance.ToString() + " ₺";
            }

            public void GelenSonHavale(FrmDashboard frmDashboard)
            {
                //Gelen Son Havale
                var lastBankProcess = dataBase.BankProcesses
                    .Where(x => x.ProcessType == "Gelen Havale") // Sadece Gelen Havale olanları filtrele
                    .OrderByDescending(x => x.ProcessDate)      // En güncel olanları sırala
                    .Select(y => new { y.Amount, y.Description }) // Tutar ve açıklamayı seç
                    .FirstOrDefault();                          // İlk kaydı al

                if (lastBankProcess != null) // Eğer sonuç varsa
                {
                    frmDashboard.lblLastBankProccessAmount.Text = $"{lastBankProcess.Amount:0.00} ₺"; // Tutarı ekrana yazdır
                    frmDashboard.lblLastBankProccessDescription.Text = lastBankProcess.Description;  // Açıklamayı ekrana yazdır
                }
                else
                {
                    frmDashboard.lblLastBankProccessAmount.Text = "0.00 ₺"; // Sonuç yoksa varsayılan değer yaz
                    frmDashboard.lblLastBankProccessDescription.Text = "Açıklama bulunamadı.";
                }
            }
            public void Grafik1(FrmDashboard frmDashboard)
            {
                //Chart1 Kodları
                var bankData = dataBase.Banks.Select(x => new { x.BankTitle, x.BankBalance }).ToList();
                frmDashboard.chart1.Series.Clear();
                var series = frmDashboard.chart1.Series.Add("Bankalar");
                foreach (var item in bankData)
                {
                    series.Points.AddXY(item.BankTitle, item.BankBalance);
                }
            }

            public void Grafik2(FrmDashboard frmDashboard)
            {
                //Chart2 Kodları
                var billData = dataBase.Bills.Select(x => new { x.BillTitle, x.BillAmount }).ToList();
                frmDashboard.chart2.Series.Clear();
                var series2 = frmDashboard.chart2.Series.Add("Faturalar");
                series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko; //Grafik tipini kod ile değiştirdik.
                foreach (var item in billData)
                {
                    series2.Points.AddXY(item.BillTitle, item.BillAmount);
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
