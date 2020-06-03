namespace StokTakipOtomasyonu
{
	partial class StokGuncelle
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
            this.txtUrunKodu = new System.Windows.Forms.MaskedTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.markalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokTakipOtomasyonuDataSet111 = new StokTakipOtomasyonu.StokTakipOtomasyonuDataSet11();
            this.txtAlisFiyat = new System.Windows.Forms.TextBox();
            this.numericStokAdeti = new System.Windows.Forms.NumericUpDown();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stokTakipOtomasyonuDataSet121 = new StokTakipOtomasyonu.StokTakipOtomasyonuDataSet12();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSatisFiyat = new System.Windows.Forms.TextBox();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.markalarTableAdapter1 = new StokTakipOtomasyonu.StokTakipOtomasyonuDataSet11TableAdapters.MarkalarTableAdapter();
            this.kategorilerTableAdapter1 = new StokTakipOtomasyonu.StokTakipOtomasyonuDataSet12TableAdapters.KategorilerTableAdapter();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.markalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet111)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStokAdeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet121)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunKodu.Location = new System.Drawing.Point(164, 211);
            this.txtUrunKodu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(398, 31);
            this.txtUrunKodu.TabIndex = 51;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(26, 213);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(116, 28);
            this.labelControl8.TabIndex = 50;
            this.labelControl8.Text = "Ürün Kodu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 42);
            this.label1.TabIndex = 49;
            this.label1.Text = "Stok Güncelleme Paneli";
            // 
            // cmbMarka
            // 
            this.cmbMarka.DataSource = this.markalarBindingSource;
            this.cmbMarka.DisplayMember = "MarkaAdi";
            this.cmbMarka.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(164, 279);
            this.cmbMarka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(398, 34);
            this.cmbMarka.TabIndex = 47;
            this.cmbMarka.ValueMember = "MarkaAdi";
            // 
            // markalarBindingSource
            // 
            this.markalarBindingSource.DataMember = "Markalar";
            this.markalarBindingSource.DataSource = this.stokTakipOtomasyonuDataSet111;
            // 
            // stokTakipOtomasyonuDataSet111
            // 
            this.stokTakipOtomasyonuDataSet111.DataSetName = "StokTakipOtomasyonuDataSet11";
            this.stokTakipOtomasyonuDataSet111.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtAlisFiyat
            // 
            this.txtAlisFiyat.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlisFiyat.Location = new System.Drawing.Point(164, 593);
            this.txtAlisFiyat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAlisFiyat.Multiline = true;
            this.txtAlisFiyat.Name = "txtAlisFiyat";
            this.txtAlisFiyat.Size = new System.Drawing.Size(398, 46);
            this.txtAlisFiyat.TabIndex = 46;
            // 
            // numericStokAdeti
            // 
            this.numericStokAdeti.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericStokAdeti.Location = new System.Drawing.Point(164, 439);
            this.numericStokAdeti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericStokAdeti.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericStokAdeti.Name = "numericStokAdeti";
            this.numericStokAdeti.Size = new System.Drawing.Size(400, 31);
            this.numericStokAdeti.TabIndex = 45;
            // 
            // cmbKategori
            // 
            this.cmbKategori.DataSource = this.bindingSource1;
            this.cmbKategori.DisplayMember = "KategoriAdi";
            this.cmbKategori.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.ItemHeight = 26;
            this.cmbKategori.Location = new System.Drawing.Point(164, 516);
            this.cmbKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(398, 34);
            this.cmbKategori.TabIndex = 44;
            this.cmbKategori.ValueMember = "KategoriAdi";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Kategoriler";
            this.bindingSource1.DataSource = this.stokTakipOtomasyonuDataSet121;
            // 
            // stokTakipOtomasyonuDataSet121
            // 
            this.stokTakipOtomasyonuDataSet121.DataSetName = "StokTakipOtomasyonuDataSet12";
            this.stokTakipOtomasyonuDataSet121.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(30, 601);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(110, 28);
            this.labelControl4.TabIndex = 43;
            this.labelControl4.Text = "Alış Fiyatı:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(30, 521);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(95, 28);
            this.labelControl5.TabIndex = 42;
            this.labelControl5.Text = "Kategori:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(30, 442);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(115, 28);
            this.labelControl2.TabIndex = 41;
            this.labelControl2.Text = "Stok Adeti:";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModel.Location = new System.Drawing.Point(164, 361);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModel.Multiline = true;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(398, 39);
            this.txtModel.TabIndex = 40;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(26, 368);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(110, 28);
            this.labelControl3.TabIndex = 39;
            this.labelControl3.Text = "Model Adı:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(26, 284);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(110, 28);
            this.labelControl7.TabIndex = 38;
            this.labelControl7.Text = "Marka Adı:";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(164, 139);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUrunAdi.Multiline = true;
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(398, 39);
            this.txtUrunAdi.TabIndex = 37;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 147);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 28);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Ürün Adı:";
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisFiyat.Location = new System.Drawing.Point(164, 664);
            this.txtSatisFiyat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSatisFiyat.Multiline = true;
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(398, 46);
            this.txtSatisFiyat.TabIndex = 57;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Location = new System.Drawing.Point(360, 744);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(206, 82);
            this.btnKaydet.TabIndex = 56;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(30, 674);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(121, 28);
            this.labelControl6.TabIndex = 55;
            this.labelControl6.Text = "Satış Fiyatı:";
            // 
            // markalarTableAdapter1
            // 
            this.markalarTableAdapter1.ClearBeforeFill = true;
            // 
            // kategorilerTableAdapter1
            // 
            this.kategorilerTableAdapter1.ClearBeforeFill = true;
            // 
            // txtUrunId
            // 
            this.txtUrunId.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunId.Location = new System.Drawing.Point(164, 72);
            this.txtUrunId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUrunId.Multiline = true;
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(398, 39);
            this.txtUrunId.TabIndex = 60;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(26, 80);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(85, 28);
            this.labelControl11.TabIndex = 59;
            this.labelControl11.Text = "Ürün ID:";
            // 
            // StokGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(588, 829);
            this.Controls.Add(this.txtUrunId);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtSatisFiyat);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtUrunKodu);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.txtAlisFiyat);
            this.Controls.Add(this.numericStokAdeti);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StokGuncelle";
            this.Text = "StokGuncelle";
            this.Load += new System.EventHandler(this.StokGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.markalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet111)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStokAdeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet121)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.MaskedTextBox txtUrunKodu;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.TextBox txtAlisFiyat;
        private System.Windows.Forms.NumericUpDown numericStokAdeti;
        private System.Windows.Forms.ComboBox cmbKategori;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtModel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtSatisFiyat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private StokTakipOtomasyonuDataSet11 stokTakipOtomasyonuDataSet111;
        private StokTakipOtomasyonuDataSet12 stokTakipOtomasyonuDataSet121;
        private StokTakipOtomasyonuDataSet11TableAdapters.MarkalarTableAdapter markalarTableAdapter1;
        private StokTakipOtomasyonuDataSet12TableAdapters.KategorilerTableAdapter kategorilerTableAdapter1;
        private System.Windows.Forms.BindingSource markalarBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtUrunId;
        private DevExpress.XtraEditors.LabelControl labelControl11;
    }
}