using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // declaração das variaveis

        Double valor;   // as variaveis em double é para ponto flutuante, números com casa apos a virgula
        Double multa;
        Double juros;
        Double desconto;
        DateTime vencimento, pagamento;  // variaveis datetime representa datas ou horas
        int dias;    // variaveis int são para números inteiros


        // configurando o botao apagar para retirar todos os dados quando for clicado

        private void button2_Click(object sender, EventArgs e)   
        {
            textBoxValor.Clear();                                                                       
            textBoxMulta.Clear();
            textBoxJuros.Clear();
            textBoxDesconto.Clear();
            maskedTextBoxVencimento.Clear();
            maskedTextBoxPagamento.Clear();
            MaskedTextDiasAtrasados.Clear();
            MaskedTextValorMulta.Clear();
            MaskedTextValorJuros.Clear();
            MaskedTextTotalAcrescimo.Clear();
            MaskedTextValorDesconto.Clear();
            totalpagar.Clear();
        }


        // configurando o botão fechar para pedir confirmação de saida do aplicação

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {

        }


        // inicio das entradas

        private void button1_Click(object sender, EventArgs e)
        {
            valor = double.Parse(textBoxValor.Text);
            multa = double.Parse(textBoxMulta.Text);
            juros = double.Parse(textBoxJuros.Text);
            desconto = double.Parse(textBoxDesconto.Text);
            vencimento = Convert.ToDateTime(maskedTextBoxVencimento.Text);
            pagamento = Convert.ToDateTime(maskedTextBoxPagamento.Text);

            //Calculos

            dias = (pagamento - vencimento).Days;

            double valormulta;

            // calculando a multa

            if (dias > 0)
            {
                valormulta = valor * (multa / 100);
            }
            else
            {
                valormulta = 0;
            }

            // calculando os juros


            double valorjuros = 0;

            if (dias > 3)
            {
                valorjuros = valor * (juros / 100) * dias;
            }


            // Calculando os descontos

            double valordesconto = 0;

            if (dias <= -5)
            {
                valordesconto = desconto;
            }

            // Cálculando os valores para dar o valor final
            double valorFinal = valor + valormulta + valorjuros - valordesconto;

            // Exibição das caixas intermediarias que o usuario não ira digitar
            MaskedTextDiasAtrasados.Text = dias.ToString();
            MaskedTextValorMulta.Text = valormulta.ToString("F2");
            MaskedTextValorJuros.Text = valorjuros.ToString("F2");
            MaskedTextTotalAcrescimo.Text = (valormulta + valorjuros).ToString("F2");
            MaskedTextValorDesconto.Text = valordesconto.ToString("F2");


            // Exibir o resultado final do pagamento formatado
            totalpagar.Text = $"R$ {valorFinal:F2}";



        }



    }


}
