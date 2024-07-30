using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registra {
    public partial class Main : Form {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao {
            Soma,
            Subtracao,
            Multiplicacao,
            Divisao,
            Porcentagem
        }

        public Main() {
            InitializeComponent();
            //txtResultado.KeyPress += new KeyPressEventHandler(txtResultado_KeyPress);

        }
        private void txtResultado_KeyPress(object sender, KeyPressEventArgs e) {
            //// Verifica se a tecla pressionada é um dígito ou a tecla de ponto decimal
            //if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ',') {
            //    // Adiciona o caractere pressionado ao campo de texto
            //    if (e.KeyChar != (char)Keys.Back) {
            //        txtResultado.Text += e.KeyChar;
            //    } else if (txtResultado.Text.Length > 0) {
            //        txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            //    }
            //    e.Handled = true; // Impede o som de erro do sistema para a tecla
            //}
        }
        private void btnZero_Click(object sender, EventArgs e) {
            txtResultado.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e) {
            txtResultado.Text += "1";

        }

        private void btnDois_Click(object sender, EventArgs e) {
            txtResultado.Text += "2";

        }

        private void btnTres_Click(object sender, EventArgs e) {
            txtResultado.Text += "3";

        }

        private void btnQuatro_Click(object sender, EventArgs e) {
            txtResultado.Text += "4";

        }

        private void btnCinco_Click(object sender, EventArgs e) {
            txtResultado.Text += "5";

        }

        private void btnSeis_Click(object sender, EventArgs e) {
            txtResultado.Text += "6";

        }

        private void btnSete_Click(object sender, EventArgs e) {
            txtResultado.Text += "7";

        }

        private void btnOito_Click(object sender, EventArgs e) {
            txtResultado.Text += "8";

        }

        private void btnNove_Click(object sender, EventArgs e) {
            txtResultado.Text += "9";

        }

        private void btnSoma_Click(object sender, EventArgs e) {
            OperacaoSelecionada = Operacao.Soma;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "+";
        }

        private void btnSubtracao_Click(object sender, EventArgs e) {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "-";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e) {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "x";
        }

        private void btnDivisao_Click(object sender, EventArgs e) {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "÷";
        }

        private void btnPorcentagem_Click(object sender, EventArgs e) {
            OperacaoSelecionada = Operacao.Porcentagem;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "%";
        }
        private void btnIgual_Click(object sender, EventArgs e) {

            decimal valorDigitado = Convert.ToDecimal(txtResultado.Text);

            switch (OperacaoSelecionada) {
                case Operacao.Soma:
                    Resultado = Valor + valorDigitado;
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - valorDigitado;
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / valorDigitado;
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * valorDigitado;
                    break;
                case Operacao.Porcentagem:
                    Resultado = Valor * (valorDigitado / 100);
                    break;
            }
            txtResultado.Text = Convert.ToString(Resultado);
            lblOperacao.Text = "=";

        }

        private void Delete_Click(object sender, EventArgs e) {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }
        private void btnVirgula_Click_1(object sender, EventArgs e) {
            if (!txtResultado.Text.Contains(",")) {
                txtResultado.Text += ",";
            }
        }
    }
}
