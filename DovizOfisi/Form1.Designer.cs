namespace DovizOfisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            lblDolarSatıs = new Label();
            lblDolarAlıs = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblEuroAlıs = new Label();
            lblEuroSatıs = new Label();
            groupBox1 = new GroupBox();
            txtKalan = new TextBox();
            label12 = new Label();
            txtTutar = new TextBox();
            label11 = new Label();
            btnSatısYap = new Button();
            txtMiktar = new TextBox();
            label10 = new Label();
            txtKur = new TextBox();
            label9 = new Label();
            btnEuroAl = new Button();
            btnDolarSat = new Button();
            btnDolarAl = new Button();
            btnEuroSat = new Button();
            btnSatısYap2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 23);
            label1.TabIndex = 0;
            label1.Text = "Dolar Alış : ";
            // 
            // lblDolarSatıs
            // 
            lblDolarSatıs.AutoSize = true;
            lblDolarSatıs.BackColor = Color.Transparent;
            lblDolarSatıs.ForeColor = Color.White;
            lblDolarSatıs.Location = new Point(119, 48);
            lblDolarSatıs.Name = "lblDolarSatıs";
            lblDolarSatıs.Size = new Size(22, 23);
            lblDolarSatıs.TabIndex = 1;
            lblDolarSatıs.Text = "0";
            // 
            // lblDolarAlıs
            // 
            lblDolarAlıs.AutoSize = true;
            lblDolarAlıs.BackColor = Color.Transparent;
            lblDolarAlıs.ForeColor = Color.White;
            lblDolarAlıs.Location = new Point(119, 9);
            lblDolarAlıs.Name = "lblDolarAlıs";
            lblDolarAlıs.Size = new Size(27, 23);
            lblDolarAlıs.TabIndex = 2;
            lblDolarAlıs.Text = "0 ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 144);
            label4.Name = "label4";
            label4.Size = new Size(109, 23);
            label4.TabIndex = 3;
            label4.Text = "EuroSatış : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 98);
            label5.Name = "label5";
            label5.Size = new Size(104, 23);
            label5.TabIndex = 4;
            label5.Text = "Euro Alış : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.White;
            label6.Location = new Point(2, 48);
            label6.Name = "label6";
            label6.Size = new Size(120, 23);
            label6.TabIndex = 5;
            label6.Text = "Dolar Satış : ";
            // 
            // lblEuroAlıs
            // 
            lblEuroAlıs.AutoSize = true;
            lblEuroAlıs.BackColor = Color.Transparent;
            lblEuroAlıs.ForeColor = Color.White;
            lblEuroAlıs.Location = new Point(119, 98);
            lblEuroAlıs.Name = "lblEuroAlıs";
            lblEuroAlıs.Size = new Size(22, 23);
            lblEuroAlıs.TabIndex = 6;
            lblEuroAlıs.Text = "0";
            // 
            // lblEuroSatıs
            // 
            lblEuroSatıs.AutoSize = true;
            lblEuroSatıs.BackColor = Color.Transparent;
            lblEuroSatıs.ForeColor = Color.White;
            lblEuroSatıs.Location = new Point(118, 144);
            lblEuroSatıs.Name = "lblEuroSatıs";
            lblEuroSatıs.Size = new Size(22, 23);
            lblEuroSatıs.TabIndex = 7;
            lblEuroSatıs.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnSatısYap2);
            groupBox1.Controls.Add(txtKalan);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtTutar);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(btnSatısYap);
            groupBox1.Controls.Add(txtMiktar);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtKur);
            groupBox1.Controls.Add(label9);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(207, 259);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(408, 242);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // txtKalan
            // 
            txtKalan.Location = new Point(99, 132);
            txtKalan.Name = "txtKalan";
            txtKalan.Size = new Size(289, 29);
            txtKalan.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.ForeColor = Color.White;
            label12.Location = new Point(4, 132);
            label12.Name = "label12";
            label12.Size = new Size(75, 23);
            label12.TabIndex = 16;
            label12.Text = "Kalan : ";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(99, 97);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(289, 29);
            txtTutar.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.ForeColor = Color.White;
            label11.Location = new Point(6, 100);
            label11.Name = "label11";
            label11.Size = new Size(79, 23);
            label11.TabIndex = 14;
            label11.Text = "Tutar  : ";
            // 
            // btnSatısYap
            // 
            btnSatısYap.Location = new Point(99, 179);
            btnSatısYap.Name = "btnSatısYap";
            btnSatısYap.Size = new Size(124, 38);
            btnSatısYap.TabIndex = 9;
            btnSatısYap.Text = "İşlem 1";
            btnSatısYap.UseVisualStyleBackColor = true;
            btnSatısYap.Click += btnSatısYap_Click;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(99, 62);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(289, 29);
            txtMiktar.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.ForeColor = Color.White;
            label10.Location = new Point(6, 62);
            label10.Name = "label10";
            label10.Size = new Size(85, 23);
            label10.TabIndex = 12;
            label10.Text = "Miktar : ";
            // 
            // txtKur
            // 
            txtKur.Location = new Point(99, 28);
            txtKur.Name = "txtKur";
            txtKur.Size = new Size(289, 29);
            txtKur.TabIndex = 9;
            txtKur.TextChanged += txtKur_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = Color.White;
            label9.Location = new Point(6, 34);
            label9.Name = "label9";
            label9.Size = new Size(58, 23);
            label9.TabIndex = 10;
            label9.Text = "Kur : ";
            // 
            // btnEuroAl
            // 
            btnEuroAl.Location = new Point(207, 99);
            btnEuroAl.Name = "btnEuroAl";
            btnEuroAl.Size = new Size(36, 26);
            btnEuroAl.TabIndex = 10;
            btnEuroAl.Text = "...";
            btnEuroAl.UseVisualStyleBackColor = true;
            btnEuroAl.Click += btnEuroAl_Click;
            // 
            // btnDolarSat
            // 
            btnDolarSat.Location = new Point(207, 52);
            btnDolarSat.Name = "btnDolarSat";
            btnDolarSat.Size = new Size(36, 32);
            btnDolarSat.TabIndex = 11;
            btnDolarSat.Text = "...";
            btnDolarSat.UseVisualStyleBackColor = true;
            btnDolarSat.Click += btnDolarSat_Click;
            // 
            // btnDolarAl
            // 
            btnDolarAl.Location = new Point(207, 9);
            btnDolarAl.Name = "btnDolarAl";
            btnDolarAl.Size = new Size(36, 31);
            btnDolarAl.TabIndex = 12;
            btnDolarAl.Text = "...";
            btnDolarAl.UseVisualStyleBackColor = true;
            btnDolarAl.Click += btnDolarAl_Click;
            // 
            // btnEuroSat
            // 
            btnEuroSat.Location = new Point(207, 148);
            btnEuroSat.Name = "btnEuroSat";
            btnEuroSat.Size = new Size(36, 29);
            btnEuroSat.TabIndex = 13;
            btnEuroSat.Text = "...";
            btnEuroSat.UseVisualStyleBackColor = true;
            btnEuroSat.Click += btnEuroSat_Click;
            // 
            // btnSatısYap2
            // 
            btnSatısYap2.Location = new Point(242, 179);
            btnSatısYap2.Name = "btnSatısYap2";
            btnSatısYap2.Size = new Size(124, 38);
            btnSatısYap2.TabIndex = 17;
            btnSatısYap2.Text = "İşlem 2";
            btnSatısYap2.UseVisualStyleBackColor = true;
            btnSatısYap2.Click += btnSatısYap2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(809, 547);
            Controls.Add(btnEuroSat);
            Controls.Add(btnDolarAl);
            Controls.Add(btnDolarSat);
            Controls.Add(btnEuroAl);
            Controls.Add(groupBox1);
            Controls.Add(lblEuroSatıs);
            Controls.Add(lblEuroAlıs);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblDolarAlıs);
            Controls.Add(lblDolarSatıs);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "DÖVİZ BÜROSU";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblDolarSatıs;
        private Label lblDolarAlıs;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblEuroAlıs;
        private Label lblEuroSatıs;
        private GroupBox groupBox1;
        private TextBox txtKalan;
        private Label label12;
        private TextBox txtTutar;
        private Label label11;
        private Button btnSatısYap;
        private TextBox txtMiktar;
        private Label label10;
        private TextBox txtKur;
        private Label label9;
        private Button btnEuroAl;
        private Button btnDolarSat;
        private Button btnDolarAl;
        private Button btnEuroSat;
        private Button btnSatısYap2;
    }
}
