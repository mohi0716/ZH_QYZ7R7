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
            DialogResult exit = MessageBox.Show("Tényleg ki szeretne lépni?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
            string[] fejlécek = new string[] {
            "Nyersanyag",
            "Mennyiségi egység",
            "Egységár"};

            for (int i = 0; i < fejlécek.Length; i++)
            {
                xlSheet.Cells[1, i + 1] = fejlécek[i];
            }


            receptContext receptContext = new receptContext();
            var mindenNyersayag = receptContext.Nyersanyagok.ToList();

            object[,] adatTömb = new object[mindenNyersayag.Count(), fejlécek.Count()];

            for (int i = 0; i < mindenNyersayag.Count(); i++)
            {
                adatTömb[i, 0] = mindenNyersayag[i].NyersanyagNev;
                adatTömb[i, 1] = mindenNyersayag[i].MennyisegiEgysegId;
                adatTömb[i, 2] = mindenNyersayag[i].Egysegar;
            }


            int sorokSzáma = adatTömb.GetLength(0);
            int oszlopokSzáma = adatTömb.GetLength(1);

            Excel.Range adatRange = xlSheet.get_Range("A2", Type.Missing).get_Resize(sorokSzáma, oszlopokSzáma);
            adatRange.Value2 = adatTömb;

            adatRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            Excel.Range fejllécRange = xlSheet.get_Range("A1", Type.Missing).get_Resize(1, fejlécek.Length);
            fejllécRange.Font.Bold = true;
            fejllécRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            fejllécRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            fejllécRange.EntireColumn.AutoFit();
            fejllécRange.RowHeight = 40;
            fejllécRange.Interior.Color = Color.LightBlue;
            fejllécRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

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