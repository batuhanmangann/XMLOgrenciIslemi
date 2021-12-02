using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HelloForm
{
    public partial class Form4 : Form
    {
        //Global alan

        List<string> SiniflarListesi = new List<string>() { "A sınıfı", "B sınıfı" };
        List<Ogrenci> ASinifiOgrencileri = new List<Ogrenci>();
        List<Ogrenci> BSinifiOgrencileri = new List<Ogrenci>();
        List<string> SecilenSecmeliDersler = new List<string>();


        public Form4()
        {
            InitializeComponent();


            //comboBoxSinifSecimi.Items.AddRange(SiniflarListesi.ToArray());

            //ister yukarddaki ister aşağıdaki gibi yapabiliriz.

            foreach (var item in SiniflarListesi)
            {
                comboBoxSinifSecimi.Items.Add(item);
            }

            txtAd.TabIndex = 0;
            txtSoyad.TabIndex = 1;
            dTarihidateTimePicker1.TabIndex = 2;
            comboBoxSinifSecimi.TabIndex = 3;
            btnOgrenciEkle.TabIndex = 4;
            listBoxAsinifi.TabIndex = 5;
            groupBoxSecmeliDersler.Enabled = false;
            checkedListSecmeliDers.CheckOnClick = true;
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text))
            {
                MessageBox.Show("Lütfen ad soyad giriniz.");
            }
            else
            {
                Ogrenci ogr1 = new Ogrenci()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    DTarihi = dTarihidateTimePicker1.Value
                };

                // comboboxa seçtiği değer.
                if (AsinifindaAyniOgrencidenVarMi(ogr1))
                {
                    MessageBox.Show("Bu öğrenci zaten A sınıfında mevcut."); //yada
                }
                else if (BsinifindaAyniOgrencidenVarMi(ogr1))
                {
                    MessageBox.Show("Bu öğrenci B sınıfında zaten mevcut.");
                }
                else if (comboBoxSinifSecimi.SelectedIndex == -1)
                {
                    //-1 demek seçim yapılmamış demek.
                    MessageBox.Show("Lütfen sınıf seçiniz.");
                }
                else
                {
                    ogr1.Sinifi = comboBoxSinifSecimi.SelectedItem.ToString();

                    //Artık öğrenciyi listeye eklemeliyiz.
                    switch (comboBoxSinifSecimi.SelectedIndex)
                    {
                        case 0: //A sınıfıdır.
                            if (AsinifindaAyniOgrencidenVarMi(ogr1) == false)
                            {
                                //if (BsinifindaAyniOgrencidenVarMi(ogr1))
                                //{
                                //    MessageBox.Show("B sınıfında aynı öğrenci var.");
                                //}
                                //else 
                                //{
                                //    ASinifiOgrencileri.Add(ogr1);
                                //}
                                ASinifiOgrencileri.Add(ogr1);

                            }
                            else
                            {
                                MessageBox.Show("Öğrenci sistemde zaten bulunuyor.", "UYARI", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }

                            break;
                        case 1: // B sınıfıdır.
                            if (BsinifindaAyniOgrencidenVarMi(ogr1) == false)
                            {
                                //if (AsinifindaAyniOgrencidenVarMi(ogr1))
                                //{
                                //    MessageBox.Show("A sınıfında aynı öğrenci var.");
                                //}
                                //else
                                //{
                                //    BSinifiOgrencileri.Add(ogr1); // ----> 128-136 arasındaki linelarda hallettik
                                //}
                                BSinifiOgrencileri.Add(ogr1);

                            }
                            else
                            {
                                MessageBox.Show("Öğrenci sistemde zaten bulunuyor.", "UYARI", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }

                            break;

                        default:
                            break;

                    }
                    ogr1.SecmeliDersAliyorMu = checkBoxSecmeliDers.Checked;
                    if (ogr1.SecmeliDersAliyorMu)
                    {
                        ogr1.AldigiSecmeliDersler.AddRange(SecilenSecmeliDersler);
                    }

                    KontrolleriTemizle();
                    ListeleriDoldur();
                }
            }
        }

        private bool AsinifindaAyniOgrencidenVarMi(Ogrenci ogrenci)
        {
            bool sonuc = false;

            foreach (var item in ASinifiOgrencileri)
            {
                if (item.Ad == ogrenci.Ad && item.Soyad == ogrenci.Soyad &&
                    item.DTarihi.ToShortDateString() == ogrenci.DTarihi.ToShortDateString())
                {
                    sonuc = true;
                    break;
                }
            }


            return sonuc;
        }
        private bool BsinifindaAyniOgrencidenVarMi(Ogrenci ogrenci)
        {
            bool sonuc = false;

            foreach (var item in BSinifiOgrencileri)
            {
                if (item.Ad == ogrenci.Ad && item.Soyad == ogrenci.Soyad &&
                    item.DTarihi.ToShortDateString() == ogrenci.DTarihi.ToShortDateString())
                {
                    sonuc = true;
                    break;
                }
            }


            return sonuc;
        }


        private void KontrolleriTemizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = string.Empty;
            comboBoxSinifSecimi.SelectedIndex = -1;
            comboBoxSinifSecimi.Text = "Sınıfınızı seçiniz...";
            dTarihidateTimePicker1.Value = DateTime.Now;
            SecilenSecmeliDersler.Clear();
            foreach (int indexi in checkedListSecmeliDers.CheckedIndices)
            {
                checkedListSecmeliDers.SetItemCheckState(indexi, CheckState.Unchecked);
            }
            SecilenSecmeliDersler.Clear();
            checkBoxSecmeliDers.Checked = false;

        }
        private void ListeleriDoldur()
        {
            listBoxAsinifi.Items.Clear();
            listBoxAsinifi.BackColor = Color.AliceBlue;
            listBoxAsinifi.Items.AddRange(ASinifiOgrencileri.ToArray());

            listBoxBsinifi.Items.Clear();
            listBoxBsinifi.BackColor = Color.Azure;
            listBoxBsinifi.Items.AddRange(BSinifiOgrencileri.ToArray());
        }

        private void btnHepsiniSagaGonder_Click(object sender, EventArgs e)
        {
            // A sınıfındaki herkesi Bye gönderecek.
            foreach (var item in ASinifiOgrencileri)
            {
                item.Sinifi = "B sınıfı";
            }
            BSinifiOgrencileri.AddRange(ASinifiOgrencileri.ToArray());
            ASinifiOgrencileri.Clear();
            ListeleriDoldur();
        }

        private void btnHepsiniSolaGonder_Click(object sender, EventArgs e)
        {
            // B sınıfındaki herkesi Bye gönderecek.
            foreach (var item in BSinifiOgrencileri)
            {
                item.Sinifi = "A sınıfı";
            }
            ASinifiOgrencileri.AddRange(BSinifiOgrencileri.ToArray());
            BSinifiOgrencileri.Clear();
            ListeleriDoldur();
        }

        private void btnSagaGonder_Click(object sender, EventArgs e)
        {
            Ogrenci transferEdilecekOgr = (Ogrenci)listBoxAsinifi.SelectedItem;
            if (transferEdilecekOgr != null)
            {
                ASinifiOgrencileri.Remove(transferEdilecekOgr);
                transferEdilecekOgr.Sinifi = "B sınıfı";
                BSinifiOgrencileri.Add(transferEdilecekOgr);
                ListeleriDoldur();
            }


        }

        private void btnSolaGonder_Click(object sender, EventArgs e)
        {
            Ogrenci transferEdilecekOgr = (Ogrenci)listBoxBsinifi.SelectedItem;
            if (transferEdilecekOgr != null)
            {
                BSinifiOgrencileri.Remove(transferEdilecekOgr);
                transferEdilecekOgr.Sinifi = "A sınıfı";
                ASinifiOgrencileri.Add(transferEdilecekOgr);
                ListeleriDoldur();
            }
        }

        private void checkBoxSecmeliDers_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSecmeliDers.Checked)
            {
                groupBoxSecmeliDersler.Enabled = true;
            }
            else
            {
                groupBoxSecmeliDersler.Enabled = false;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SecilenSecmeliDersler.Clear();
            foreach (var item in checkedListSecmeliDers.CheckedItems)
            {
                if (SecilenSecmeliDersler.Count(x => x == item.ToString()) == 0)
                {
                    SecilenSecmeliDersler.Add(item.ToString());
                }

            }
        }

        private void IslemlertoolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void xMLIleDisaAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Ogrenci> DisariAktarilacklar = new List<Ogrenci>();
            if (ASinifiOgrencileri.Count > 0)
            {
                DisariAktarilacklar.AddRange(ASinifiOgrencileri);
            }
            if (BSinifiOgrencileri.Count > 0)
            {
                DisariAktarilacklar.AddRange(BSinifiOgrencileri);
            }
            saveFileDialog1.Title = "Öğrenci XML Dosyası Kaydet";
            saveFileDialog1.Filter = "XML Formatı | *.xml";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer myXMLSerializer = new XmlSerializer(typeof(List<Ogrenci>));
                using (StreamWriter yazar = new StreamWriter(saveFileDialog1.FileName))
                {
                    myXMLSerializer.Serialize(yazar, DisariAktarilacklar);
                }
                MessageBox.Show($"{DisariAktarilacklar.Count} adet öğrenci xml dosyası olarak aktarıldı.");
            }
        }

        private void xMLIleIceriVeriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KontrolleriTemizle();
            openFileDialog1.Title = "XML Dosyanızı Seçiniz";
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer myXMLSerializer = new XmlSerializer(typeof(List<Ogrenci>));
                using (StreamReader okuyucu = new StreamReader(openFileDialog1.FileName))
                {
                    ASinifiOgrencileri = myXMLSerializer.Deserialize(okuyucu) as List<Ogrenci>;
                    MessageBox.Show($"{ASinifiOgrencileri.Count} adet kişi içeri aktarıldı.");
                    ListeleriDoldur();
                }
            }
        }
    }
}
