using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuzeSavunmaOyunu.Kutuphane
{
    public class Patlama
    {
        private Oyun Oyun { set; get; }  
        public GelismisPictureBox PictureBox { set; get; }
        public int PatlamaSuresi = 10;
        public bool PatlamaBitti = false;
        public Patlama(Oyun oyun,int x, int y)
        {
            this.Oyun = oyun;
            GelismisPictureBoxOlustur(x, y);            
        }
        public void Guncelle()
        {
            PatlamaSuresi--;
            if (PatlamaSuresi <= 0)
            {
                this.PatlamaBitti = true;
            }
        }
        private void GelismisPictureBoxOlustur(int x, int y)
        {
            this.PictureBox = new GelismisPictureBox();
            this.PictureBox.BackColor = this.Oyun.GPCT_Boom.BackColor;
            this.PictureBox.Image = this.Oyun.GPCT_Boom.Image;
            this.PictureBox.Left = x  - (this.PictureBox.Image.Width / 2);
            this.PictureBox.Top = y - (this.PictureBox.Image.Height / 2);
        }
    }
}
