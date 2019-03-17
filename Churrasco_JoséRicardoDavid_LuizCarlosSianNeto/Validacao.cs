using System.Windows.Forms;

namespace Principal
{
    class Validacao
    {
        public bool validaValor(string valorTextBox)
        {
            try
            {
                double valor = double.Parse(valorTextBox);
                return true;
            }
            catch
            {
                MessageBox.Show("Valor inválido, verifique a digitação", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
