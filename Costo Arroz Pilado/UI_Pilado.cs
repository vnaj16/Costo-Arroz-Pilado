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
    public partial class UI_Pilado : Form
    {
        public UI_Pilado()
        {
            InitializeComponent();
        }

        private void UI_Pilado_Load(object sender, EventArgs e)
        {

        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {

            if (textBox_Arrocillo.Text!="" && textBox_CostoMP.Text!="" && textBox_Descarte.Text!="" &&
                textBox_Envases.Text!="" && textBox_Flete.Text!="" && textBox_Otros.Text!="" &&
                textBox_PAP.Text!="" && textBox_Polvillo.Text!="" &&textBox_ServicioMaquila.Text!="") {
                try
                {
                    decimal CMP = Convert.ToDecimal(textBox_CostoMP.Text);
                    decimal Flete = Convert.ToDecimal(textBox_Flete.Text);
                    decimal Maquila = Convert.ToDecimal(textBox_ServicioMaquila.Text);
                    decimal Envases = Convert.ToDecimal(textBox_Envases.Text);
                    decimal Otros = Convert.ToDecimal(textBox_Otros.Text);
                    decimal Descarte = Convert.ToDecimal(textBox_Descarte.Text);
                    decimal Arrocillo = Convert.ToDecimal(textBox_Arrocillo.Text);
                    decimal Polvillo = Convert.ToDecimal(textBox_Polvillo.Text);
                    decimal PAP = Convert.ToDecimal(textBox_PAP.Text);

                    decimal CAP = ((CMP + Flete + Maquila + Envases + Otros) - (Descarte + Arrocillo + Polvillo)) / PAP;

                    label_CAP.Text = "S/. " + CAP.ToString("N2");
                }
                catch(Exception E)
                {
                    MessageBox.Show(E.Message);
                    MessageBox.Show("Por favor verificar que los datos ingresados esten correctos");
                }
            }
            else
            {
                MessageBox.Show("Complete los campos restantes");
            }

        }

        private void textBox_CostoMP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
