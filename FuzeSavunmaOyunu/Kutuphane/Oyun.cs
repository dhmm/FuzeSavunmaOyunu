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
        
        public Fuze[] Fuzeler { set; get; }
        public List<Patlama> Patlamalar { set; get; }
        private int SonrakiIndex = 0;
        private int FuzeSayisi = 0;
        private readonly int MAX_FUZE_SAYISI = 5;

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
                
        public GelismisPictureBox GPCT_Hedef { set; get; }
        public GelismisPictureBox GPCT_Boom { set; get; }

        private Random R = new Random();

        public Oyun(Form form, Timer timer,GelismisPictureBox boom, GelismisPictureBox hedef, GelismisPictureBox duz, GelismisPictureBox ust, GelismisPictureBox alt)
        {
            this.Form = form;
            this.Timer = timer;
            this.GCPT_DUZ = duz;
            this.GPCT_UST = ust;
            this.GPCT_ALT = alt;
            this.GPCT_Hedef = hedef;
            this.GPCT_Boom = boom;
            this.Fuzeler = new Fuze[MAX_FUZE_SAYISI];
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
            this.FuzeSayisi = 0;
            FuzeleriTemizle();
            FuzeEkle(0);
            this.Patlamalar = new List<Patlama>();
            this.Timer.Interval = 100;
            this.Timer.Enabled = true;            
        }
        public void Guncelle()
        {
            FuzeleriGuncelle();
            PatlamalariGuncelle();
        }        
        public void VurulduMu()
        {            
            for (int i = 0; i < Fuzeler.Count(); i++)
            {
                if (Fuzeler[i] != null)
                {
                    if (Fuzeler[i].VurulduMuAcaba())
                    {
                        this.FuzeVuruldu(i);                        
                        if ((this.Skor % 100) == 0)
                        {
                            this.Seviye++;                            
                            if ((this.Seviye % 2) == 0)
                            {
                                YeniFuzeEkle();
                            }
                            else
                            {
                                HizArttir();
                            }
                        }
                        //Vurulan fuzenin yerine ekle
                        FuzeEkle(i);
                    }
                }
            }
        }
        private void FuzeleriGuncelle()
        {
            for (int i = 0; i < Fuzeler.Count(); i++)
            {
                if (Fuzeler[i] != null)
                {
                    Fuzeler[i].Guncelle();
                    if (Fuzeler[i].VurduMu())
                    {
                        FuzeVurdu(i);
                    }
                }
            }
        }
        private void PatlamalariGuncelle()
        {
            List<int> bitenPatlamalar = new List<int>();
            for (int i = 0; i < Patlamalar.Count; i++)
            {
                this.Patlamalar[i].Guncelle();
                if (Patlamalar[i].PatlamaBitti)
                {
                    bitenPatlamalar.Add(i);
                }
            }
            BitmisPatlamalariKaldir(bitenPatlamalar);
        }
        private void BitmisPatlamalariKaldir(List<int> bitenPatlamalar)
        {
            foreach (int i in bitenPatlamalar)
            {
                if (i < this.Patlamalar.Count)
                {
                    this.Patlamalar[i].PictureBox.Dispose();
                    this.Patlamalar.RemoveAt(i);
                }
            }
        }
        private void FuzeVurdu(int index)
        {
            this.CanAzalt();
            int fuzeOnKisimX = Fuzeler[index].PictureBox.Left + Fuzeler[index].PictureBox.Width - 20 - 50;
            int fuzeOnKisimY = Fuzeler[index].PictureBox.Top + Fuzeler[index].PictureBox.Height - (Fuzeler[index].PictureBox.Height / 2);
            this.PatlamaOlustur(fuzeOnKisimX, fuzeOnKisimY,100,100);
            Fuzeler[index].PictureBox.Dispose();
            Fuzeler[index] = null;
            FuzeEkle(index);
        }
        private void FuzeVuruldu(int index)
        {
            this.Skor += 10;
            this.Can++;
            int hedefOrtaX = this.GPCT_Hedef.Left + (this.GPCT_Hedef.Width / 2);
            int hedefOrtaY = this.GPCT_Hedef.Top + (this.GPCT_Hedef.Height / 2);
            this.PatlamaOlustur( hedefOrtaX, hedefOrtaY );
            this.Fuzeler[index].PictureBox.Dispose();
            this.Fuzeler[index] = null;
            this.FuzeSayisi--;

        }
        private void PatlamaOlustur(int x , int y, int width=-1,int height=-1)
        {
            Patlama patlama = new Patlama(this,x, y);
            if (width > -1 && height > -1)
            {
                patlama.PictureBox.Width = width;
                patlama.PictureBox.Height = height;
            }
            this.Form.Controls.Add(patlama.PictureBox);
            patlama.PictureBox.BringToFront();
            this.Patlamalar.Add(patlama);
        }
        private void YeniFuzeEkle()
        {
            if (this.FuzeSayisi < this.MAX_FUZE_SAYISI)
            {
                this.SonrakiIndex++;
                FuzeEkle();
            }
        }
        private void HizArttir()
        {
            if (this.Timer.Interval - 10 == 0)
            {
                this.Timer.Interval = 1;
            }
            else
            {
                this.Timer.Interval -= 10;
            }
        }
        private void FuzeEkle(int index = -1)
        {
            if (FuzeSayisi < this.MAX_FUZE_SAYISI -1 || index > -1)
            {
                Fuze fuze = new Fuze(this);
                fuze.Left = fuze.Width * (-1);
                fuze.UsttenOffset = R.Next(-10, this.Form.Height+10);
                Debug.WriteLine(fuze.UsttenOffset);
                int eklenecekIndex = this.EklenecekIndexHangisi(index);
                this.Fuzeler[eklenecekIndex] = fuze;                
                this.FuzeSayisi++;
                fuze.FormaGir();
            }

        }
        private int EklenecekIndexHangisi(int index)
        {
            int eklenecekIndex = this.SonrakiIndex;
            if (index > -1)
            {
                eklenecekIndex = index;
            }
            else
            {
                eklenecekIndex = this.SonrakiIndex;
            }
            return eklenecekIndex;
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
            for (int i = 0; i < this.MAX_FUZE_SAYISI; i++)
            {
                if (this.Fuzeler[i] != null)
                {
                    this.Fuzeler[i].PictureBox.Dispose();
                }
            }
            this.Fuzeler = new Fuze[5];
        }
    }
}
