
namespace HelloForm
{
    partial class Form4
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
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.listBoxAsinifi = new System.Windows.Forms.ListBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblSinifSecimi = new System.Windows.Forms.Label();
            this.listBoxBsinifi = new System.Windows.Forms.ListBox();
            this.comboBoxSinifSecimi = new System.Windows.Forms.ComboBox();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.btnSagaGonder = new System.Windows.Forms.Button();
            this.btnHepsiniSagaGonder = new System.Windows.Forms.Button();
            this.btnSolaGonder = new System.Windows.Forms.Button();
            this.btnHepsiniSolaGonder = new System.Windows.Forms.Button();
            this.xMLİleDışarıAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLİleİiçeriVeriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dTarihidateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.OgrenciBilgilerigroupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSecmeliDers = new System.Windows.Forms.CheckBox();
            this.checkedListSecmeliDers = new System.Windows.Forms.CheckedListBox();
            this.groupBoxSecmeliDersler = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLIleDisaAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLIleIceriVeriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OgrenciBilgilerigroupBox1.SuspendLayout();
            this.groupBoxSecmeliDersler.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(10, 22);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(25, 15);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(10, 55);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(39, 15);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(10, 86);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(78, 15);
            this.lblDogumTarihi.TabIndex = 2;
            this.lblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // listBoxAsinifi
            // 
            this.listBoxAsinifi.FormattingEnabled = true;
            this.listBoxAsinifi.ItemHeight = 15;
            this.listBoxAsinifi.Location = new System.Drawing.Point(10, 292);
            this.listBoxAsinifi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAsinifi.Name = "listBoxAsinifi";
            this.listBoxAsinifi.Size = new System.Drawing.Size(257, 154);
            this.listBoxAsinifi.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(101, 50);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(192, 23);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(101, 17);
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(192, 23);
            this.txtAd.TabIndex = 6;
            // 
            // lblSinifSecimi
            // 
            this.lblSinifSecimi.AutoSize = true;
            this.lblSinifSecimi.Location = new System.Drawing.Point(10, 138);
            this.lblSinifSecimi.Name = "lblSinifSecimi";
            this.lblSinifSecimi.Size = new System.Drawing.Size(68, 15);
            this.lblSinifSecimi.TabIndex = 7;
            this.lblSinifSecimi.Text = "Sınıf Seçimi";
            // 
            // listBoxBsinifi
            // 
            this.listBoxBsinifi.FormattingEnabled = true;
            this.listBoxBsinifi.ItemHeight = 15;
            this.listBoxBsinifi.Location = new System.Drawing.Point(412, 292);
            this.listBoxBsinifi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxBsinifi.Name = "listBoxBsinifi";
            this.listBoxBsinifi.Size = new System.Drawing.Size(258, 154);
            this.listBoxBsinifi.TabIndex = 9;
            // 
            // comboBoxSinifSecimi
            // 
            this.comboBoxSinifSecimi.FormattingEnabled = true;
            this.comboBoxSinifSecimi.Location = new System.Drawing.Point(101, 138);
            this.comboBoxSinifSecimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSinifSecimi.Name = "comboBoxSinifSecimi";
            this.comboBoxSinifSecimi.Size = new System.Drawing.Size(192, 23);
            this.comboBoxSinifSecimi.TabIndex = 10;
            this.comboBoxSinifSecimi.Text = "Sinif Secimi...";
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(318, 34);
            this.btnOgrenciEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(140, 118);
            this.btnOgrenciEkle.TabIndex = 11;
            this.btnOgrenciEkle.Text = "ÖĞRENCİ EKLE";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // btnSagaGonder
            // 
            this.btnSagaGonder.Location = new System.Drawing.Point(300, 314);
            this.btnSagaGonder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSagaGonder.Name = "btnSagaGonder";
            this.btnSagaGonder.Size = new System.Drawing.Size(70, 24);
            this.btnSagaGonder.TabIndex = 12;
            this.btnSagaGonder.Text = ">";
            this.btnSagaGonder.UseVisualStyleBackColor = true;
            this.btnSagaGonder.Click += new System.EventHandler(this.btnSagaGonder_Click);
            // 
            // btnHepsiniSagaGonder
            // 
            this.btnHepsiniSagaGonder.Location = new System.Drawing.Point(300, 340);
            this.btnHepsiniSagaGonder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHepsiniSagaGonder.Name = "btnHepsiniSagaGonder";
            this.btnHepsiniSagaGonder.Size = new System.Drawing.Size(70, 24);
            this.btnHepsiniSagaGonder.TabIndex = 13;
            this.btnHepsiniSagaGonder.Text = ">>";
            this.btnHepsiniSagaGonder.UseVisualStyleBackColor = true;
            this.btnHepsiniSagaGonder.Click += new System.EventHandler(this.btnHepsiniSagaGonder_Click);
            // 
            // btnSolaGonder
            // 
            this.btnSolaGonder.Location = new System.Drawing.Point(300, 366);
            this.btnSolaGonder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSolaGonder.Name = "btnSolaGonder";
            this.btnSolaGonder.Size = new System.Drawing.Size(70, 24);
            this.btnSolaGonder.TabIndex = 14;
            this.btnSolaGonder.Text = "<";
            this.btnSolaGonder.UseVisualStyleBackColor = true;
            this.btnSolaGonder.Click += new System.EventHandler(this.btnSolaGonder_Click);
            // 
            // btnHepsiniSolaGonder
            // 
            this.btnHepsiniSolaGonder.Location = new System.Drawing.Point(300, 393);
            this.btnHepsiniSolaGonder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHepsiniSolaGonder.Name = "btnHepsiniSolaGonder";
            this.btnHepsiniSolaGonder.Size = new System.Drawing.Size(70, 24);
            this.btnHepsiniSolaGonder.TabIndex = 15;
            this.btnHepsiniSolaGonder.Text = "<<";
            this.btnHepsiniSolaGonder.UseVisualStyleBackColor = true;
            this.btnHepsiniSolaGonder.Click += new System.EventHandler(this.btnHepsiniSolaGonder_Click);
            // 
            // xMLİleDışarıAktarToolStripMenuItem
            // 
            this.xMLİleDışarıAktarToolStripMenuItem.Name = "xMLİleDışarıAktarToolStripMenuItem";
            this.xMLİleDışarıAktarToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.xMLİleDışarıAktarToolStripMenuItem.Text = "XML ile dışarı aktar";
            // 
            // xMLİleİiçeriVeriAlToolStripMenuItem
            // 
            this.xMLİleİiçeriVeriAlToolStripMenuItem.Name = "xMLİleİiçeriVeriAlToolStripMenuItem";
            this.xMLİleİiçeriVeriAlToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.xMLİleİiçeriVeriAlToolStripMenuItem.Text = "XML ile iiçeri veri al";
            // 
            // dTarihidateTimePicker1
            // 
            this.dTarihidateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTarihidateTimePicker1.Location = new System.Drawing.Point(101, 86);
            this.dTarihidateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTarihidateTimePicker1.Name = "dTarihidateTimePicker1";
            this.dTarihidateTimePicker1.Size = new System.Drawing.Size(192, 23);
            this.dTarihidateTimePicker1.TabIndex = 17;
            // 
            // OgrenciBilgilerigroupBox1
            // 
            this.OgrenciBilgilerigroupBox1.Controls.Add(this.btnOgrenciEkle);
            this.OgrenciBilgilerigroupBox1.Controls.Add(this.lblAd);
            this.OgrenciBilgilerigroupBox1.Controls.Add(this.dTarihidateTimePicker1);
            this.OgrenciBilgilerigroupBox1.Controls.Add(this.lblSoyad);
            this.OgrenciBilgilerigroupBox1.Controls.Add(this.lblDogumTarihi);
            this.OgrenciBilgilerigroupBox1.Controls.Add(this.txtSoyad);
            this.OgrenciBilgilerigroupBox1.Controls.Add(this.txtAd);
            this.OgrenciBilgilerigroupBox1.Controls.Add(this.lblSinifSecimi);
            this.OgrenciBilgilerigroupBox1.Controls.Add(this.comboBoxSinifSecimi);
            this.OgrenciBilgilerigroupBox1.Location = new System.Drawing.Point(10, 38);
            this.OgrenciBilgilerigroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OgrenciBilgilerigroupBox1.Name = "OgrenciBilgilerigroupBox1";
            this.OgrenciBilgilerigroupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OgrenciBilgilerigroupBox1.Size = new System.Drawing.Size(458, 176);
            this.OgrenciBilgilerigroupBox1.TabIndex = 18;
            this.OgrenciBilgilerigroupBox1.TabStop = false;
            this.OgrenciBilgilerigroupBox1.Text = "Öğrenci Bilgileri";
            // 
            // checkBoxSecmeliDers
            // 
            this.checkBoxSecmeliDers.AutoSize = true;
            this.checkBoxSecmeliDers.Location = new System.Drawing.Point(10, 208);
            this.checkBoxSecmeliDers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxSecmeliDers.Name = "checkBoxSecmeliDers";
            this.checkBoxSecmeliDers.Size = new System.Drawing.Size(220, 19);
            this.checkBoxSecmeliDers.TabIndex = 19;
            this.checkBoxSecmeliDers.Text = "Secmeli Ders almak istiyor musunuz?";
            this.checkBoxSecmeliDers.UseVisualStyleBackColor = true;
            this.checkBoxSecmeliDers.CheckedChanged += new System.EventHandler(this.checkBoxSecmeliDers_CheckedChanged);
            // 
            // checkedListSecmeliDers
            // 
            this.checkedListSecmeliDers.FormattingEnabled = true;
            this.checkedListSecmeliDers.Items.AddRange(new object[] {
            "İnsan Kaynakları",
            "Toplum Hizmeti",
            "İtalyanca",
            "Evrim Teorisi",
            "Halk Sağlığı"});
            this.checkedListSecmeliDers.Location = new System.Drawing.Point(6, 20);
            this.checkedListSecmeliDers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListSecmeliDers.Name = "checkedListSecmeliDers";
            this.checkedListSecmeliDers.Size = new System.Drawing.Size(190, 202);
            this.checkedListSecmeliDers.TabIndex = 20;
            this.checkedListSecmeliDers.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // groupBoxSecmeliDersler
            // 
            this.groupBoxSecmeliDersler.Controls.Add(this.checkedListSecmeliDers);
            this.groupBoxSecmeliDersler.Location = new System.Drawing.Point(529, 38);
            this.groupBoxSecmeliDersler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSecmeliDersler.Name = "groupBoxSecmeliDersler";
            this.groupBoxSecmeliDersler.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSecmeliDersler.Size = new System.Drawing.Size(219, 227);
            this.groupBoxSecmeliDersler.TabIndex = 18;
            this.groupBoxSecmeliDersler.TabStop = false;
            this.groupBoxSecmeliDersler.Text = "Secmeli Dersler";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLIleDisaAktarToolStripMenuItem,
            this.xMLIleIceriVeriAlToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // xMLIleDisaAktarToolStripMenuItem
            // 
            this.xMLIleDisaAktarToolStripMenuItem.Name = "xMLIleDisaAktarToolStripMenuItem";
            this.xMLIleDisaAktarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xMLIleDisaAktarToolStripMenuItem.Text = "XML ile dışa aktar";
            this.xMLIleDisaAktarToolStripMenuItem.Click += new System.EventHandler(this.xMLIleDisaAktarToolStripMenuItem_Click);
            // 
            // xMLIleIceriVeriAlToolStripMenuItem
            // 
            this.xMLIleIceriVeriAlToolStripMenuItem.Name = "xMLIleIceriVeriAlToolStripMenuItem";
            this.xMLIleIceriVeriAlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xMLIleIceriVeriAlToolStripMenuItem.Text = "XML ile içeri veri al";
            this.xMLIleIceriVeriAlToolStripMenuItem.Click += new System.EventHandler(this.xMLIleIceriVeriAlToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 504);
            this.Controls.Add(this.groupBoxSecmeliDersler);
            this.Controls.Add(this.checkBoxSecmeliDers);
            this.Controls.Add(this.OgrenciBilgilerigroupBox1);
            this.Controls.Add(this.btnHepsiniSolaGonder);
            this.Controls.Add(this.btnSolaGonder);
            this.Controls.Add(this.btnHepsiniSagaGonder);
            this.Controls.Add(this.btnSagaGonder);
            this.Controls.Add(this.listBoxBsinifi);
            this.Controls.Add(this.listBoxAsinifi);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.OgrenciBilgilerigroupBox1.ResumeLayout(false);
            this.OgrenciBilgilerigroupBox1.PerformLayout();
            this.groupBoxSecmeliDersler.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.ListBox listBoxAsinifi;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblSinifSecimi;
        private System.Windows.Forms.ListBox listBoxBsinifi;
        private System.Windows.Forms.ComboBox comboBoxSinifSecimi;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Button btnSagaGonder;
        private System.Windows.Forms.Button btnHepsiniSagaGonder;
        private System.Windows.Forms.Button btnSolaGonder;
        private System.Windows.Forms.Button btnHepsiniSolaGonder;
        private System.Windows.Forms.DateTimePicker dTarihidateTimePicker1;
        private System.Windows.Forms.GroupBox OgrenciBilgilerigroupBox1;
        private System.Windows.Forms.CheckBox checkBoxSecmeliDers;
        private System.Windows.Forms.CheckedListBox checkedListSecmeliDers;
        private System.Windows.Forms.GroupBox groupBoxSecmeliDersler;
        private System.Windows.Forms.ToolStripMenuItem xMLİleDışarıAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLİleİiçeriVeriAlToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLIleDisaAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLIleIceriVeriAlToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}