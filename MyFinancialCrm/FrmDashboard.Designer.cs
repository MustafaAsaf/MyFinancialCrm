
namespace MyFinancialCrm
{
    partial class FrmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.btn_BankProccesses = new System.Windows.Forms.Button();
            this.btn_Spendings = new System.Windows.Forms.Button();
            this.btn_Bills = new System.Windows.Forms.Button();
            this.btn_Banks = new System.Windows.Forms.Button();
            this.btn_Categorys = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalBankBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.lblBillTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblLastBankProccessDescription = new System.Windows.Forms.Label();
            this.lblLastBankProccessAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_Dashboard);
            this.panel1.Controls.Add(this.btn_BankProccesses);
            this.panel1.Controls.Add(this.btn_Spendings);
            this.panel1.Controls.Add(this.btn_Bills);
            this.panel1.Controls.Add(this.btn_Banks);
            this.panel1.Controls.Add(this.btn_Categorys);
            this.panel1.Location = new System.Drawing.Point(-12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 717);
            this.panel1.TabIndex = 17;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.btn_Exit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(35, 470);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(184, 52);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "Çıkış Yap";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.btn_Dashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_Dashboard.Location = new System.Drawing.Point(35, 412);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(184, 52);
            this.btn_Dashboard.TabIndex = 5;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // btn_BankProccesses
            // 
            this.btn_BankProccesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.btn_BankProccesses.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_BankProccesses.ForeColor = System.Drawing.Color.White;
            this.btn_BankProccesses.Location = new System.Drawing.Point(35, 342);
            this.btn_BankProccesses.Name = "btn_BankProccesses";
            this.btn_BankProccesses.Size = new System.Drawing.Size(184, 64);
            this.btn_BankProccesses.TabIndex = 4;
            this.btn_BankProccesses.Text = "Banka \r\nHareketleri";
            this.btn_BankProccesses.UseVisualStyleBackColor = false;
            this.btn_BankProccesses.Click += new System.EventHandler(this.btn_BankProccesses_Click);
            // 
            // btn_Spendings
            // 
            this.btn_Spendings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.btn_Spendings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Spendings.ForeColor = System.Drawing.Color.White;
            this.btn_Spendings.Location = new System.Drawing.Point(35, 284);
            this.btn_Spendings.Name = "btn_Spendings";
            this.btn_Spendings.Size = new System.Drawing.Size(184, 52);
            this.btn_Spendings.TabIndex = 3;
            this.btn_Spendings.Text = "Giderler";
            this.btn_Spendings.UseVisualStyleBackColor = false;
            this.btn_Spendings.Click += new System.EventHandler(this.btn_Spendings_Click);
            // 
            // btn_Bills
            // 
            this.btn_Bills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.btn_Bills.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Bills.ForeColor = System.Drawing.Color.White;
            this.btn_Bills.Location = new System.Drawing.Point(35, 226);
            this.btn_Bills.Name = "btn_Bills";
            this.btn_Bills.Size = new System.Drawing.Size(184, 52);
            this.btn_Bills.TabIndex = 2;
            this.btn_Bills.Text = "Faturalar";
            this.btn_Bills.UseVisualStyleBackColor = false;
            this.btn_Bills.Click += new System.EventHandler(this.btn_Bills_Click);
            // 
            // btn_Banks
            // 
            this.btn_Banks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.btn_Banks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Banks.ForeColor = System.Drawing.Color.White;
            this.btn_Banks.Location = new System.Drawing.Point(35, 168);
            this.btn_Banks.Name = "btn_Banks";
            this.btn_Banks.Size = new System.Drawing.Size(184, 52);
            this.btn_Banks.TabIndex = 1;
            this.btn_Banks.Text = "Bankalar";
            this.btn_Banks.UseVisualStyleBackColor = false;
            this.btn_Banks.Click += new System.EventHandler(this.btn_Banks_Click);
            // 
            // btn_Categorys
            // 
            this.btn_Categorys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.btn_Categorys.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Categorys.ForeColor = System.Drawing.Color.White;
            this.btn_Categorys.Location = new System.Drawing.Point(35, 110);
            this.btn_Categorys.Name = "btn_Categorys";
            this.btn_Categorys.Size = new System.Drawing.Size(184, 52);
            this.btn_Categorys.TabIndex = 0;
            this.btn_Categorys.Text = "Kategoriler";
            this.btn_Categorys.UseVisualStyleBackColor = false;
            this.btn_Categorys.Click += new System.EventHandler(this.btn_Categorys_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-12, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1470, 40);
            this.panel2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard Formu";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.panel3.Controls.Add(this.lblTotalBankBalance);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(262, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 190);
            this.panel3.TabIndex = 19;
            // 
            // lblTotalBankBalance
            // 
            this.lblTotalBankBalance.AutoSize = true;
            this.lblTotalBankBalance.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalBankBalance.ForeColor = System.Drawing.Color.Transparent;
            this.lblTotalBankBalance.Location = new System.Drawing.Point(4, 69);
            this.lblTotalBankBalance.Name = "lblTotalBankBalance";
            this.lblTotalBankBalance.Size = new System.Drawing.Size(182, 73);
            this.lblTotalBankBalance.TabIndex = 4;
            this.lblTotalBankBalance.Text = "0.00 ₺";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toplam Bakiye";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.panel4.Controls.Add(this.lblBillAmount);
            this.panel4.Controls.Add(this.lblBillTitle);
            this.panel4.Location = new System.Drawing.Point(657, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(345, 190);
            this.panel4.TabIndex = 20;
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillAmount.ForeColor = System.Drawing.Color.Transparent;
            this.lblBillAmount.Location = new System.Drawing.Point(4, 69);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(182, 73);
            this.lblBillAmount.TabIndex = 4;
            this.lblBillAmount.Text = "0.00 ₺";
            // 
            // lblBillTitle
            // 
            this.lblBillTitle.AutoSize = true;
            this.lblBillTitle.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lblBillTitle.Location = new System.Drawing.Point(10, 14);
            this.lblBillTitle.Name = "lblBillTitle";
            this.lblBillTitle.Size = new System.Drawing.Size(145, 29);
            this.lblBillTitle.TabIndex = 3;
            this.lblBillTitle.Text = "Fatura Başlığı";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(118)))), ((int)(((byte)(125)))));
            this.panel5.Controls.Add(this.lblLastBankProccessDescription);
            this.panel5.Controls.Add(this.lblLastBankProccessAmount);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(1060, 67);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(345, 190);
            this.panel5.TabIndex = 21;
            // 
            // lblLastBankProccessDescription
            // 
            this.lblLastBankProccessDescription.AutoSize = true;
            this.lblLastBankProccessDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastBankProccessDescription.ForeColor = System.Drawing.Color.Transparent;
            this.lblLastBankProccessDescription.Location = new System.Drawing.Point(11, 58);
            this.lblLastBankProccessDescription.Name = "lblLastBankProccessDescription";
            this.lblLastBankProccessDescription.Size = new System.Drawing.Size(25, 24);
            this.lblLastBankProccessDescription.TabIndex = 5;
            this.lblLastBankProccessDescription.Text = "...";
            // 
            // lblLastBankProccessAmount
            // 
            this.lblLastBankProccessAmount.AutoSize = true;
            this.lblLastBankProccessAmount.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastBankProccessAmount.ForeColor = System.Drawing.Color.Transparent;
            this.lblLastBankProccessAmount.Location = new System.Drawing.Point(3, 89);
            this.lblLastBankProccessAmount.Name = "lblLastBankProccessAmount";
            this.lblLastBankProccessAmount.Size = new System.Drawing.Size(182, 73);
            this.lblLastBankProccessAmount.TabIndex = 4;
            this.lblLastBankProccessAmount.Text = "0.00 ₺";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(10, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gelen Son Havale";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(262, 365);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Bankalar";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(534, 330);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(871, 365);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Faturalar";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(534, 330);
            this.chart2.TabIndex = 22;
            this.chart2.Text = "chart2";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(262, 273);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(534, 86);
            this.panel6.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(490, 58);
            this.label3.TabIndex = 25;
            this.label3.Text = "Bankaralar ve banka hesaplarındaki para miktarı\r\naşağıdaki grafikte gösterilmekte" +
    "dir";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(871, 273);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(534, 86);
            this.panel7.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(72, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(378, 87);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ödenen ve ödenmesi gereken fatura \r\ntutarı aşağıdaki grafikte gösterilmiştir\r\n\r\n";
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(165)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(1446, 752);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmDashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Button btn_BankProccesses;
        private System.Windows.Forms.Button btn_Spendings;
        private System.Windows.Forms.Button btn_Bills;
        private System.Windows.Forms.Button btn_Banks;
        private System.Windows.Forms.Button btn_Categorys;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalBankBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.Label lblBillTitle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblLastBankProccessAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLastBankProccessDescription;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

