
namespace Boletos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDesconto = new System.Windows.Forms.TextBox();
            this.textBoxJuros = new System.Windows.Forms.TextBox();
            this.textBoxMulta = new System.Windows.Forms.TextBox();
            this.maskedTextBoxVencimento = new System.Windows.Forms.MaskedTextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPagamento = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalpagar = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextValorDesconto = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextTotalAcrescimo = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextValorJuros = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextValorMulta = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextDiasAtrasados = new System.Windows.Forms.MaskedTextBox();
            this.totalapagar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.valorjuros = new System.Windows.Forms.Label();
            this.valormulta = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDesconto);
            this.groupBox1.Controls.Add(this.textBoxJuros);
            this.groupBox1.Controls.Add(this.textBoxMulta);
            this.groupBox1.Controls.Add(this.maskedTextBoxVencimento);
            this.groupBox1.Controls.Add(this.textBoxValor);
            this.groupBox1.Controls.Add(this.maskedTextBoxPagamento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de entrada:";
            // 
            // textBoxDesconto
            // 
            this.textBoxDesconto.Location = new System.Drawing.Point(134, 301);
            this.textBoxDesconto.Name = "textBoxDesconto";
            this.textBoxDesconto.Size = new System.Drawing.Size(100, 20);
            this.textBoxDesconto.TabIndex = 15;
            // 
            // textBoxJuros
            // 
            this.textBoxJuros.Location = new System.Drawing.Point(134, 248);
            this.textBoxJuros.Name = "textBoxJuros";
            this.textBoxJuros.Size = new System.Drawing.Size(100, 20);
            this.textBoxJuros.TabIndex = 14;
            // 
            // textBoxMulta
            // 
            this.textBoxMulta.Location = new System.Drawing.Point(134, 195);
            this.textBoxMulta.Name = "textBoxMulta";
            this.textBoxMulta.Size = new System.Drawing.Size(100, 20);
            this.textBoxMulta.TabIndex = 13;
            // 
            // maskedTextBoxVencimento
            // 
            this.maskedTextBoxVencimento.Location = new System.Drawing.Point(134, 97);
            this.maskedTextBoxVencimento.Mask = "00/00/0000";
            this.maskedTextBoxVencimento.Name = "maskedTextBoxVencimento";
            this.maskedTextBoxVencimento.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxVencimento.TabIndex = 12;
            this.maskedTextBoxVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(134, 47);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(100, 20);
            this.textBoxValor.TabIndex = 11;
            this.textBoxValor.Tag = "textBoxValor";
            this.textBoxValor.TextChanged += new System.EventHandler(this.textBoxValor_TextChanged);
            // 
            // maskedTextBoxPagamento
            // 
            this.maskedTextBoxPagamento.Location = new System.Drawing.Point(134, 145);
            this.maskedTextBoxPagamento.Mask = "00/00/0000";
            this.maskedTextBoxPagamento.Name = "maskedTextBoxPagamento";
            this.maskedTextBoxPagamento.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxPagamento.TabIndex = 7;
            this.maskedTextBoxPagamento.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Desconto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Juros:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Multa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pagamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vencimento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor do boleto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalpagar);
            this.groupBox2.Controls.Add(this.MaskedTextValorDesconto);
            this.groupBox2.Controls.Add(this.MaskedTextTotalAcrescimo);
            this.groupBox2.Controls.Add(this.MaskedTextValorJuros);
            this.groupBox2.Controls.Add(this.MaskedTextValorMulta);
            this.groupBox2.Controls.Add(this.MaskedTextDiasAtrasados);
            this.groupBox2.Controls.Add(this.totalapagar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.valorjuros);
            this.groupBox2.Controls.Add(this.valormulta);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(386, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 358);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados:";
            // 
            // totalpagar
            // 
            this.totalpagar.Location = new System.Drawing.Point(180, 301);
            this.totalpagar.Name = "totalpagar";
            this.totalpagar.ReadOnly = true;
            this.totalpagar.Size = new System.Drawing.Size(100, 20);
            this.totalpagar.TabIndex = 22;
            // 
            // MaskedTextValorDesconto
            // 
            this.MaskedTextValorDesconto.Location = new System.Drawing.Point(180, 251);
            this.MaskedTextValorDesconto.Name = "MaskedTextValorDesconto";
            this.MaskedTextValorDesconto.ReadOnly = true;
            this.MaskedTextValorDesconto.Size = new System.Drawing.Size(100, 20);
            this.MaskedTextValorDesconto.TabIndex = 21;
            // 
            // MaskedTextTotalAcrescimo
            // 
            this.MaskedTextTotalAcrescimo.Location = new System.Drawing.Point(180, 195);
            this.MaskedTextTotalAcrescimo.Name = "MaskedTextTotalAcrescimo";
            this.MaskedTextTotalAcrescimo.ReadOnly = true;
            this.MaskedTextTotalAcrescimo.Size = new System.Drawing.Size(100, 20);
            this.MaskedTextTotalAcrescimo.TabIndex = 20;
            // 
            // MaskedTextValorJuros
            // 
            this.MaskedTextValorJuros.Location = new System.Drawing.Point(180, 145);
            this.MaskedTextValorJuros.Name = "MaskedTextValorJuros";
            this.MaskedTextValorJuros.ReadOnly = true;
            this.MaskedTextValorJuros.Size = new System.Drawing.Size(100, 20);
            this.MaskedTextValorJuros.TabIndex = 19;
            // 
            // MaskedTextValorMulta
            // 
            this.MaskedTextValorMulta.Location = new System.Drawing.Point(180, 97);
            this.MaskedTextValorMulta.Name = "MaskedTextValorMulta";
            this.MaskedTextValorMulta.ReadOnly = true;
            this.MaskedTextValorMulta.Size = new System.Drawing.Size(100, 20);
            this.MaskedTextValorMulta.TabIndex = 18;
            // 
            // MaskedTextDiasAtrasados
            // 
            this.MaskedTextDiasAtrasados.Location = new System.Drawing.Point(180, 47);
            this.MaskedTextDiasAtrasados.Name = "MaskedTextDiasAtrasados";
            this.MaskedTextDiasAtrasados.ReadOnly = true;
            this.MaskedTextDiasAtrasados.Size = new System.Drawing.Size(100, 20);
            this.MaskedTextDiasAtrasados.TabIndex = 13;
            // 
            // totalapagar
            // 
            this.totalapagar.AutoSize = true;
            this.totalapagar.Location = new System.Drawing.Point(33, 304);
            this.totalapagar.Name = "totalapagar";
            this.totalapagar.Size = new System.Drawing.Size(73, 13);
            this.totalapagar.TabIndex = 17;
            this.totalapagar.Text = "Total à pagar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Valor do desconto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Total acréscimo:";
            // 
            // valorjuros
            // 
            this.valorjuros.AutoSize = true;
            this.valorjuros.Location = new System.Drawing.Point(33, 148);
            this.valorjuros.Name = "valorjuros";
            this.valorjuros.Size = new System.Drawing.Size(84, 13);
            this.valorjuros.TabIndex = 14;
            this.valorjuros.Text = "Valors dos juros:";
            // 
            // valormulta
            // 
            this.valormulta.AutoSize = true;
            this.valormulta.Location = new System.Drawing.Point(33, 100);
            this.valormulta.Name = "valormulta";
            this.valormulta.Size = new System.Drawing.Size(77, 13);
            this.valormulta.TabIndex = 12;
            this.valormulta.Text = "Valor da multa:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Dias atrasados:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(39, 422);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(683, 124);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operações";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(564, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "&Fechar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Apagar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Calcular  ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 558);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Boleto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPagamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox totalpagar;
        private System.Windows.Forms.MaskedTextBox MaskedTextValorDesconto;
        private System.Windows.Forms.MaskedTextBox MaskedTextTotalAcrescimo;
        private System.Windows.Forms.MaskedTextBox MaskedTextValorJuros;
        private System.Windows.Forms.MaskedTextBox MaskedTextValorMulta;
        private System.Windows.Forms.MaskedTextBox MaskedTextDiasAtrasados;
        private System.Windows.Forms.Label totalapagar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label valorjuros;
        private System.Windows.Forms.Label valormulta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxVencimento;
        private System.Windows.Forms.TextBox textBoxDesconto;
        private System.Windows.Forms.TextBox textBoxJuros;
        private System.Windows.Forms.TextBox textBoxMulta;
    }
}

