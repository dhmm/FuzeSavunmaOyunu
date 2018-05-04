namespace FuzeSavunmaOyunu
{
    partial class FormAnaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaForm));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lblSkor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSeviye = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpctBoom = new FuzeSavunmaOyunu.Kutuphane.GelismisPictureBox();
            this.gpctAlt = new FuzeSavunmaOyunu.Kutuphane.GelismisPictureBox();
            this.gpctHedef = new FuzeSavunmaOyunu.Kutuphane.GelismisPictureBox();
            this.gpctSehir = new FuzeSavunmaOyunu.Kutuphane.GelismisPictureBox();
            this.gpctUst = new FuzeSavunmaOyunu.Kutuphane.GelismisPictureBox();
            this.gpctDuz = new FuzeSavunmaOyunu.Kutuphane.GelismisPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gpctBoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpctAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpctHedef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpctSehir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpctUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpctDuz)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "fuze-beyaz-alt.gif");
            this.imageList.Images.SetKeyName(1, "fuze-beyaz-duz.gif");
            this.imageList.Images.SetKeyName(2, "fuze-beyaz-ust.gif");
            // 
            // lblSkor
            // 
            this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblSkor.ForeColor = System.Drawing.Color.Lime;
            this.lblSkor.Location = new System.Drawing.Point(67, 9);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(158, 23);
            this.lblSkor.TabIndex = 4;
            this.lblSkor.Text = "0";
            this.lblSkor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Skor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(231, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seviye";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblSeviye
            // 
            this.lblSeviye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblSeviye.ForeColor = System.Drawing.Color.Lime;
            this.lblSeviye.Location = new System.Drawing.Point(301, 9);
            this.lblSeviye.Name = "lblSeviye";
            this.lblSeviye.Size = new System.Drawing.Size(54, 23);
            this.lblSeviye.TabIndex = 6;
            this.lblSeviye.Text = "0";
            this.lblSeviye.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(407, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Can";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblCan
            // 
            this.lblCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblCan.ForeColor = System.Drawing.Color.Lime;
            this.lblCan.Location = new System.Drawing.Point(477, 9);
            this.lblCan.Name = "lblCan";
            this.lblCan.Size = new System.Drawing.Size(143, 23);
            this.lblCan.TabIndex = 8;
            this.lblCan.Text = "0";
            this.lblCan.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(617, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "(F2)-Yeni , (Pause)-Duraklat";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // gpctBoom
            // 
            this.gpctBoom.BackColor = System.Drawing.Color.Transparent;
            this.gpctBoom.Image = ((System.Drawing.Image)(resources.GetObject("gpctBoom.Image")));
            this.gpctBoom.Location = new System.Drawing.Point(820, 452);
            this.gpctBoom.Name = "gpctBoom";
            this.gpctBoom.Size = new System.Drawing.Size(50, 50);
            this.gpctBoom.TabIndex = 11;
            this.gpctBoom.TabStop = false;
            this.gpctBoom.Visible = false;
            // 
            // gpctAlt
            // 
            this.gpctAlt.BackColor = System.Drawing.Color.Transparent;
            this.gpctAlt.Image = ((System.Drawing.Image)(resources.GetObject("gpctAlt.Image")));
            this.gpctAlt.Location = new System.Drawing.Point(886, 499);
            this.gpctAlt.Name = "gpctAlt";
            this.gpctAlt.Size = new System.Drawing.Size(43, 24);
            this.gpctAlt.TabIndex = 0;
            this.gpctAlt.TabStop = false;
            this.gpctAlt.Visible = false;
            // 
            // gpctHedef
            // 
            this.gpctHedef.BackColor = System.Drawing.Color.Transparent;
            this.gpctHedef.Image = ((System.Drawing.Image)(resources.GetObject("gpctHedef.Image")));
            this.gpctHedef.Location = new System.Drawing.Point(820, 539);
            this.gpctHedef.Name = "gpctHedef";
            this.gpctHedef.Size = new System.Drawing.Size(50, 50);
            this.gpctHedef.TabIndex = 3;
            this.gpctHedef.TabStop = false;
            this.gpctHedef.Click += new System.EventHandler(this.gpctHedef_Click);
            // 
            // gpctSehir
            // 
            this.gpctSehir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpctSehir.Image = ((System.Drawing.Image)(resources.GetObject("gpctSehir.Image")));
            this.gpctSehir.Location = new System.Drawing.Point(942, 0);
            this.gpctSehir.Name = "gpctSehir";
            this.gpctSehir.Size = new System.Drawing.Size(50, 668);
            this.gpctSehir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gpctSehir.TabIndex = 2;
            this.gpctSehir.TabStop = false;
            // 
            // gpctUst
            // 
            this.gpctUst.BackColor = System.Drawing.Color.Transparent;
            this.gpctUst.Image = ((System.Drawing.Image)(resources.GetObject("gpctUst.Image")));
            this.gpctUst.Location = new System.Drawing.Point(886, 569);
            this.gpctUst.Name = "gpctUst";
            this.gpctUst.Size = new System.Drawing.Size(43, 24);
            this.gpctUst.TabIndex = 0;
            this.gpctUst.TabStop = false;
            this.gpctUst.Visible = false;
            // 
            // gpctDuz
            // 
            this.gpctDuz.BackColor = System.Drawing.Color.Transparent;
            this.gpctDuz.Image = ((System.Drawing.Image)(resources.GetObject("gpctDuz.Image")));
            this.gpctDuz.Location = new System.Drawing.Point(886, 539);
            this.gpctDuz.Name = "gpctDuz";
            this.gpctDuz.Size = new System.Drawing.Size(43, 24);
            this.gpctDuz.TabIndex = 0;
            this.gpctDuz.TabStop = false;
            this.gpctDuz.Visible = false;
            // 
            // FormAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 668);
            this.Controls.Add(this.gpctBoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gpctAlt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSeviye);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.gpctHedef);
            this.Controls.Add(this.gpctSehir);
            this.Controls.Add(this.gpctUst);
            this.Controls.Add(this.gpctDuz);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuze Savunma Oyunu v 0.2";
            this.Load += new System.EventHandler(this.FormAnaForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAnaForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gpctBoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpctAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpctHedef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpctSehir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpctUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpctDuz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ImageList imageList;
        private Kutuphane.GelismisPictureBox gpctDuz;
        private Kutuphane.GelismisPictureBox gpctUst;
        private Kutuphane.GelismisPictureBox gpctAlt;
        private Kutuphane.GelismisPictureBox gpctSehir;
        private Kutuphane.GelismisPictureBox gpctHedef;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSeviye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCan;
        private System.Windows.Forms.Label label4;
        private Kutuphane.GelismisPictureBox gpctBoom;
    }
}

