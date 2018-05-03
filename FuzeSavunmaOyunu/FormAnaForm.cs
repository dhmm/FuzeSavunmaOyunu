using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using FuzeSavunmaOyunu.Kutuphane;

namespace FuzeSavunmaOyunu
{
    public partial class FormAnaForm : Form
    {
        Oyun oyun;
        public FormAnaForm()
        {
            InitializeComponent();
            oyun = new Oyun(this, timer,gpctHedef,gpctDuz ,gpctUst,gpctAlt);
            oyun.OyunPanelleriAta(lblCan, lblSkor, lblSeviye);
        }
       
        private void timer_Tick(object sender, EventArgs e)
        {
            oyun.Guncelle();
            gpctHedef.Left = (this.PointToClient(Cursor.Position).X) - (this.gpctHedef.Width / 2);
            gpctHedef.Top = (this.PointToClient(Cursor.Position).Y) - (this.gpctHedef.Height / 2);
        }        
        private void FormAnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    oyun.YeniOyun();
                    break;
                case Keys.Pause:
                    timer.Enabled = !timer.Enabled;
                    break;
            }
        }

        private void FormAnaForm_Load(object sender, EventArgs e)
        {
           
        }

        private void gpctHedef_Click(object sender, EventArgs e)
        {
            this.oyun.VurulduMu();
        }

        
    }
}
