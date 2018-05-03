using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FuzeSavunmaOyunu.Kutuphane
{
    public class Fuze
    {
        private Pozisyon _pozisyon;
        private double DalgalanmaAdimi = -1;
        private double AtilacakDagalanmaAdimi = 0.1;
        private Oyun Oyun { set; get; }                

        public GelismisPictureBox PictureBox { set; get; }
        public Pozisyon Pozisyon 
        {
            set
            {
                _pozisyon = value;                
                PozisyonDegisti();
            }
            get
            {
                return this._pozisyon;
            }

        }        
        public int Adim { set; get; }
        public int UsttenOffset { set; get; }
        public int Left
        {
            set
            {
                this.PictureBox.Left = value;
            }
            get
            {
                return this.PictureBox.Left;
            }
        }
        public int Top
        {
            set
            {
                this.PictureBox.Top = value;
            }
            get
            {
                return this.PictureBox.Top;
            }
        }
        public int Width
        {
            set
            {
                this.PictureBox.Width = value;
            }
            get
            {
                return this.PictureBox.Width;
            }
        }
        public int Height
        {
            set
            {
                this.PictureBox.Height = value;
            }
            get
            {
                return this.PictureBox.Height;
            }
        }
        public bool VurulduMu { set; get; }

        public void Guncelle()
        {
            Ilerle();            
        }
        public Fuze(Oyun oyun)
        {                                  
            Adim = 10;
            UsttenOffset = 0;
            this.Oyun = oyun;
            GelismisPictureBoxOlustur();
            this.PictureBox.Width = 210;
            this.PictureBox.Height = 130;
            this.VurulduMu = false;
        }
        public void FormaGir()
        {
            this.Oyun.Form.Controls.Add(this.PictureBox);
        }
        public bool VurduMu()
        {
            if ( (this.PictureBox.Left + this.Width -25 ) > ( this.Oyun.Form.Width - 25))
            {
                return true;
            }
            return false;
        }

        private void PozisyonDegisti()
        {
            switch (this.Pozisyon)
            {
                case Pozisyon.Duz:
                    this.PictureBox.Image = this.Oyun.GCPT_DUZ.Image;
                    break;
                case Pozisyon.Alt:
                    this.PictureBox.Image = this.Oyun.GPCT_ALT.Image;
                    break;
                case Pozisyon.Ust:
                    this.PictureBox.Image = this.Oyun.GPCT_UST.Image;
                    break;
            }
        }        
        private void Fuze_Load(object sender, EventArgs e)
        {
            this.Pozisyon = Pozisyon.Duz;            
        }        
        private void Ilerle()
        {
            
            double nextTop = (Math.Round((Math.Cos(DalgalanmaAdimi) * 100), 0));
            int oncekiTop = this.Top;
            this.Top = ( (int)nextTop + (this.Height / 2) - (this.Height / 2) ) + UsttenOffset;            

            this.Left += Adim;
            DalgalanmaAdimi += AtilacakDagalanmaAdimi;
            if (DalgalanmaAdimi == 1)
            {
                AtilacakDagalanmaAdimi *= -1;

            }
            PozisyonDenetle(oncekiTop);
            VurduMu();
 
        }
        private void PozisyonDenetle(int oncekiTop)
        {
            if (oncekiTop > this.Top)
            {
                if (this.Pozisyon != Kutuphane.Pozisyon.Ust)
                {
                    this.Pozisyon = Kutuphane.Pozisyon.Ust;
                }
            }
            else
            {
                if (this.Pozisyon != Kutuphane.Pozisyon.Alt)
                {
                    this.Pozisyon = Kutuphane.Pozisyon.Alt;
                }
            }
        }
        private void GelismisPictureBoxOlustur()
        {
            this.PictureBox = new GelismisPictureBox();
            this.PictureBox.BackColor = this.Oyun.GCPT_DUZ.BackColor;
            this.PictureBox.Image = this.Oyun.GCPT_DUZ.Image;       
        }
        
        public bool VurulduMuAcaba()
        {
            int altKenar = this.Top + this.Height;
            int sagKenar = this.Left + this.Width;

            int hedefSolKenar = this.Oyun.GPCT_Hedef.Left;
            int hedefUstKenar = this.Oyun.GPCT_Hedef.Top;
            int hedefGenislik = this.Oyun.GPCT_Hedef.Width;
            int hedefYukseklik = this.Oyun.GPCT_Hedef.Height;
            int hedefAltKenar = hedefUstKenar +hedefYukseklik;
            int hedefSagKenar = hedefSolKenar +hedefGenislik;

            if ( hedefSolKenar > this.Left  && 
                 hedefUstKenar > this.Top &&
                 hedefSagKenar < sagKenar &&
                 hedefAltKenar < altKenar  )
            {
                VurulduMu = true;
                return true;
            }
            return false;
        }
    }
}
