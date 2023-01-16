namespace Hüseyin_Proje
{
    partial class İlanlarım
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İlanlarım));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.button1 = new System.Windows.Forms.Button();
            this.pict_amblem2 = new System.Windows.Forms.PictureBox();
            this.comboBox_ilanTipi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.listilanlar = new System.Windows.Forms.ListView();
            this.İlanid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Seri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Açıklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilan = new System.Windows.Forms.GroupBox();
            this.label_saticiAdi = new System.Windows.Forms.Label();
            this.lbl_saticiId = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pict_amblem2)).BeginInit();
            this.ilan.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // comboBox_ilanTipi
            // 
            this.comboBox_ilanTipi.FormattingEnabled = true;
            this.comboBox_ilanTipi.Items.AddRange(new object[] {
            "Otomobil",
            "Motosiklet"});
            this.comboBox_ilanTipi.Location = new System.Drawing.Point(88, 118);
            this.comboBox_ilanTipi.Name = "comboBox_ilanTipi";
            this.comboBox_ilanTipi.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ilanTipi.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "İlan Tipi Seç :";
            // 
            // btn_Listele
            // 
            this.btn_Listele.Location = new System.Drawing.Point(230, 116);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(75, 23);
            this.btn_Listele.TabIndex = 11;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
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
            this.Açıklama});
            this.listilanlar.Cursor = System.Windows.Forms.Cursors.Default;
            this.listilanlar.FullRowSelect = true;
            this.listilanlar.GridLines = true;
            this.listilanlar.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listilanlar.HideSelection = false;
            this.listilanlar.HoverSelection = true;
            this.listilanlar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listilanlar.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listilanlar.Location = new System.Drawing.Point(11, 182);
            this.listilanlar.MultiSelect = false;
            this.listilanlar.Name = "listilanlar";
            this.listilanlar.Size = new System.Drawing.Size(594, 205);
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
            this.Marka.Width = 79;
            // 
            // Seri
            // 
            this.Seri.Text = "Seri";
            this.Seri.Width = 72;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 87;
            // 
            // Fiyat
            // 
            this.Fiyat.Text = "Fiyat";
            this.Fiyat.Width = 68;
            // 
            // Açıklama
            // 
            this.Açıklama.Text = "Açıklama";
            this.Açıklama.Width = 359;
            // 
            // ilan
            // 
            this.ilan.Controls.Add(this.button2);
            this.ilan.Controls.Add(this.pict_amblem2);
            this.ilan.Controls.Add(this.label_saticiAdi);
            this.ilan.Controls.Add(this.lbl_saticiId);
            this.ilan.Controls.Add(this.listilanlar);
            this.ilan.Controls.Add(this.btn_Listele);
            this.ilan.Controls.Add(this.label1);
            this.ilan.Controls.Add(this.comboBox_ilanTipi);
            this.ilan.Location = new System.Drawing.Point(1, 1);
            this.ilan.Name = "ilan";
            this.ilan.Size = new System.Drawing.Size(622, 399);
            this.ilan.TabIndex = 14;
            this.ilan.TabStop = false;
            this.ilan.Text = "İlanlarm";
            // 
            // label_saticiAdi
            // 
            this.label_saticiAdi.AutoSize = true;
            this.label_saticiAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_saticiAdi.Location = new System.Drawing.Point(366, 16);
            this.label_saticiAdi.Name = "label_saticiAdi";
            this.label_saticiAdi.Size = new System.Drawing.Size(73, 16);
            this.label_saticiAdi.TabIndex = 5;
            this.label_saticiAdi.Text = "Satıcı Adı";
            // 
            // lbl_saticiId
            // 
            this.lbl_saticiId.AutoSize = true;
            this.lbl_saticiId.Location = new System.Drawing.Point(27, 45);
            this.lbl_saticiId.Name = "lbl_saticiId";
            this.lbl_saticiId.Size = new System.Drawing.Size(35, 13);
            this.lbl_saticiId.TabIndex = 12;
            this.lbl_saticiId.Text = "label2";
            this.lbl_saticiId.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Ana Sayfa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // İlanlarım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 400);
            this.Controls.Add(this.ilan);
            this.Controls.Add(this.button1);
            this.Name = "İlanlarım";
            this.Text = "İlanlarım";
            this.Load += new System.EventHandler(this.İlanlarım_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pict_amblem2)).EndInit();
            this.ilan.ResumeLayout(false);
            this.ilan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pict_amblem2;
        private System.Windows.Forms.ComboBox comboBox_ilanTipi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.ColumnHeader Marka;
        private System.Windows.Forms.ColumnHeader Seri;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Fiyat;
        private System.Windows.Forms.ListView listilanlar;
        internal System.Windows.Forms.ColumnHeader İlanid;
        private System.Windows.Forms.ColumnHeader Açıklama;
        private System.Windows.Forms.GroupBox ilan;
        private System.Windows.Forms.Label label_saticiAdi;
        private System.Windows.Forms.Label lbl_saticiId;
        private System.Windows.Forms.Button button2;
    }
}