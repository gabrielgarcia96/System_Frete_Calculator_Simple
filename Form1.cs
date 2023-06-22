using DotCEP;
using SistemaDeFrete.Correios;
using SistemaDeFrete.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SistemaDeFrete
{
    public partial class Form1 : Form
    {
        double Moto = 30;
        double Carro = 10;
        double Caminhao = 4;
        double Bandeira1 = 2;
        double Bandeira2 = 3;
        double Bandeira3 = 4;

        public Form1()
        {
            InitializeComponent();
            ComboBoxs();
            imgLogo.Image = SistemaDeFrete.Properties.Resources.Frete;
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        public void ComboBoxs()
        {
            comboBox1.Items.Add(Moto.ToString("Moto"));
            comboBox1.Items.Add(Carro.ToString("Carro"));
            comboBox1.Items.Add(Caminhao.ToString("Caminhão"));
            //////
            comboBoxTabela.Items.Add(Bandeira1.ToString("Bandeira 1"));
            comboBoxTabela.Items.Add(Bandeira2.ToString("Bandeira 2"));
            comboBoxTabela.Items.Add(Bandeira3.ToString("Bandeira 3"));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        ImgVeiculo.Image = SistemaDeFrete.Properties.Resources.Moto;

                        break;
                    case 1:
                        ImgVeiculo.Image = SistemaDeFrete.Properties.Resources.Carro;

                        break;
                    case 2:
                        ImgVeiculo.Image = SistemaDeFrete.Properties.Resources.caminhao;

                        break;
                }
            }
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            double km;
            double combustivel;
            double resultadoFrete = 0;
            double resultadoCustoPorKM = 0;
            double resultadoKmRodado = 0;
            double resultadoTotal = 0;
            double resultadoConsumoCombustivel = 0;

            if (double.TryParse(textValorCombustivel.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out combustivel) &&
         double.TryParse(textKm.Text, out km) && double.TryParse(textKmRodado.Text, out resultadoKmRodado))
            {
                if (checkbool.Checked)
                {
                    km *= 2;
                    
                }
               

                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        
                        resultadoFrete = (km / Moto) * combustivel;
                        resultadoCustoPorKM = combustivel / Moto;
                        resultadoConsumoCombustivel = km / Moto;
                        //switch (comboBoxTabela.SelectedIndex)
                        //{
                        //    case 0:
                        //        resultadoTotal = Bandeira1 * resultadoFrete;
                        //        break;

                        //    case 1:
                        //        resultadoTotal = Bandeira2 * resultadoFrete;
                        //        break;
                        //    case 2:
                        //        resultadoTotal = Bandeira3 * resultadoFrete;
                        //        break;
                        //}

                        break;
                    case 1:
                       
                        resultadoFrete = (km / Carro) * combustivel;
                        resultadoCustoPorKM = combustivel / Carro;
                        resultadoConsumoCombustivel = km / Carro;
                        //switch (comboBoxTabela.SelectedIndex)
                        //{
                        //    case 0:
                        //        resultadoTotal = Bandeira1 * resultadoFrete;
                        //        break;

                        //    case 1:
                        //        resultadoTotal = Bandeira2 * resultadoFrete;
                        //        break;
                        //    case 2:
                        //        resultadoTotal = Bandeira3 * resultadoFrete;
                        //        break;
                        //}

                        break;
                    case 2:
                       
                        resultadoFrete = (km / Caminhao) * combustivel;
                        resultadoCustoPorKM = combustivel / Caminhao ;
                        resultadoConsumoCombustivel = km / Caminhao;
                        //switch (comboBoxTabela.SelectedIndex)
                        //{
                        //    case 0:
                        //        resultadoTotal = Bandeira1 * resultadoFrete;
                        //        break;

                        //    case 1:
                        //        resultadoTotal = Bandeira2 * resultadoFrete;
                        //        break;
                        //    case 2:
                        //        resultadoTotal = Bandeira3 * resultadoFrete;
                        //        break;
                        //}

                        break;
                       

                }
                switch (comboBoxTabela.SelectedIndex)
                {
                    case 0:
                        resultadoTotal = Bandeira1 * resultadoFrete;
                        break;
                    case 1:
                        resultadoTotal = Bandeira2 * resultadoFrete;
                        break;
                    case 2:
                        resultadoTotal = Bandeira3 * resultadoFrete;
                        break;
                }
                resultadoKmRodado = km;    
                using (var consultar = new AtendeClienteClient())
                {
                    try
                    {
                        var endereco = consultar.consultaCEP(textCep.Text.Trim());
                        textDestino.Text = endereco.uf + ", " + endereco.cidade + ", " + endereco.bairro;
                    }
                    catch (System.Exception ex)
                    {

                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

                                              
            double resFrete = Math.Round(resultadoFrete, 2);
            double custoKM = Math.Round(resultadoCustoPorKM, 2);
            double resTotal = Math.Round(resultadoTotal, 2);
            double resConsumoCombustivel = Math.Round(resultadoConsumoCombustivel, 2);
            textDespesaCombustivel.Text = resFrete.ToString();
            textCustoPorKm.Text = custoKM.ToString();
            textKmRodado.Text = resultadoKmRodado.ToString();
            textTotal.Text = resTotal.ToString();
            textConsumoCombustivel.Text = resConsumoCombustivel.ToString();
            
        }

     
    }

       
    
}

