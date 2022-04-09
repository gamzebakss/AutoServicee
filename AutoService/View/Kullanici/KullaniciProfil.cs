﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService
{
    public partial class KullaniciProfil : Form
    {
        private Kullanici _kul { get; set; }

       public KullaniciProfil(int kullaniciID)
        {
           _kul = KullaniciController.BilgileriGetir(kullaniciID);
            InitializeComponent();  

        }

        private void KullaniciProfil_Load(object sender, EventArgs e)
        {
         
            AraclariDoldur();

            this.kullanicilarTableAdapter.Fill(this.autoServiceDataSet1.Kullanicilar);

        }
        private void btnYükle_Click(object sender, EventArgs e)
        {
            try
            {

                openFileDialog1.Title = "Lütfen bir profil fotografı seçiniz.";
                openFileDialog1.DefaultExt = ".png";
                openFileDialog1.Filter = "PNG|*.png|JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif";
                // openFileDialog1.ShowDialog();


                if (!Directory.Exists(Application.StartupPath + "\\ProfilFotolari\\"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\ProfilFotolari\\");
                }

                DialogResult sonuc = openFileDialog1.ShowDialog();

                if (sonuc == DialogResult.OK)
                {
                    Image img = Image.FromFile(openFileDialog1.FileName);
                    //Fotografı diske kaydetiğimiz yer burası
                    string extension = Path.GetExtension(openFileDialog1.FileName);//Yüklenen dosyanın dosya uzantısını alır
                    string dosyaAdi = _kul.id + "-" + Tools.TurkceKarakterTemizle(_kul.Ad + "-" + _kul.Soyad) + "Profilfoto-" + Tools.RandomString(6) + extension;
                    img.Save(Application.StartupPath + "\\ProfilFotolari\\" + dosyaAdi);



                    pictpProfilResmi.Image = img;
                    if (KullaniciController.ProfilFotoGuncelle(dosyaAdi, _kul.id))
                    {
                        MesajKutusu kutu = new MesajKutusu("Başarılı", "Profil Fotografı Basarılı Şekilde Yüklenmiştir", MesajIkon.Bilgi, MesajButton.Tamam);
                        kutu.ShowDialog();
                        kutu.Dispose();
                    }
                    else
                    {
                        MesajKutusu kutu = new MesajKutusu("Bir hata oluştu", "Fotografyolu vri abanına yazılırken hata meydana geldi", MesajIkon.Hata, MesajButton.Tamam);
                        kutu.ShowDialog();
                        kutu.Dispose();
                    }

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            AracEkle frm = new AracEkle(_kul.id);
            frm.ShowDialog();
            AraclariDoldur();
        }

        private void btnAracListele_Click(object sender, EventArgs e)
        {
            AracProfilForm aracProfilForm = new AracProfilForm((lstbxKullanıcıProfil.SelectedItem as Arac).id);
            aracProfilForm.ShowDialog();

        }

        private void AraclariDoldur()
        {
           
            pictpProfilResmi.ImageLocation = Application.StartupPath + "\\ProfilFotolari\\" + _kul.ProfilFoto;
            string deneme = Tools.RandomString(6);
            lblAdSoyad.Text = _kul.Ad + " " + _kul.Soyad;
            lblKullanıcıProfilAdres.Text = _kul.Adres;
            lblKullanıcıProfilGm.Text = _kul.Gsm;
            lblKullanıcıProfilEmail.Text = _kul.Email;
            lblKullanıcıProfilTicariU.Text = _kul.TicariUnvan;
            lblKullanıcıProfilVergiN.Text = _kul.VergiNo;
            lblVergiDairesi.Text = _kul.VergiDairesi;

            lstbxKullanıcıProfil.DataSource = AracControllers.Listele(_kul.id);
            lstbxKullanıcıProfil.ValueMember = "id";
            lstbxKullanıcıProfil.DisplayMember = "Ad";

            if (_kul.MusteriTipi == 1)
            {
                lblMusteriTipi.Text = "KURUMSAL";
                pnlKurumsal.Visible = true;
            }
        }
      
    }
}
