using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Reflection;

namespace ExcelConvert
{
    public partial class ExcelConvert : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OleDB.4.0;Data Source=./Data/saydamproje.mdb");
        public ExcelConvert()
        {
            InitializeComponent();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void şablonları_getir()
        {
            OleDbDataAdapter adp = new OleDbDataAdapter("Select * From Sablon",baglanti);
            DataTable da = new DataTable();
            da.Clear();
            adp.Fill(da);

            DG1.DataSource = da;

            TxtŞablon.Items.Clear();
            int son = da.Rows.Count;
            for (int i = 0; i < son; i++)
            {
                TxtŞablon.Items.Add(da.Rows[i][1].ToString());
            }
        }

        private void BtnExcelSeç_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            //file.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası|*.xls";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Excel Dosyası Seçiniz..";
            file.ShowDialog();

            string DosyaYolu = file.FileName;
            string DosyaAdi = file.SafeFileName;
            TxtDosyaYolu.Text = DosyaYolu;
            TxtŞablon.Enabled = true;            
        }

        private void ExcelConvert_Load(object sender, EventArgs e)
        {
            şablonları_getir();
        }

        private void BtnExcelOluştur_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Excel oluşturmak istiyor musunuz?","Excel Oluştur?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                OleDbDataAdapter adp = new OleDbDataAdapter("Select * From Sablon Where SABLON_ADI='" + TxtŞablon.Text + "'", baglanti);
                DataTable da = new DataTable();
                da.Clear();
                adp.Fill(da);
                string EVRAK_TARIHI = da.Rows[0][2].ToString();
                string EVRAK_NO = da.Rows[0][3].ToString();
                string VNO = da.Rows[0][4].ToString();
                string GELIR_ACIKLAMA = da.Rows[0][5].ToString();                
                string HESAPLANAN_KDV = da.Rows[0][6].ToString();
                string TOPLAM = da.Rows[0][7].ToString();


                Excel.Application excel_oku;
                Excel.Workbook kitap_oku;
                Excel.Worksheet sayfa_oku;
                excel_oku = new Excel.Application();

                kitap_oku = excel_oku.Workbooks.Open(TxtDosyaYolu.Text);
                sayfa_oku = (Excel.Worksheet)kitap_oku.Worksheets.get_Item(1);
                int son = sayfa_oku.Range["A" + sayfa_oku.Rows.Count].End[Excel.XlDirection.xlUp].Row;


                //---------------------------------------------------------------------------------------
                Excel.Application excel;
                Excel.Workbook kitap;
                Excel.Worksheet sayfa;
                excel = new Excel.Application();

                kitap = excel.Workbooks.Add();
                sayfa = (Excel.Worksheet)kitap.Worksheets.get_Item(1);
                int say = 1;

                sayfa.Range["A1"].Value = "Evrak Tarihi";
                sayfa.Range["B1"].Value = "Evrak No";
                sayfa.Range["C1"].Value = "Vergi / TC No";
                sayfa.Range["D1"].Value = "Gelir Açıklama";
                sayfa.Range["E1"].Value = "KDV%";
                sayfa.Range["F1"].Value = "Satılan Mal/Hizmet";
                sayfa.Range["G1"].Value = "Hesap.KDV";
                sayfa.Range["H1"].Value = "Toplam";

                sayfa.Range["A1"].ColumnWidth = 19.57;
                sayfa.Range["B1"].ColumnWidth = 17.14;
                sayfa.Range["C1"].ColumnWidth = 15.43;
                sayfa.Range["D1"].ColumnWidth = 45.57;
                sayfa.Range["E1"].ColumnWidth = 10;
                sayfa.Range["F1"].ColumnWidth = 11.43;
                sayfa.Range["G1"].ColumnWidth = 10.71;
                sayfa.Range["H1"].ColumnWidth = 12;
                sayfa.Range["I1"].ColumnWidth = 9;
                sayfa.Range["J1"].ColumnWidth = 9;

                sayfa.Range["A1:H1"].Font.Bold = true;
                sayfa.Range["A1:H1"].HorizontalAlignment = 2;
                sayfa.Range["A1:H1"].VerticalAlignment = 3;

                for (int i = 2; i < son; i++)
                {
                    decimal kdv_tutar = Convert.ToDecimal(sayfa_oku.Range[HESAPLANAN_KDV + i].Value);
                    decimal toplam = Convert.ToDecimal(sayfa_oku.Range[TOPLAM + i].Value);
                    decimal tutar = toplam - kdv_tutar;
                    int kdv = 0;
                    if (kdv_tutar > 0)
                    {
                        kdv = Convert.ToInt16(kdv_tutar / tutar * 100);
                    }

                    string hesap_kodu = "";
                    string kdv_kodu = "";
                    if (kdv == 1)
                    {
                        hesap_kodu = "600 00 01";
                        kdv_kodu = "391 00 01";
                    }
                    else if (kdv == 8)
                    {
                        hesap_kodu = "600 00 08";
                        kdv_kodu = "391 00 08";
                    }
                    else if (kdv == 18)
                    {
                        hesap_kodu = "600 00 18";
                        kdv_kodu = "391 00 18";
                    }
                    else
                    {
                        hesap_kodu = "600 00 00";
                        kdv_kodu = "391 00 00";
                    }

                    string vno = sayfa_oku.Range[VNO + i].Value;
                    if (vno == "11111111111")
                    {
                        vno = "";
                    }

                    DateTime tarih = Convert.ToDateTime(sayfa_oku.Range[EVRAK_TARIHI + i].Value);

                    say++;
                    sayfa.Range["A" + say].Value = tarih.ToShortDateString();
                    sayfa.Range["B" + say].Value = sayfa_oku.Range[EVRAK_NO + i].Value;
                    sayfa.Range["C" + say].Value = vno;
                    sayfa.Range["D" + say].Value = sayfa_oku.Range[GELIR_ACIKLAMA + i].Value;
                    sayfa.Range["E" + say].Value = kdv;
                    sayfa.Range["F" + say].Value = tutar;
                    sayfa.Range["G" + say].Value = kdv_tutar;
                    sayfa.Range["H" + say].Value = toplam;
                    sayfa.Range["I" + say].Value = hesap_kodu;
                    sayfa.Range["J" + say].Value = kdv_kodu;
                }

