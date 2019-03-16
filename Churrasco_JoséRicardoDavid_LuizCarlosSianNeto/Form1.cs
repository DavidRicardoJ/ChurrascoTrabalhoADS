using System;
using System.Windows.Forms;

namespace Churrasco_JoséRicardoDavid_LuizCarlosSianNeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Insumos insumos = new Insumos();
        private void Form1_Load(object sender, EventArgs e)
        {
            txtPrecoQueijo.Text = Insumos.precoQueijo.ToString("C");
            txtPrecoPaoAlho.Text = Insumos.precoPaoAlho.ToString("C");
        }

        private void chkCarvao_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCarvao.Checked)
            {
                txtPrecoCarvao.Text = Insumos.precoCarvao.ToString("C");
                txtQuantCarvao.Text = insumos.sacosCarvao().ToString("D");
            } else
            {
                txtQuantCarvao.Text = "0";
            }
        }

       
    }
}
