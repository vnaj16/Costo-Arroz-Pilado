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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Pilado_Click(object sender, EventArgs e)
        {
            UI_Pilado Pilado = new UI_Pilado();
            Pilado.ShowDialog();
        }

        private void button_Cascara_Click(object sender, EventArgs e)
        {
            UI_Cascara Cascara = new UI_Cascara();
            Cascara.ShowDialog();
        }
    }
}
