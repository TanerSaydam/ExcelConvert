
namespace ExcelConvert
{
    partial class ExcelConvert
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelConvert));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TxtŞablon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDosyaYolu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtŞablonAdı = new System.Windows.Forms.TextBox();
            this.TxtEvrakTarihi = new System.Windows.Forms.TextBox();
            this.TxtEvrakNo = new System.Windows.Forms.TextBox();
            this.TxtVno = new System.Windows.Forms.TextBox();
            this.TxtGelirAçıklama = new System.Windows.Forms.TextBox();
            this.TxtHesaplananKDV = new System.Windows.Forms.TextBox();
            this.TxtToplam = new System.Windows.Forms.TextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnExcelOluştur = new System.Windows.Forms.Button();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.BtnExcelSeç = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DG1 = new System.Windows.Forms.DataGridView();
            this.Sil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TxtŞablon
            // 
            this.TxtŞablon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtŞablon.Enabled = false;
            this.TxtŞablon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtŞablon.FormattingEnabled = true;
            this.TxtŞablon.Location = new System.Drawing.Point(33, 90);
            this.TxtŞablon.Name = "TxtŞablon";
            this.TxtŞablon.Size = new System.Drawing.Size(191, 23);
            this.TxtŞablon.TabIndex = 2;
            this.TxtŞablon.SelectedValueChanged += new System.EventHandler(this.TxtŞablon_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Şablon";
            // 
            // TxtDosyaYolu
            // 
            this.TxtDosyaYolu.AutoSize = true;
            this.TxtDosyaYolu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDosyaYolu.Location = new System.Drawing.Point(135, 44);
            this.TxtDosyaYolu.Name = "TxtDosyaYolu";
            this.TxtDosyaYolu.Size = new System.Drawing.Size(68, 15);
            this.TxtDosyaYolu.TabIndex = 5;
            this.TxtDosyaYolu.Text = "Dosya Yolu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şablon Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Evrak Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Evrak No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "VNo/TC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(20, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gelir Açıklama";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(20, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Hesaplanan KDV";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(20, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Toplam";
            // 
            // TxtŞablonAdı
            // 
            this.TxtŞablonAdı.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtŞablonAdı.Location = new System.Drawing.Point(128, 32);
            this.TxtŞablonAdı.MaxLength = 1000;
            this.TxtŞablonAdı.Name = "TxtŞablonAdı";
            this.TxtŞablonAdı.Size = new System.Drawing.Size(100, 22);
            this.TxtŞablonAdı.TabIndex = 15;
            this.TxtŞablonAdı.Leave += new System.EventHandler(this.TxtŞablonAdı_Leave);
            // 
            // TxtEvrakTarihi
            // 
            this.TxtEvrakTarihi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEvrakTarihi.Location = new System.Drawing.Point(128, 58);
            this.TxtEvrakTarihi.MaxLength = 1;
            this.TxtEvrakTarihi.Name = "TxtEvrakTarihi";
            this.TxtEvrakTarihi.Size = new System.Drawing.Size(100, 22);
            this.TxtEvrakTarihi.TabIndex = 16;
            this.TxtEvrakTarihi.Leave += new System.EventHandler(this.TxtEvrakTarihi_Leave);
            // 
            // TxtEvrakNo
            // 
            this.TxtEvrakNo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEvrakNo.Location = new System.Drawing.Point(128, 84);
            this.TxtEvrakNo.MaxLength = 1;
            this.TxtEvrakNo.Name = "TxtEvrakNo";
            this.TxtEvrakNo.Size = new System.Drawing.Size(100, 22);
            this.TxtEvrakNo.TabIndex = 17;
            this.TxtEvrakNo.Leave += new System.EventHandler(this.TxtEvrakNo_Leave);
            // 
            // TxtVno
            // 
            this.TxtVno.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtVno.Location = new System.Drawing.Point(128, 110);
            this.TxtVno.MaxLength = 1;
            this.TxtVno.Name = "TxtVno";
            this.TxtVno.Size = new System.Drawing.Size(100, 22);
            this.TxtVno.TabIndex = 18;
            this.TxtVno.Leave += new System.EventHandler(this.TxtVno_Leave);
            // 
            // TxtGelirAçıklama
            // 
            this.TxtGelirAçıklama.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtGelirAçıklama.Location = new System.Drawing.Point(128, 136);
            this.TxtGelirAçıklama.MaxLength = 1;
            this.TxtGelirAçıklama.Name = "TxtGelirAçıklama";
            this.TxtGelirAçıklama.Size = new System.Drawing.Size(100, 22);
            this.TxtGelirAçıklama.TabIndex = 19;
            this.TxtGelirAçıklama.Leave += new System.EventHandler(this.TxtGelirAçıklama_Leave);
            // 
            // TxtHesaplananKDV
            // 
            this.TxtHesaplananKDV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtHesaplananKDV.Location = new System.Drawing.Point(128, 162);
            this.TxtHesaplananKDV.MaxLength = 1;
            this.TxtHesaplananKDV.Name = "TxtHesaplananKDV";
            this.TxtHesaplananKDV.Size = new System.Drawing.Size(100, 22);
            this.TxtHesaplananKDV.TabIndex = 22;
            this.TxtHesaplananKDV.Leave += new System.EventHandler(this.TxtHesaplananKDV_Leave);
            // 
            // TxtToplam
            // 
            this.TxtToplam.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtToplam.Location = new System.Drawing.Point(128, 188);
            this.TxtToplam.MaxLength = 1;
            this.TxtToplam.Name = "TxtToplam";
            this.TxtToplam.Size = new System.Drawing.Size(100, 22);
            this.TxtToplam.TabIndex = 23;
            this.TxtToplam.Leave += new System.EventHandler(this.TxtToplam_Leave);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Image = global::ExcelConvert.Properties.Resources.netsis;
            this.BtnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKaydet.Location = new System.Drawing.Point(254, 30);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(97, 44);
            this.BtnKaydet.TabIndex = 24;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnExcelOluştur
            // 
            this.BtnExcelOluştur.Enabled = false;
            this.BtnExcelOluştur.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnExcelOluştur.Image = global::ExcelConvert.Properties.Resources.kaydet_excel_2;
            this.BtnExcelOluştur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcelOluştur.Location = new System.Drawing.Point(33, 129);
            this.BtnExcelOluştur.Name = "BtnExcelOluştur";
            this.BtnExcelOluştur.Size = new System.Drawing.Size(119, 31);
            this.BtnExcelOluştur.TabIndex = 4;
            this.BtnExcelOluştur.Text = "Excel Oluştur";
            this.BtnExcelOluştur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcelOluştur.UseVisualStyleBackColor = true;
            this.BtnExcelOluştur.Click += new System.EventHandler(this.BtnExcelOluştur_Click);
            // 
            // BtnKapat
            // 
            this.BtnKapat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKapat.Image = global::ExcelConvert.Properties.Resources.kapat_24_24;
            this.BtnKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKapat.Location = new System.Drawing.Point(347, 27);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(84, 32);
            this.BtnKapat.TabIndex = 1;
            this.BtnKapat.Text = "Kapat";
            this.BtnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnKapat.UseVisualStyleBackColor = true;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnExcelSeç
            // 
            this.BtnExcelSeç.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnExcelSeç.Image = global::ExcelConvert.Properties.Resources.kaydet_excel;
            this.BtnExcelSeç.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcelSeç.Location = new System.Drawing.Point(33, 27);
            this.BtnExcelSeç.Name = "BtnExcelSeç";
            this.BtnExcelSeç.Size = new System.Drawing.Size(96, 32);
            this.BtnExcelSeç.TabIndex = 0;
            this.BtnExcelSeç.Text = "Excel Seç";
            this.BtnExcelSeç.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcelSeç.UseVisualStyleBackColor = true;
            this.BtnExcelSeç.Click += new System.EventHandler(this.BtnExcelSeç_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.TxtToplam);
            this.groupBox1.Controls.Add(this.TxtHesaplananKDV);
            this.groupBox1.Controls.Add(this.TxtGelirAçıklama);
            this.groupBox1.Controls.Add(this.TxtVno);
            this.groupBox1.Controls.Add(this.TxtEvrakNo);
            this.groupBox1.Controls.Add(this.TxtEvrakTarihi);
            this.groupBox1.Controls.Add(this.TxtŞablonAdı);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 230);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // DG1
            // 
            this.DG1.AllowUserToAddRows = false;
            this.DG1.AllowUserToDeleteRows = false;
            this.DG1.AllowUserToResizeRows = false;
            this.DG1.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sil});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DG1.GridColor = System.Drawing.Color.CadetBlue;
            this.DG1.Location = new System.Drawing.Point(507, 27);
            this.DG1.Name = "DG1";
            this.DG1.RowHeadersVisible = false;
            this.DG1.Size = new System.Drawing.Size(563, 375);
            this.DG1.TabIndex = 26;
            this.DG1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG1_CellClick);
            this.DG1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG1_CellContentClick);
            // 
            // Sil
            // 
            this.Sil.HeaderText = "Sil";
            this.Sil.Name = "Sil";
            this.Sil.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Sil.Text = "Sil";
            this.Sil.UseColumnTextForButtonValue = true;
            // 
            // ExcelConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 425);
            this.Controls.Add(this.DG1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtDosyaYolu);
            this.Controls.Add(this.BtnExcelOluştur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtŞablon);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnExcelSeç);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExcelConvert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Convert Formu";
            this.Load += new System.EventHandler(this.ExcelConvert_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnExcelSeç;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.ComboBox TxtŞablon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExcelOluştur;
        private System.Windows.Forms.Label TxtDosyaYolu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtŞablonAdı;
        private System.Windows.Forms.TextBox TxtEvrakTarihi;
        private System.Windows.Forms.TextBox TxtEvrakNo;
        private System.Windows.Forms.TextBox TxtVno;
        private System.Windows.Forms.TextBox TxtGelirAçıklama;
        private System.Windows.Forms.TextBox TxtHesaplananKDV;
        private System.Windows.Forms.TextBox TxtToplam;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DG1;
        private System.Windows.Forms.DataGridViewButtonColumn Sil;
    }
}

