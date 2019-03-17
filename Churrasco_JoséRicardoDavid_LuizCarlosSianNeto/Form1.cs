using System;
using System.Drawing;
using System.Windows.Forms;

namespace Principal
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Declaração Variaveis
        int erro; //variavel que verifica se houve erros.
        double kgCarne, precoCarne, kgFrango, precoFrango, kgLinguica, precoLinguica;
        int quantCerveja, quantRefri;
        double precoCerveja, precoRefri;
        int quantQueijo, quantPaoAlho, quantCarvao;
        int quantPessoas;

        #endregion


        Insumos insumos = new Insumos();
        Validacao validacao = new Validacao();
        private void Form1_Load(object sender, EventArgs e)
        {
            txtPrecoQueijo.Text = Insumos.precoQueijo.ToString("C");
            txtPrecoPaoAlho.Text = Insumos.precoPaoAlho.ToString("C");
            txtPrecoCarvao.Text = Insumos.precoCarvao.ToString("C");
        }

        private void chkCarvao_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCarvao.Checked)
            {

                txtQuantCarvao.Text = insumos.sacosCarvao().ToString("D");
            }
            else
            {
                txtQuantCarvao.Text = "0";
            }
        }

        private void chkQueijo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkQueijo.Checked)
            {
                cbQuantQueijo.Enabled = true;
            }
            else
            {
                cbQuantQueijo.Enabled = false;
                cbQuantQueijo.SelectedIndex = -1;
            }
        }

        private void chkPaoAlho_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPaoAlho.Checked)
            {
                cbQuantPaoAlho.Enabled = true;
            }
            else
            {
                cbQuantPaoAlho.Enabled = false;
                cbQuantPaoAlho.SelectedIndex = -1;
            }
        }

        private void rbClientes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClientes.Checked)
            {
                lbTotal.Text = "Valor por cliente:";
                txtQuantAdulto.Text = String.Empty;
            }
            else
            {
                lbTotal.Text = "Total:";
                txtQuantAdulto.Text = "1";
                
            }
        }

        private void txtCarne_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPrecoCarne.Focus();
            }
        }

        private void txtPrecoCarne_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtFrango.Focus();
            }
        }

        private void txtFrango_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPrecoFrango.Focus();
            }
        }

        private void txtPrecoFrango_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtLinguica.Focus();
            }
        }

        private void txtLinguica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPrecoLinguica.Focus();
            }
        }

        private void txtPrecoLinguica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtQuantCerveja.Focus();
            }
        }

        private void txtQuantCerveja_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPrecoCerveja.Focus();
            }
        }

        private void txtPrecoCerveja_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtQuantRefri.Focus();
            }
        }

        private void txtQuantRefri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPrecoRefri.Focus();
            }
        }

        private void rbUnico_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUnico.Checked)
            {
                txtQuantAdulto.Enabled = false;
            }
            else
            {
                txtQuantAdulto.Enabled = true;
            }
        }

        private void txtQuantAdulto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtQuantAdulto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnCalcular.Select();
            }

        }

        private void txtQuantCerveja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtQuantRefri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtQuantCarvao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtQuantCarvao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalcular.Select();
            }
        }

        private void txtQuantCarvao_Click(object sender, EventArgs e)
        {
            if (chkCarvao.Checked)
            {
                txtQuantCarvao.ReadOnly = false;
            }
            else txtQuantCarvao.ReadOnly = true;

        }

        private void txtQuantCarvao_Leave(object sender, EventArgs e)
        {
            txtQuantCarvao.ReadOnly = true;
        }

        private void txtPrecoCarne_Leave(object sender, EventArgs e)
        {
            if (txtPrecoCarne.Text != String.Empty)
            {
                if (validacao.validaValor(txtPrecoCarne.Text))
                {
                    txtPrecoCarne.Text = String.Format("{0:F}", double.Parse(txtPrecoCarne.Text));
                }
                else
                {
                    txtPrecoCarne.Focus();
                }
            }

        }

        private void txtPrecoFrango_Leave(object sender, EventArgs e)
        {
            if (txtPrecoFrango.Text != String.Empty)
            {
                if (validacao.validaValor(txtPrecoFrango.Text))
                {
                    txtPrecoFrango.Text = String.Format("{0:F}", double.Parse(txtPrecoFrango.Text));
                }
                else
                {
                    txtPrecoFrango.Focus();
                }
            }

        }

        private void txtPrecoLinguica_Leave(object sender, EventArgs e)
        {
            if (txtPrecoLinguica.Text != String.Empty)
            {
                if (validacao.validaValor(txtPrecoLinguica.Text))
                {
                    txtPrecoLinguica.Text = String.Format("{0:F}", double.Parse(txtPrecoLinguica.Text));
                }
                else
                {
                    txtPrecoLinguica.Focus();
                }
            }

        }

        private void txtCarne_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void txtFrango_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void txtLinguica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void txtCarne_Leave(object sender, EventArgs e)
        {
            if (txtCarne.Text != String.Empty)
            {
                if (!validacao.validaValor(txtCarne.Text))
                {
                    txtCarne.Focus();
                }

            }
        }

        private void txtPrecoRefri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalcular.Select();

            }
        }

        private void txtFrango_Leave(object sender, EventArgs e)
        {
            if (txtFrango.Text != String.Empty)
            {
                if (!validacao.validaValor(txtFrango.Text))
                {
                    txtFrango.Focus();
                }

            }
        }

        private void txtLinguica_Leave(object sender, EventArgs e)
        {
            if (txtLinguica.Text != String.Empty)
            {
                if (!validacao.validaValor(txtLinguica.Text))
                {
                    txtLinguica.Focus();
                }

            }
        }

        private void txtPrecoCerveja_Leave(object sender, EventArgs e)
        {
            if (txtPrecoCerveja.Text != String.Empty)
            {
                if (validacao.validaValor(txtPrecoCerveja.Text))
                {
                    txtPrecoCerveja.Text = String.Format("{0:F}", double.Parse(txtPrecoCerveja.Text));
                }
                else
                {
                    txtPrecoCerveja.Focus();
                }
            }
        }

        private void txtPrecoRefri_Leave(object sender, EventArgs e)
        {
            if (txtPrecoRefri.Text != String.Empty)
            {
                if (validacao.validaValor(txtPrecoRefri.Text))
                {
                    txtPrecoRefri.Text = String.Format("{0:F}", double.Parse(txtPrecoRefri.Text));
                }
                else
                {
                    txtPrecoRefri.Focus();
                }
            }
        }

        private void txtPrecoCerveja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        

        private void txtPrecoRefri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void txtPrecoFrango_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void txtPrecoLinguica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void txtPrecoCarne_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private bool VerificaTextBoxEmPares()
        {
            erro = 0;
            #region Verifica os campos carne e preço carne
            if (txtCarne.Text == String.Empty && txtPrecoCarne.Text != String.Empty)
            {
                txtCarne.BackColor = Color.Yellow;
                erro++;
            }
            else
            {
                txtCarne.BackColor = Color.White;
            }
            if (txtCarne.Text != String.Empty && txtPrecoCarne.Text == String.Empty)
            {
                txtPrecoCarne.BackColor = Color.Yellow;
                erro++;
            }
            else
            {
                txtPrecoCarne.BackColor = Color.White;
            }
            #endregion
            #region Verifica os campos Frango e preço Frango
            if (txtFrango.Text == String.Empty && txtPrecoFrango.Text != String.Empty)
            {
                txtFrango.BackColor = Color.Yellow;
                erro++;
            }
            else
            {
                txtFrango.BackColor = Color.White;
            }
            if (txtFrango.Text != String.Empty && txtPrecoFrango.Text == String.Empty)
            {
                txtPrecoFrango.BackColor = Color.Yellow;
                erro++;
            }
            else
            {
                txtPrecoFrango.BackColor = Color.White;
            }
            #endregion
            #region Verifica os campos Linguiça e preço Linguiça
            if (txtLinguica.Text == String.Empty && txtPrecoLinguica.Text != String.Empty)
            {
                txtLinguica.BackColor = Color.Yellow;
                erro++;
            }
            else
            {
                txtLinguica.BackColor = Color.White;
            }
            if (txtLinguica.Text != String.Empty && txtPrecoLinguica.Text == String.Empty)
            {
                txtPrecoLinguica.BackColor = Color.Yellow;
                erro++;
            }
            else
            {
                txtPrecoLinguica.BackColor = Color.White;
            }
            #endregion
            #region Verifica os campos Cerveja e preço Cerveja
            if (txtQuantCerveja.Text == String.Empty && txtPrecoCerveja.Text != String.Empty)
            {
                txtQuantCerveja.BackColor = Color.Yellow;
                erro++;
            }
            else
            {
                txtQuantCerveja.BackColor = Color.White;
            }
            if (txtQuantCerveja.Text != String.Empty && txtPrecoCerveja.Text == String.Empty)
            {
                txtPrecoCerveja.BackColor = Color.Yellow;
                erro++;
            }
            else
            {
                txtPrecoCerveja.BackColor = Color.White;
            }
            #endregion
            #region Verifica os Refri e preço Refri
            if (txtQuantRefri.Text == String.Empty && txtPrecoRefri.Text != String.Empty)
            {
                txtQuantRefri.BackColor = Color.Yellow;
                erro++;
            }
            else
            {
                txtQuantRefri.BackColor = Color.White;
            }
            if (txtQuantRefri.Text != String.Empty && txtPrecoRefri.Text == String.Empty)
            {
                txtPrecoRefri.BackColor = Color.Yellow;
                erro++;
            }
            else
            {
                txtPrecoRefri.BackColor = Color.White;
            }
            #endregion
            

            if (erro > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #region verifica o item queijo
        private bool verifaQueijo()
        {            
            if (chkQueijo.Checked && cbQuantQueijo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a quantidade de queijos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else return true;
        }
        #endregion
        #region verifica o item pão de alho
        private bool verifaPaoAlho()
        {
            if (chkPaoAlho.Checked && cbQuantPaoAlho.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a quantidade de pão de alho.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else return true;
        }
        #endregion

        #region verifica o campo quant. clientes
        private bool verificaCliente()
        {
            if (rbClientes.Checked && txtQuantAdulto.Text == String.Empty)
            {
                MessageBox.Show("Informe a quantidade de pessoas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtQuantAdulto.BackColor = Color.Yellow;
                return false;
            }
            else
            {
                txtQuantAdulto.BackColor = Color.White;
                try
                {
                    int nPessoas = int.Parse(txtQuantAdulto.Text);
                    if (nPessoas < 2 && rbUnico.Checked==false)
                    {
                        MessageBox.Show("A quantidade de pessoas deve ser maior que 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtQuantAdulto.Focus();
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Erro de conversão no campo quantidade de clientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuantAdulto.Text = "1";
                    rbUnico.Checked = true;
                    return false;
                }
                return true;
            }
            
            
        }
        #endregion

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (VerificaTextBoxEmPares() & verifaQueijo() & verifaPaoAlho() & verificaCliente())
            {
                atribuiVariavel();
                atribuirConstrutores();

            }
            else
            {
                if(erro != 0)
                {
                    MessageBox.Show("Preencha os campos em amarelo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               
            }

        }
        #region Atribuir valores as variaveis

        private void atribuiVariavel()
        {
            try
            {
                if (txtCarne.Text != String.Empty)
                {
                    kgCarne = double.Parse(txtCarne.Text);
                } else kgCarne = 0;
                //
                if (txtFrango.Text != String.Empty)
                {
                    kgFrango = double.Parse(txtFrango.Text);
                }
                else kgFrango = 0;
                //
                if (txtLinguica.Text != String.Empty)
                {
                    kgLinguica = double.Parse(txtLinguica.Text);
                }
                else kgLinguica = 0;
                //
                if (txtPrecoCarne.Text != String.Empty)
                {
                    precoCarne = double.Parse(txtPrecoCarne.Text);
                }
                else precoCarne = 0;
                //
                if (txtPrecoFrango.Text != String.Empty)
                {
                    precoFrango = double.Parse(txtPrecoFrango.Text);
                }
                else precoFrango = 0;
                //
                if (txtPrecoLinguica.Text != String.Empty)
                {
                    precoLinguica = double.Parse(txtPrecoLinguica.Text);
                }
                else precoLinguica = 0;
                //
                if (txtQuantRefri.Text != String.Empty)
                {
                    quantRefri = int.Parse(txtQuantRefri.Text);
                }
                else quantRefri = 0;
                //
                if (txtQuantCerveja.Text != String.Empty)
                {
                    quantCerveja = int.Parse(txtQuantCerveja.Text);
                }
                else quantCerveja = 0;
                //
                if (txtPrecoCerveja.Text != String.Empty)
                {
                    precoCerveja = double.Parse(txtPrecoCerveja.Text);
                }
                else precoCerveja = 0;
                //
                if (txtPrecoRefri.Text != String.Empty)
                {
                    precoRefri = double.Parse(txtPrecoRefri.Text);
                }
                else precoRefri = 0;
                //
                if (cbQuantQueijo.SelectedIndex != -1)
                {
                    quantQueijo = int.Parse(cbQuantQueijo.Text);
                }
                else quantQueijo = 0;
                //
                if (cbQuantPaoAlho.SelectedIndex != -1)
                {
                    quantPaoAlho = int.Parse(cbQuantPaoAlho.Text);
                }
                else quantPaoAlho = 0;
                //
                if (txtQuantCarvao.Text != "0")
                {
                    quantCarvao = int.Parse(txtQuantCarvao.Text);
                }
                else quantCarvao = 0;
                //
                if (rbClientes.Checked && txtQuantAdulto.Text != "1")
                {
                    quantPessoas = int.Parse(txtQuantAdulto.Text);
                }
                else quantPessoas = 1;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro de conversão: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        #endregion

        private void atribuirConstrutores()
        {
            Carne carne = new Carne(kgCarne,precoCarne,kgFrango,precoFrango,kgLinguica,precoLinguica);
            Bebidas bebidas = new Bebidas(precoCerveja, precoRefri);
            Bebidas bebidas2 = new Bebidas(quantCerveja, quantRefri);
            txtQuantCarvao.Text = insumos.sacosCarvao().ToString();
            Carne carnes = new Carne();
           double teste = carnes.kilosCarne();
            MessageBox.Show(teste.ToString());
            
        }
    }


}


