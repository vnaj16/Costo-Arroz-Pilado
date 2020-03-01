using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costo_Arroz_Pilado
{
    public partial class UI_Cascara : Form
    {
        public UI_Cascara()
        {
            InitializeComponent();
        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {
            if (textBox_Flete.Text != "" && textBox_PM.Text != "" && textBox_Rkg.Text != ""
                && textBox_Subproducto.Text != "")
            {
                try
                {
                    decimal PMP = Convert.ToDecimal(textBox_PM.Text);
                    decimal Flete = Convert.ToDecimal(textBox_Flete.Text);
                    decimal Subproducto = Convert.ToDecimal(textBox_Subproducto.Text);
                    decimal Rkg = (Convert.ToDecimal(textBox_Rkg.Text)) / 100;

                    decimal CAC = ((PMP + Flete) - (Subproducto)) / Rkg;

                    label_CAC.Text = "S/. " + CAC.ToString("N2");
                }
                catch(Exception E) { MessageBox.Show(E.Message); MessageBox.Show("Por favor verificar que los datos ingresados esten correctos"); }
            }
            else
            {
                MessageBox.Show("Complete los campos restantes");
            }

        }
    }
}
