using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using WinsowsApp;
using ZH_QYZ7R7.Models;

namespace ZH_QYZ7R7
{
    public partial class Form1 : Form
    {
        Excel.Application xlApp; 
        Excel.Workbook xlWB;    
        Excel.Worksheet xlSheet; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("T�nyleg ki szeretne l�pni?", "Kil�p�s", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exit != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void buttonReceptek_Click(object sender, EventArgs e)
        {
            Form formReceptek = new FormReceptek();
            formReceptek.ShowDialog();
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            CreateExcel();
        }

        void CreateTable()
        {
            string[] fejl�cek = new string[] {
            "Nyersanyag",
            "Mennyis�gi egys�g",
            "Egys�g�r"};

            for (int i = 0; i < fejl�cek.Length; i++)
            {
                xlSheet.Cells[1, i + 1] = fejl�cek[i];
            }


            receptContext receptContext = new receptContext();
            var mindenNyersayag = receptContext.Nyersanyagok.ToList();

            object[,] adatT�mb = new object[mindenNyersayag.Count(), fejl�cek.Count()];

            for (int i = 0; i < mindenNyersayag.Count(); i++)
            {
                adatT�mb[i, 0] = mindenNyersayag[i].NyersanyagNev;
                adatT�mb[i, 1] = mindenNyersayag[i].MennyisegiEgysegId;
                adatT�mb[i, 2] = mindenNyersayag[i].Egysegar;
            }


            int sorokSz�ma = adatT�mb.GetLength(0);
            int oszlopokSz�ma = adatT�mb.GetLength(1);

            Excel.Range adatRange = xlSheet.get_Range("A2", Type.Missing).get_Resize(sorokSz�ma, oszlopokSz�ma);
            adatRange.Value2 = adatT�mb;

            adatRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            Excel.Range fejll�cRange = xlSheet.get_Range("A1", Type.Missing).get_Resize(1, fejl�cek.Length);
            fejll�cRange.Font.Bold = true;
            fejll�cRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            fejll�cRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            fejll�cRange.EntireColumn.AutoFit();
            fejll�cRange.RowHeight = 40;
            fejll�cRange.Interior.Color = Color.LightBlue;
            fejll�cRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

        }

        private void CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application();

                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;
                CreateTable();

                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex) 
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }
    }
}