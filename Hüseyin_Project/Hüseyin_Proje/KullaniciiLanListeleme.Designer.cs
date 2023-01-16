namespace Hüseyin_Proje
{
    partial class KullaniciiLanListeleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciiLanListeleme));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.ilan = new System.Windows.Forms.GroupBox();
            this.pict_amblem2 = new System.Windows.Forms.PictureBox();
            this.listilanlar = new System.Windows.Forms.ListView();
            this.İlanid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Seri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Listele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_ilanTipi = new System.Windows.Forms.ComboBox();
            this.Sehir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_geri = new System.Windows.Forms.Button();
            this.ilan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_amblem2)).BeginInit();
            this.SuspendLayout();
            // 
            // ilan
            // 
            this.ilan.Controls.Add(this.btn_geri);
            this.ilan.Controls.Add(this.pict_amblem2);
            this.ilan.Controls.Add(this.listilanlar);
            this.ilan.Controls.Add(this.btn_Listele);
            this.ilan.Controls.Add(this.label1);
            this.ilan.Controls.Add(this.comboBox_ilanTipi);
            this.ilan.Location = new System.Drawing.Point(-1, 1);
            this.ilan.Name = "ilan";
            this.ilan.Size = new System.Drawing.Size(622, 399);
            this.ilan.TabIndex = 15;
            this.ilan.TabStop = false;
            this.ilan.Text = "İlanlar";
            // 
            // pict_amblem2
            // 
            this.pict_amblem2.Image = ((System.Drawing.Image)(resources.GetObject("pict_amblem2.Image")));
            this.pict_amblem2.Location = new System.Drawing.Point(498, 0);
            this.pict_amblem2.Name = "pict_amblem2";
            this.pict_amblem2.Size = new System.Drawing.Size(124, 96);
            this.pict_amblem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_amblem2.TabIndex = 7;
            this.pict_amblem2.TabStop = false;
            // 
            // listilanlar
            // 
            this.listilanlar.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listilanlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.İlanid,
            this.Marka,
            this.Seri,
            this.Model,
            this.Fiyat,
            this.Sehir,
            this.Aciklama});
            this.listilanlar.Cursor = System.Windows.Forms.Cursors.Default;
            this.listilanlar.FullRowSelect = true;
            this.listilanlar.GridLines = true;
            this.listilanlar.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listilanlar.HideSelection = false;
            this.listilanlar.HoverSelection = true;
            this.listilanlar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listilanlar.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listilanlar.Location = new System.Drawing.Point(6, 107);
            this.listilanlar.MultiSelect = false;
            this.listilanlar.Name = "listilanlar";
            this.listilanlar.Size = new System.Drawing.Size(610, 256);
            this.listilanlar.TabIndex = 13;
            this.listilanlar.UseCompatibleStateImageBehavior = false;
            this.listilanlar.View = System.Windows.Forms.View.Details;
            this.listilanlar.DoubleClick += new System.EventHandler(this.listilanlar_DoubleClick);
            // 
            // İlanid
            // 
            this.İlanid.Text = "İlan İD";
            this.İlanid.Width = 55;
            // 
            // Marka
            // 
            this.Marka.Text = "Marka";
            this.Marka.Width = 68;
            // 
            // Seri
            // 
            this.Seri.Text = "Seri";
            this.Seri.Width = 65;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 72;
            // 
            // Fiyat
            // 
            this.Fiyat.Text = "Fiyat";
            this.Fiyat.Width = 68;
            // 
            // btn_Listele
            // 
            this.btn_Listele.Location = new System.Drawing.Point(233, 78);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(75, 23);
            this.btn_Listele.TabIndex = 11;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "İlan Tipi Seç :";
            // 
            // comboBox_ilanTipi
            // 
            this.comboBox_ilanTipi.FormattingEnabled = true;
            this.comboBox_ilanTipi.Items.AddRange(new object[] {
            "Otomobil",
            "Motosiklet"});
            this.comboBox_ilanTipi.Location = new System.Drawing.Point(91, 80);
            this.comboBox_ilanTipi.Name = "comboBox_ilanTipi";
            this.comboBox_ilanTipi.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ilanTipi.TabIndex = 9;
            // 
            // Sehir
            // 
            this.Sehir.Text = "Sehir";
            // 
            // Aciklama
            // 
            this.Aciklama.Text = "Aciklama";
            this.Aciklama.Width = 221;
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(535, 370);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(75, 23);
            this.btn_geri.TabIndex = 14;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // KullaniciiLanListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 400);
            this.Controls.Add(this.ilan);
            this.Name = "KullaniciiLanListeleme";
            this.Text = "KullaniciiLanListeleme";
            this.Load += new System.EventHandler(this.KullaniciiLanListeleme_Load);
            this.ilan.ResumeLayout(false);
            this.ilan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_amblem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ilan;
        private System.Windows.Forms.PictureBox pict_amblem2;
        private System.Windows.Forms.ListView listilanlar;
        internal System.Windows.Forms.ColumnHeader İlanid;
        private System.Windows.Forms.ColumnHeader Marka;
        private System.Windows.Forms.ColumnHeader Seri;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Fiyat;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ilanTipi;
        private System.Windows.Forms.ColumnHeader Sehir;
        private System.Windows.Forms.ColumnHeader Aciklama;
        private System.Windows.Forms.Button btn_geri;
    }
}