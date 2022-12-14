using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH_QYZ7R7.Models;

namespace WinsowsApp
{
    public partial class UCUjFogas : UserControl
    {
        receptContext receptContext = new receptContext();
        public UCUjFogas()
        {
            InitializeComponent();
        }

        private void buttonHozzaadas_Click_1(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Fogasok f = new Fogasok();

                f.FogasNev = textBoxFogasNev.Text;
                f.Leiras = textBoxLeiras.Text;

                receptContext.Fogasok.Add(f);
                receptContext.SaveChanges();


                DialogResult exit = MessageBox.Show("Szeretnéd most megadni a fogáshoz tartozó receptet?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (exit == DialogResult.Yes)
                {
                    Form formUjRecept = new FormUjRecept();
                    formUjRecept.ShowDialog();
                }

            }


        }



        //Ellenörzéshez kötött adatfelvétel
        bool checkUres(string s)
        {
            return !string.IsNullOrEmpty(s);
        }
        private void textBoxFogasNev_Validating_1(object sender, CancelEventArgs e)
        {
            if (!checkUres(textBoxFogasNev.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxFogasNev, "Ez a mező nem lehet üres!");
            }
        }
 


        private void textBoxFogasNev_Validated_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxFogasNev, "");
        }
    }
}
