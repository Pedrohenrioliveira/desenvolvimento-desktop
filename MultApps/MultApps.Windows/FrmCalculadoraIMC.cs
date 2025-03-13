using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmCalculadoraIMC : Form
    {
        public FrmCalculadoraIMC()
        {
            InitializeComponent();
        }

        private void chkCrianca_CheckedChanged(object sender, EventArgs e)
        {
            chkCrianca.ForeColor = Color.DarkOrange;
            chkAdulto.ForeColor = Color.Gray;
            chkAdulto.Checked = false;
            lblIdade.Text = "Abaixo de 19 anos";
            cmbIdade.Visible = true;
            lblIdadeCmb.Visible = true;

        }

        private void chkAdulto_CheckedChanged(object sender, EventArgs e)
        {
            chkAdulto.ForeColor = Color.DarkOrange;
            chkCrianca.ForeColor = Color.Gray;
            chkCrianca.Checked = false;
            lblIdade.Text = "Acima de 19 anos";
            cmbIdade.Visible = false;
            lblIdadeCmb.Visible = false;
        }

        private void chkFeminino_CheckedChanged(object sender, EventArgs e)
        {
            chkFeminino.ForeColor = Color.DarkOrange;
            chkMasculino.ForeColor = Color.Gray;
            chkMasculino.Checked = false;
        }

        private void chkMasculino_CheckedChanged(object sender, EventArgs e)
        {
            chkMasculino.ForeColor = Color.DarkOrange;
            chkFeminino.ForeColor = Color.Gray;
            chkFeminino.Checked = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(chkAdulto.Checked && chkMasculino.Checked)
            {
                #region Adulto Masculino

                var peso = double.Parse(txtPeso.Text);
                var altura = double.Parse(txtAltura.Text);

                var imc = peso / (altura * altura);
                var textoBase = $@"Meu IMC: {imc:N2} é";

                if (imc <= 18.5)
                {
                    lblResultadoImc.Text = $@"{textoBase} abaixo do normal";
                    pictureBox1.Load(ImcImagem.MasculinoAbaixoDoNormal);
                }
                else if (imc < 24.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} normal";
                    pictureBox1.Load(ImcImagem.MasculinoNormal);
                }
                else if (imc < 29.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} sobrepeso";
                    pictureBox1.Load(ImcImagem.MasculinoSobrepeso);
                }
                else if (imc < 34.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} obesidade grau 1";
                    pictureBox1.Load(ImcImagem.MasculinoObesidadeGrau1);
                }
                else if (imc < 39.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} obesidade grau 2";
                    pictureBox1.Load(ImcImagem.MasculinoObesidadeGrau2);
                }
                else
                {
                    lblResultadoImc.Text = $@"{textoBase} obesidade grau 3";
                    pictureBox1.Load(ImcImagem.MasculinoObesidadeGrau3);
                }

                #endregion
            }
            else if (chkAdulto.Checked && chkFeminino.Checked)
            {
                #region Adulto Feminino

                var peso = double.Parse(txtPeso.Text);
                var altura = double.Parse(txtAltura.Text);

                var imc = peso / (altura * altura);
                var textoBase = $@"Meu IMC: {imc:N2} é";

                if (imc <= 18.5)
                {
                    lblResultadoImc.Text = $@"{textoBase} abaixo do normal";
                    pictureBox1.Load(ImcImagem.FemininoAbaixoDoNormal);
                }
                else if (imc < 24.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} normal";
                    pictureBox1.Load(ImcImagem.FemininoNormal);
                }
                else if (imc < 29.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} sobrepeso";
                    pictureBox1.Load(ImcImagem.FemininoSobrepeso);
                }
                else if (imc < 34.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} obesidade grau 1";
                    pictureBox1.Load(ImcImagem.FemininoObesidadeGrau1);
                }
                else if (imc < 39.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} obesidade grau 2";
                    pictureBox1.Load(ImcImagem.FemininoObesidadeGrau2);
                }
                else
                {
                    lblResultadoImc.Text = $@"{textoBase} obesidade grau 3";
                    pictureBox1.Load(ImcImagem.FemininoObesidadeGrau3);
                }

                #endregion
            }
            else if (chkCrianca.Checked)
            {
                #region Crianca
                
                var peso = double.Parse(txtPeso.Text);
                var altura = double.Parse(txtAltura.Text);

                var imc = peso / (altura * altura);
                var textoBase = $@"Meu IMC: {imc:N2} é";

                if (imc <= 18.5)
                {
                    lblResultadoImc.Text = $@"{textoBase} abaixo do normal";
                    pictureBox1.Load(ImcImagem.CriancaAbaixoDoNormal);
                }
                else if (imc < 24.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} normal";
                    pictureBox1.Load(ImcImagem.CriancaNormal);
                }
                else if (imc < 29.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} Sobrepeso";
                    pictureBox1.Load(ImcImagem.CriancaSobrepeso);
                }
                else
                {
                    lblResultadoImc.Text = $@"{textoBase} Obesidade";
                    pictureBox1.Load(ImcImagem.CriancaObesidade);
                }

                #endregion
            }


        }

    }
}
