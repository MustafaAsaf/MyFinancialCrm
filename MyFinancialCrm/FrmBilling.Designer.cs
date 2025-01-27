
namespace MyFinancialCrm
{
    partial class FrmBilling
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.btn_BankProccesses = new System.Windows.Forms.Button();
            this.btn_Spendings = new System.Windows.Forms.Button();
            this.btn_Bills = new System.Windows.Forms.Button();
            this.btn_Banks = new System.Windows.Forms.Button();
            this.btn_Categorys = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_BillTitle = new System.Windows.Forms.TextBox();
            this.txt_BillAmount = new System.Windows.Forms.TextBox();
            this.txt_BillPeriod = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_GetAll = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ödemeler Formu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-12, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1470, 40);
            this.panel2.TabIndex = 8;
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
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Başlık:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Miktar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Periyot:";
            // 
            // txt_BillTitle
            // 
            this.txt_BillTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_BillTitle.Location = new System.Drawing.Point(88, 19);
            this.txt_BillTitle.Name = "txt_BillTitle";
            this.txt_BillTitle.Size = new System.Drawing.Size(1080, 32);
            this.txt_BillTitle.TabIndex = 12;
            // 
            // txt_BillAmount
            // 
            this.txt_BillAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_BillAmount.Location = new System.Drawing.Point(88, 80);
            this.txt_BillAmount.Name = "txt_BillAmount";
            this.txt_BillAmount.Size = new System.Drawing.Size(1080, 32);
            this.txt_BillAmount.TabIndex = 13;
            // 
            // txt_BillPeriod
            // 
            this.txt_BillPeriod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_BillPeriod.Location = new System.Drawing.Point(88, 142);
            this.txt_BillPeriod.Name = "txt_BillPeriod";
            this.txt_BillPeriod.Size = new System.Drawing.Size(1080, 32);
            this.txt_BillPeriod.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(244, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1190, 389);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_Clear);
            this.panel3.Controls.Add(this.btn_Update);
            this.panel3.Controls.Add(this.btn_Delete);
            this.panel3.Controls.Add(this.btn_Add);
            this.panel3.Controls.Add(this.btn_GetAll);
            this.panel3.Controls.Add(this.txt_BillTitle);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_BillPeriod);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_BillAmount);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(244, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1190, 281);
            this.panel3.TabIndex = 16;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(165)))), ((int)(((byte)(175)))));
            this.btn_Clear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Black;
            this.btn_Clear.Location = new System.Drawing.Point(947, 200);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(184, 52);
            this.btn_Clear.TabIndex = 18;
            this.btn_Clear.Text = "Temizle";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(165)))), ((int)(((byte)(175)))));
            this.btn_Update.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Update.ForeColor = System.Drawing.Color.Black;
            this.btn_Update.Location = new System.Drawing.Point(739, 200);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(184, 52);
            this.btn_Update.TabIndex = 17;
            this.btn_Update.Text = "Ödeme Güncelle";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(165)))), ((int)(((byte)(175)))));
            this.btn_Delete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Location = new System.Drawing.Point(530, 200);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(184, 52);
            this.btn_Delete.TabIndex = 16;
            this.btn_Delete.Text = "Ödeme Sil";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(165)))), ((int)(((byte)(175)))));
            this.btn_Add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Add.ForeColor = System.Drawing.Color.Black;
            this.btn_Add.Location = new System.Drawing.Point(325, 200);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(184, 52);
            this.btn_Add.TabIndex = 15;
            this.btn_Add.Text = "Yeni Ödeme";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_GetAll
            // 
            this.btn_GetAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(165)))), ((int)(((byte)(175)))));
            this.btn_GetAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GetAll.ForeColor = System.Drawing.Color.Black;
            this.btn_GetAll.Location = new System.Drawing.Point(116, 200);
            this.btn_GetAll.Name = "btn_GetAll";
            this.btn_GetAll.Size = new System.Drawing.Size(184, 52);
            this.btn_GetAll.TabIndex = 8;
            this.btn_GetAll.Text = "Listele";
            this.btn_GetAll.UseVisualStyleBackColor = false;
            this.btn_GetAll.Click += new System.EventHandler(this.btn_GetAll_Click);
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(165)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(1446, 752);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBilling";
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Button btn_BankProccesses;
        private System.Windows.Forms.Button btn_Spendings;
        private System.Windows.Forms.Button btn_Bills;
        private System.Windows.Forms.Button btn_Banks;
        private System.Windows.Forms.Button btn_Categorys;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_BillTitle;
        private System.Windows.Forms.TextBox txt_BillAmount;
        private System.Windows.Forms.TextBox txt_BillPeriod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_GetAll;
        private System.Windows.Forms.Button btn_Clear;
    }
}