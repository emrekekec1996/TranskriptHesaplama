namespace TranskriptHesaplama.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnDersiDuzenle = new Button();
            cmbFinal = new ComboBox();
            cmbAraSinav = new ComboBox();
            btnHesapla = new Button();
            label2 = new Label();
            label1 = new Label();
            lblSecilen = new Label();
            dgvDersler = new DataGridView();
            lblGNO = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDersler).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(btnDersiDuzenle);
            groupBox1.Controls.Add(cmbFinal);
            groupBox1.Controls.Add(cmbAraSinav);
            groupBox1.Controls.Add(btnHesapla);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblSecilen);
            groupBox1.Controls.Add(dgvDersler);
            groupBox1.Controls.Add(lblGNO);
            groupBox1.ForeColor = Color.DarkSlateBlue;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "NOT HESAPLAMA";
            // 
            // btnDersiDuzenle
            // 
            btnDersiDuzenle.BackColor = Color.Goldenrod;
            btnDersiDuzenle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDersiDuzenle.ForeColor = Color.White;
            btnDersiDuzenle.Location = new Point(492, 168);
            btnDersiDuzenle.Name = "btnDersiDuzenle";
            btnDersiDuzenle.Size = new Size(206, 64);
            btnDersiDuzenle.TabIndex = 11;
            btnDersiDuzenle.Text = "HARF NOTUNU HESAPLA";
            btnDersiDuzenle.UseVisualStyleBackColor = false;
            btnDersiDuzenle.Click += new EventHandler(btnDersiDuzenle_Click);
            // 
            // cmbFinal
            // 
            cmbFinal.Location = new Point(492, 120);
            cmbFinal.Name = "cmbFinal";
            cmbFinal.Size = new Size(206, 25);
            cmbFinal.TabIndex = 12;
            cmbFinal.SelectedIndexChanged += new EventHandler(cmbFinal_SelectedIndexChanged);
            // 
            // cmbAraSinav
            // 
            cmbAraSinav.Location = new Point(492, 58);
            cmbAraSinav.Name = "cmbAraSinav";
            cmbAraSinav.Size = new Size(206, 25);
            cmbAraSinav.TabIndex = 13;
            cmbAraSinav.SelectedIndexChanged += new EventHandler(cmbAraSinav_SelectedIndexChanged);
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.DarkOrange;
            btnHesapla.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHesapla.ForeColor = Color.White;
            btnHesapla.Location = new Point(492, 238);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(206, 68);
            btnHesapla.TabIndex = 8;
            btnHesapla.Text = "GNO'YU HESAPLA";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += new EventHandler(btnHesapla_Click);
            // 
            // label2
            // 
            label2.Location = new Point(492, 94);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 14;
            label2.Text = "FİNAL";
            // 
            // label1
            // 
            label1.Location = new Point(492, 32);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 15;
            label1.Text = "ARA SINAV";
            // 
            // lblSecilen
            // 
            lblSecilen.BackColor = Color.AliceBlue;
            lblSecilen.BorderStyle = BorderStyle.FixedSingle;
            lblSecilen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSecilen.ForeColor = Color.DarkSlateBlue;
            lblSecilen.Location = new Point(19, 31);
            lblSecilen.Name = "lblSecilen";
            lblSecilen.Size = new Size(434, 37);
            lblSecilen.TabIndex = 3;
            lblSecilen.Text = "SEÇİLEN DERS:";
            lblSecilen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvDersler
            // 
            dgvDersler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDersler.BackgroundColor = Color.Lavender;
            dgvDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDersler.GridColor = Color.DarkSlateBlue;
            dgvDersler.Location = new Point(19, 88);
            dgvDersler.Name = "dgvDersler";
            dgvDersler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDersler.Size = new Size(434, 218);
            dgvDersler.TabIndex = 2;
            dgvDersler.CellClick += new DataGridViewCellEventHandler(dgvDersler_CellClick);
            // 
            // lblGNO
            // 
            lblGNO.BackColor = Color.AliceBlue;
            lblGNO.BorderStyle = BorderStyle.FixedSingle;
            lblGNO.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGNO.ForeColor = Color.DarkSlateBlue;
            lblGNO.Location = new Point(19, 321);
            lblGNO.Name = "lblGNO";
            lblGNO.Size = new Size(434, 37);
            lblGNO.TabIndex = 1;
            lblGNO.Text = "GNO:";
            lblGNO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NOT HESAPLAMA FORMU";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDersler).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private GroupBox groupBox1;
        private Label lblGNO;
        private DataGridView dgvDersler;
        private Label lblSecilen;
        private Button btnHesapla;
        private Label label2;
        private Label label1;
        private ComboBox cmbFinal;
        private ComboBox cmbAraSinav;
        private Button btnDersiDuzenle;
    }
}
