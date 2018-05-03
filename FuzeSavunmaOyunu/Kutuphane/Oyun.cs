using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace FuzeSavunmaOyunu.Kutuphane
{
    public class Oyun
    {
        public Form Form { set; get; }
        public Timer Timer { set; get; }

        public GelismisPictureBox GCPT_DUZ { set; get; }
        public GelismisPictureBox GPCT_UST { set; get; }        
        public GelismisPictureBox GPCT_ALT { set; get; }
        
        public List<Fuze> Fuzeler { set; get; }

        private int _can;
        private int _skor;
        private int _seviye;
        public int Can
        {
            set
            {
                this._can = value; 
                this.LblCan.Text = value.ToString();
            }
            get
            {
                return this._can;
            }
        }
        public int Skor
        {
            set
            {
                this._skor = value; 
                this.LblSkor.Text = value.ToString();
            }
            get
            {
                return this._skor;
            }
        }
        public int Seviye
        {
            set
            {
                this._seviye = value; 
                this.LblSeviye.Text = value.ToString();
            }
            get
            {
                return this._seviye;
            }
        }
        Label LblCan { set; get; }
        Label LblSkor { set; get; }
        Label LblSeviye { set; get; }

        public int ToplamUretilecekFuzeSayisi = 1;
        
        public GelismisPictureBox GPCT_Hedef { set; get; }

        private Random R = new Random();

        public Oyun(Form form, Timer timer, GelismisPictureBox hedef, GelismisPictureBox duz, GelismisPictureBox ust, GelismisPictureBox alt)
        {
            this.Form = form;
            this.Timer = timer;
            this.GCPT_DUZ = duz;
            this.GPCT_UST = ust;
            this.GPCT_ALT = alt;
            this.GPCT_Hedef = hedef;
            this.Fuzeler = new List<Fuze>();
        }
        public void OyunPanelleriAta(Label lblCan,Label lblSkor,Label lblSeviye)
        {
            this.LblCan = lblCan;
            this.LblSeviye = lblSeviye;
            this.LblSkor = lblSkor;
        }
        public void YeniOyun()
        {
            this.Can = 5;
            this.Seviye = 1;
            this.Skor = 0;
            this.ToplamUretilecekFuzeSayisi = 1;                        
            FuzeleriTemizle();
            FuzeEkle();
            this.Timer.Enabled = true;            
        }
        public void Guncelle()
        {
            for(int i=0;i<Fuzeler.Count();i++)
            {
                if (Fuzeler[i] != null)
                {
                    Fuzeler[i].Guncelle();
                    if (Fuzeler[i].VurduMu())
                    {
                        this.CanAzalt();
                        Fuzeler[i].PictureBox.Dispose();
                        Fuzeler[i] = null;
                        FuzeEkle();
                    }
                    else if (Fuzeler[i].VurulduMu)
                    {
                        Fuzeler[i].PictureBox.Dispose();
                        Fuzeler[i] = null;
                        FuzeEkle();
                    }
                }
            }
        }
        public void VurulduMu()
        {
            for (int i = 0; i < Fuzeler.Count(); i++)
            {
                if (Fuzeler[i] != null)
                {
                    if (Fuzeler[i].VurulduMuAcaba())
                    {
                        this.Skor += 10;
                        this.Can++;
                        if ((this.Skor % 50) == 0)
                        {
                            this.Seviye++;
                            this.ToplamUretilecekFuzeSayisi++;
                            FuzeEkle();
                        }
                        else if ((this.Skor % 100) == 0)
                        {
                            this.Seviye++;
                            if (this.Timer.Interval - 10 == 0)
                            {
                                this.Timer.Interval = 1;
                            }
                            else
                            {
                                this.Timer.Interval -= 10;
                            }
                        }
                    }
                }
            }
        }
        private void FuzeEkle()
        {
            Fuze fuze = new Fuze(this);
            fuze.Left = fuze.Width * (-1);
            fuze.UsttenOffset = R.Next(0, this.Form.Height);
            Debug.WriteLine(fuze.UsttenOffset);
            this.Fuzeler.Add(fuze);
            fuze.FormaGir();
        }
        private void CanAzalt()
        {
            this.Can--;
            if (this.Can == 0)
            {
                this.Timer.Stop();
                MessageBox.Show("Canlar bitti !!!");
            }
        }
        private void FuzeleriTemizle()
        {
            for (int i = 0; i < Fuzeler.Count; i++)
            {
                if (this.Fuzeler[i] != null)
                {
                    this.Fuzeler[i].PictureBox.Dispose();
                }
            }
            this.Fuzeler = new List<Fuze>();
        }
    }
}