                kitap_oku.Close(true, Missing.Value, Missing.Value);
                excel.Visible = true;                
            }
            
        }

        private void TxtŞablon_SelectedValueChanged(object sender, EventArgs e)
        {
            if (TxtŞablon.Text != "")
            {
                BtnExcelOluştur.Enabled = true;
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            OleDbCommand kontrol = new OleDbCommand("select * From Sablon where SABLON_ADI = '" + TxtŞablonAdı.Text + "'", baglanti);
            OleDbDataReader dr;
            baglanti.Open();
            dr = kontrol.ExecuteReader();
            if (dr.Read())
            {
                baglanti.Close();
                MessageBox.Show("Bu şablon adı daha önce kaydedilmiş! Lütfen başka isim kullanın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            baglanti.Close();

            if (MessageBox.Show("Şablonu kaydetmek istiyor musunuz?","Şablonu Kaydet",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                OleDbCommand kmt = new OleDbCommand("insert into Sablon(SABLON_ADI,EVRAK_TARIHI,EVRAK_NO,VNO,GELIR_ACIKLAMA,HESAPLANAN_KDV,TOPLAM) values(@SABLON_ADI,@EVRAK_TARIHI,@EVRAK_NO,@VNO,@GELIR_ACIKLAMA,@HESAPLANAN_KDV,@TOPLAM)", baglanti);
                kmt.Parameters.AddWithValue("@SABLON_ADI", TxtŞablonAdı.Text);
                kmt.Parameters.AddWithValue("@EVRAK_TARIHI", TxtEvrakTarihi.Text);
                kmt.Parameters.AddWithValue("@EVRAK_NO", TxtEvrakNo.Text);
                kmt.Parameters.AddWithValue("@VNO", TxtVno.Text);
                kmt.Parameters.AddWithValue("@GELIR_ACIKLAMA", TxtGelirAçıklama.Text);
                kmt.Parameters.AddWithValue("@HESAPLANAN_KDV", TxtHesaplananKDV.Text);
                kmt.Parameters.AddWithValue("@TOPLAM", TxtToplam.Text);
                baglanti.Open();
                kmt.ExecuteNonQuery();
                baglanti.Close();

                TxtŞablonAdı.Text = "";
                TxtEvrakTarihi.Text = "";
                TxtEvrakNo.Text = "";
                TxtVno.Text = "";
                TxtGelirAçıklama.Text = "";
                TxtHesaplananKDV.Text = "";
                TxtToplam.Text = "";
                MessageBox.Show("Şablon başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                şablonları_getir();
            }            
        }

        private void DG1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtŞablonAdı_Leave(object sender, EventArgs e)
        {
            TxtŞablonAdı.Text = TxtŞablonAdı.Text.ToUpper();
        }

        private void TxtEvrakTarihi_Leave(object sender, EventArgs e)
        {
            TxtEvrakTarihi.Text = TxtEvrakTarihi.Text.ToUpper();
        }

        private void TxtEvrakNo_Leave(object sender, EventArgs e)
        {
            TxtEvrakNo.Text = TxtEvrakNo.Text.ToUpper();
        }

        private void TxtVno_Leave(object sender, EventArgs e)
        {
            TxtVno.Text = TxtVno.Text.ToUpper();
        }

        private void TxtGelirAçıklama_Leave(object sender, EventArgs e)
        {
            TxtGelirAçıklama.Text = TxtGelirAçıklama.Text.ToUpper();
        }

        private void TxtHesaplananKDV_Leave(object sender, EventArgs e)
        {
            TxtHesaplananKDV.Text = TxtHesaplananKDV.Text.ToUpper();
        }

        private void TxtToplam_Leave(object sender, EventArgs e)
        {
            TxtToplam.Text = TxtToplam.Text.ToUpper();
        }

        private void DG1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not in our 
            if (e.ColumnIndex == DG1.Columns["Sil"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DG1.Rows[e.RowIndex];
                string sablon_adi = row.Cells["SABLON_ADI"].Value.ToString();
                if (MessageBox.Show(sablon_adi + " şablonunu silmek istiyor musunuz?","Sil?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    OleDbCommand kmt = new OleDbCommand("Delete from Sablon where SABLON_ADI='" + sablon_adi + "'", baglanti);
                    baglanti.Open();
                    kmt.ExecuteNonQuery();
                    baglanti.Close();
                    şablonları_getir();
                }
            }
        }
    }
}
