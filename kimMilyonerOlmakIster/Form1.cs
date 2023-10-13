using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kimMilyonerOlmakIster
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            cekilButton.Enabled = false;
            soruGecButton.Enabled = false;
            sureUzatmaButton.Enabled = false;
            yarıYarıyaButton.Enabled = false;
            aSıkkıButton.Enabled = false;
            bSıkkıButton.Enabled = false;
            cSıkkıButton.Enabled = false;
            dSıkkıButton.Enabled = false;

        }


        #region Sorular & Cevaplar & Şıklar
        string[] sorular = new string[] {
          "Hangi ünlü sanatçıya ait 'Gece Devriyesi' tablosu bulunur?",
          "Nobel Barış Ödülü'nü alan ilk kadın kimdir?",
          "'Hamlet' ve 'Macbeth' gibi ünlü oyunların yazarı kimdir?",
          "'Guernica' tablosu hangi ünlü ressam tarafından yapılmıştır?",
          "'1984' ve 'Hayvan Çiftliği' gibi ünlü distopya romanlarının yazarı kimdir?",
          "Hangi ülke, 'Samuray' olarak bilinen savaşçılarıyla ünlüdür?",
          "'12 Öfkeli Adam' filmi hangi ünlü yönetmen tarafından yönetilmiştir?",
          "Hangi ünlü bilim insanı, 'Einstein'ın İzafiyet Teorisi'ni geliştirmiştir?",
          "'Gone with the Wind' (Rüzgar Gibi Geçti) filmi hangi yılda En İyi \n Film Oscar'ını kazanmıştır?",
          "'Üçüncü Adam' filmi hangi şehirde geçmektedir?",
          "Hangi ülke, 'Colosseum' olarak bilinen antik amfitiyatroya ev sahipliği \n yapmaktadır?",
          "'Sistine Şapeli'nde yer alan tavan freskleri hangi ünlü ressam tarafından \n yapılmıştır?"
        };

        string[] cevaplar = new string[] {
          "A) Vincent van Gogh",
          "B) Marie Curie",
          "A) William Shakespeare",
          "D) Pablo Picasso",
          "C) George Orwell",
          "D) Japonya",
          "A) Sidney Lumet",
          "B) Albert Einstein",
          "D) 1939",
          "C) Viyana",
          "B) İtalya",
          "D) Michelangelo"
        };

        string[] Asiklar = new string[] {
          "Vincent van Gogh",
          "Mother Teresa",
          "William Shakespeare",
          "Salvador Dali",
          "Ray Bradbury",
          "Vietnam",
          "Sidney Lumet",
          "Isaac Newton",
          "1942",
          "Londra",
          "Yunanistan",
          "Caravaggio",
        };

        string[] Bsiklar = new string[] {
          "Pablo Picasso",
          "Marie Curie",
          "Charles Dickens",
          "Vincent van Gogh",
          "Aldous Huxley",
          "Çin",
          "Francis Ford Coppola",
          "Albert Einstein",
          "1940",
          "Paris",
          "İtalya",
          "Leonardo da Vinci",
        };

        string[] Csiklar = new string[] {
          "Leonardo da Vinci",
          "Malala Yousafzai",
          "Jane Austen",
          "Claude Monet",
          "George Orwell",
          "Kore",
          "Stanley Kubrick",
          "Stephen Hawking",
          "1941" ,
          "Viyana",
          "Mısır",
          "Raphael",
        };

        string[] Dsiklar = new string[] {
          "Rembrandt" ,
          "Aung San Suu Kyi" ,
          "Fyodor Dostoevsky" ,
          "Pablo Picasso" ,
          "Jules Verne" ,
          "Japonya",
          "Martin Scorsese" ,
          "Niels Bohr" ,
          "1939" ,
          "Roma" ,
          "Türkiye" ,
          "Michelangelo"
        };
        #endregion

        #region Değişkenler
        int para = 0;
        byte soruArttir = 0, sorubekleme = 20;
        string hangiButton;
        #endregion




        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sorubekleme != 0)
            {
                sorubekleme--;
                sureLabel.Text = sorubekleme.ToString();
            }
            else if (sorubekleme == 0)
            {
                timer1.Stop();
                sureLabel.Text = "Süreniz Doldu !";
                sorubekleme = 0;
                cekilButton.Enabled = false;
                soruGecButton.Enabled = false;
                sureUzatmaButton.Enabled = false;
                yarıYarıyaButton.Enabled = false;
                aSıkkıButton.Enabled = false;
                bSıkkıButton.Enabled = false;
                cSıkkıButton.Enabled = false;
                dSıkkıButton.Enabled = false;

            }
        }


        #region Şık Butonları

        private void aSıkkıButton_Click(object sender, EventArgs e)
        {
            hangiButton = aSıkkıButton.Text;
            sorgula();
        }


        private void bSıkkıButton_Click(object sender, EventArgs e)
        {
            hangiButton = bSıkkıButton.Text;
            sorgula();
        }

        private void cSıkkıButton_Click(object sender, EventArgs e)
        {
            hangiButton = cSıkkıButton.Text;
            sorgula();
        }

        private void dSıkkıButton_Click(object sender, EventArgs e)
        {
            hangiButton = dSıkkıButton.Text;
            sorgula();
        }
        #endregion

        #region Joker Butonları
        private void yarıYarıyaButton_Click(object sender, EventArgs e)
        {

            DialogResult result1 = MessageBox.Show("Yarı Yarıya Joker Hakkınızı Kullanmak İstediğinize Emin Misiniz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes) {
                yarıYarıyaButton.Enabled = false;

                switch (soruArttir)
                {
                    case 0: bSıkkıButton.Enabled = false; cSıkkıButton.Enabled = false; break;
                    case 1: cSıkkıButton.Enabled = false; aSıkkıButton.Enabled = false; break;
                    case 2: bSıkkıButton.Enabled = false; cSıkkıButton.Enabled = false; break;
                    case 3: cSıkkıButton.Enabled = false; aSıkkıButton.Enabled = false; break;
                    case 4: dSıkkıButton.Enabled = false; aSıkkıButton.Enabled = false; break;
                    case 5: cSıkkıButton.Enabled = false; bSıkkıButton.Enabled = false; break;
                    case 6: cSıkkıButton.Enabled = false; dSıkkıButton.Enabled = false; break;
                    case 7: dSıkkıButton.Enabled = false; aSıkkıButton.Enabled = false; break;
                    case 8: cSıkkıButton.Enabled = false; bSıkkıButton.Enabled = false; break;
                    case 9: aSıkkıButton.Enabled = false; bSıkkıButton.Enabled = false; break;
                    case 10: aSıkkıButton.Enabled = false; dSıkkıButton.Enabled = false; break;
                    case 11: aSıkkıButton.Enabled = false; bSıkkıButton.Enabled = false; break;

                }
            }
        }

        private void sureUzatmaButton_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Süre Uzatma Joker Hakkınızı Kullanmak İstediğinize Emin Misiniz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                sureUzatmaButton.Enabled = false;
                sorubekleme += 20;
            }
        }
        #endregion

        #region Program Kontrol Butonları
        private void yarismaBaslatButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            cekilButton.Enabled = false;
            yarismaBaslatButton.Enabled = false;
            aSıkkıButton.Enabled = true;
            bSıkkıButton.Enabled = true;
            cSıkkıButton.Enabled = true;
            dSıkkıButton.Enabled = true;
            yarıYarıyaButton.Enabled = true;
            sureUzatmaButton.Enabled = true;


            soruLabel.Text = "1. Soru: " + sorular[0];
            aSıkkıButton.Text = "A) " + Asiklar[0];
            bSıkkıButton.Text = "B) " + Bsiklar[0];
            cSıkkıButton.Text = "C) " + Csiklar[0];
            dSıkkıButton.Text = "D) " + Dsiklar[0];
            label1.Text = soruArttir.ToString();

            binLiraLabell.BackColor = Color.Magenta;
        }

        private void cekilButton_Click(object sender, EventArgs e)
        {

            DialogResult result1 = MessageBox.Show("Çekilmek İstediğinizden Emin Misiniz", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                MessageBox.Show($"Çekildiniz... İşte Kazandığınız Para : {para}");
                cekilButton.Enabled = false;
                soruGecButton.Enabled = false;
                sureUzatmaButton.Enabled = false;
                yarıYarıyaButton.Enabled = false;
                aSıkkıButton.Enabled = false;
                bSıkkıButton.Enabled = false;
                cSıkkıButton.Enabled = false;
                dSıkkıButton.Enabled = false;
                timer1.Stop();
            }

        }

        private void soruGecButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            soruLabel.Text = $"{soruArttir}. Soru: " + sorular[soruArttir];
            aSıkkıButton.Text = "A) " + Asiklar[soruArttir];
            bSıkkıButton.Text = "B) " + Bsiklar[soruArttir];
            cSıkkıButton.Text = "C) " + Csiklar[soruArttir];
            dSıkkıButton.Text = "D) " + Dsiklar[soruArttir];


            kacinciSoruLabel.Text = "";
            soruGecButton.Enabled = false;
            cekilButton.Enabled = true;
            aSıkkıButton.Enabled = true;
            bSıkkıButton.Enabled = true;
            cSıkkıButton.Enabled = true;
            dSıkkıButton.Enabled = true;

            switch (soruArttir)
            {
                case 1:
                    binLiraLabell.BackColor = Color.Navy; besBinLiraLabel.BackColor = Color.Magenta; break;
                case 2:
                    besBinLiraLabel.BackColor = Color.Navy; yediBinLiraLabell.BackColor = Color.Magenta; break;
                case 3:
                    yediBinLiraLabell.BackColor = Color.Navy; onBinLiraLabell.BackColor = Color.Magenta; break;
                case 4:
                    onBinLiraLabell.BackColor = Color.Navy; yirmiBinLiraLabell.BackColor = Color.Magenta; break;
                case 5:
                    yirmiBinLiraLabell.BackColor = Color.Navy; otuzBinLiraLabell.BackColor = Color.Magenta; break;
                case 6:
                    otuzBinLiraLabell.BackColor = Color.Navy; elliBinLiraLabell.BackColor = Color.Magenta; break;
                case 7:
                    elliBinLiraLabell.BackColor = Color.Navy; yüzBinLiraLabell.BackColor = Color.Magenta; break;
                case 8:
                    yüzBinLiraLabell.BackColor = Color.Navy; ikiyüzBinLiraLabell.BackColor = Color.Magenta; break;
                case 9:
                    ikiyüzBinLiraLabell.BackColor = Color.Navy; ücyüzBinLiraLabell.BackColor = Color.Magenta; break;
                case 10:
                    ücyüzBinLiraLabell.BackColor = Color.Navy; besyüzBinLiraLabell.BackColor = Color.Magenta; break;
                case 11:
                    besyüzBinLiraLabell.BackColor = Color.Navy; birMilyonLiraLabel.BackColor = Color.Magenta; break;
            } //Para Ağacı Durum Rengi

            switch (soruArttir)
            {
                case 1:
                    para = 1000; label2.Text = para.ToString(); break;
                case 2:
                    para = 5000; label2.Text = para.ToString(); break;
                case 3:
                    para = 7500; label2.Text = para.ToString(); break;
                case 4:
                    para = 10000; label2.Text = para.ToString(); break;
                case 5:
                    para = 20000; label2.Text = para.ToString(); break;
                case 6:
                    para = 30000; label2.Text = para.ToString(); break;
                case 7:
                    para = 50000; label2.Text = para.ToString(); break;
                case 8:
                    para = 100000; label2.Text = para.ToString(); break;
                case 9:
                    para = 200000; label2.Text = para.ToString(); break;
                case 10:
                    para = 300000; label2.Text = para.ToString(); break;
                case 11:
                    para = 500000; label2.Text = para.ToString(); break;
                case 12:
                    para = 1000000; label2.Text = para.ToString(); break;


            } //Para Göstergesi
        }
        #endregion


        private void sorgula()
        {
            DialogResult result = MessageBox.Show(" Cevabınızdan Emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                timer1.Stop();
                sureLabel.Text = "cevaplandı";
                aSıkkıButton.Enabled = false;
                bSıkkıButton.Enabled = false;
                cSıkkıButton.Enabled = false;
                dSıkkıButton.Enabled = false;

                if (hangiButton == cevaplar[soruArttir])
                {
                    kacinciSoruLabel.Text = "Tebrikler Doğru Cevap!";
                    soruGecButton.Enabled = Enabled;
                    sorubekleme = 20;
                    soruArttir++;
                    label1.Text = soruArttir.ToString();

                }
                else
                {
                    if (para >= 5000 && para < 50000)
                    {
                        DialogResult result1 = MessageBox.Show(" Yanlış Cevap, Elendiniz... Barajı Geçtiğiniz için 5 BİN TL İLE AYRILIYORSUNUZ.. !", "Elendiniz !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (result1 == DialogResult.OK)
                        {
                            cekilButton.Enabled = false;
                            soruGecButton.Enabled = false;
                            sureUzatmaButton.Enabled = false;
                            yarıYarıyaButton.Enabled = false;
                            aSıkkıButton.Enabled = false;
                            bSıkkıButton.Enabled = false;
                            cSıkkıButton.Enabled = false;
                            dSıkkıButton.Enabled = false;
                            timer1.Stop();

                            kacinciSoruLabel.Text = $"Yanlış Cevapladınız.. Doğru cevap: {cevaplar[soruArttir]}";
                        }
                    }
                    else if (para >= 50000)
                    {
                        DialogResult result2 = MessageBox.Show(" Yanlış Cevap, Elendiniz... Barajı Geçtiğiniz için 50 BİN TL İLE AYRILIYORSUNUZ.. !", "Elendiniz !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (result2 == DialogResult.OK)
                        {
                            cekilButton.Enabled = false;
                            soruGecButton.Enabled = false;
                            sureUzatmaButton.Enabled = false;
                            yarıYarıyaButton.Enabled = false;
                            aSıkkıButton.Enabled = false;
                            bSıkkıButton.Enabled = false;
                            cSıkkıButton.Enabled = false;
                            dSıkkıButton.Enabled = false;
                            timer1.Stop();

                            kacinciSoruLabel.Text = $"Yanlış Cevapladınız.. Doğru cevap: {cevaplar[soruArttir]}" ;
                        }
                    }

                    else
                    {
                        DialogResult result3 = MessageBox.Show(" Yanlış Cevap, Elendiniz !", "Elendiniz !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         if (result3 == DialogResult.OK)
                         {
                             cekilButton.Enabled = false;
                             soruGecButton.Enabled = false;
                             sureUzatmaButton.Enabled = false;
                             yarıYarıyaButton.Enabled = false;
                             aSıkkıButton.Enabled = false;
                             bSıkkıButton.Enabled = false;
                             cSıkkıButton.Enabled = false;
                             dSıkkıButton.Enabled = false;
                             timer1.Stop();

                             kacinciSoruLabel.Text = $"Yanlış Cevapladınız.. Doğru cevap: {cevaplar[soruArttir]}";
                         }
                    }
                }


            }
        }

    }
}

