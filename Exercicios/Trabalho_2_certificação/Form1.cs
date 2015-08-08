using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_2_certificação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        List<Carro> TotalCarros = new List<Carro>();
        int quantidadeCarrosLotados = 0;
        int quantidadePessoasViagem = 0;
        int numeroCarrosViagem;
        int x = 0;
        int z = 0;

        private void btnInfoNcarros_Click(object sender, EventArgs e)
        {
            if (x < 1)
            {
                try
                {
                    numeroCarrosViagem = Convert.ToInt32(txtNumerocarros.Text);
                    txtNumerocarros.Clear();
                    x++;
                }
                catch (FormatException)
                {
                    MessageBox.Show("O valor para determinar o carro deve ser inteiro.");
                }

            }

            else
            {
                MessageBox.Show("Números de carros já disponíveis.");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Carro carros = new Carro();
            try
            {
                if (z < numeroCarrosViagem)
                {

                    carros.SetPlaca(txtPlaca.Text);
                    carros.SetModelo(txtModelo.Text);
                    carros.SetMarca(txtMarca.Text);
                    carros.SetCapacidadePassageiros(Convert.ToInt32(txtCap.Text));
                    carros.SetValueToId();

                    carros.GetId();
                    carros.GetPlaca();
                    carros.GetModelo();
                    carros.GetMarca();

                    TotalCarros.Add(carros);

                    txtPlaca.Clear();
                    txtModelo.Clear();
                    txtMarca.Clear();
                    txtCap.Clear();
                    z++;
                }

                else
                {
                    MessageBox.Show("Todos os carros já foram registrados.");
                }

            }

            catch (FormatException)
            {
                MessageBox.Show("Algum dos valores informados está incorreto.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int j = Convert.ToInt32(txtSolicitarCarro.Text);
                txtSolicitarCarro.Clear();

                if (j != -1)
                {
                    if (j > TotalCarros.Count)
                    {
                        MessageBox.Show("O carro solicitado não está resgistrado, verifique o Id informado.");
                    }

                    else if (j <= TotalCarros.Count)
                    {

                        if (TotalCarros[j - 1].GetCapacidadePassageiros() > 0)
                        {
                            int vaga = TotalCarros[j - 1].GetCapacidadePassageiros();
                            vaga--;
                            TotalCarros[j - 1].SetCapacidadePassageiros(vaga);
                            quantidadePessoasViagem++;
                            MessageBox.Show("Vagas Restantes: " + TotalCarros[j - 1].GetCapacidadePassageiros());

                            if (vaga == 0)
                            {
                                quantidadeCarrosLotados++;
                            }
                        }

                        else
                        {
                            MessageBox.Show("Não existem vagas no Carro Solicitado.");
                        }

                        if (quantidadeCarrosLotados == numeroCarrosViagem)
                        {
                            for (int i = 0; i < TotalCarros.Count; i++)
                            {
                                txtCarros.AppendText("Carro " + (i + 1) + "\r\n" + "Placa: " + TotalCarros[i].GetPlaca() + "\r\n" + "Modelo: " + TotalCarros[i].GetMarca() + "\r\n" + "Quantidade de vagas disponíveis: " + TotalCarros[i].GetCapacidadePassageiros() + "\r\n" + "\r\n");
                            }
                            txtCarros.AppendText("Quantidade de pessoas na viajem: " + quantidadePessoasViagem);
                        }

                    }
                }

                else
                {
                    for (int i = 0; i < TotalCarros.Count; i++)
                    {
                        txtCarros.AppendText("Carro " + (i + 1) + "\r\n" + "Placa: " + TotalCarros[i].GetPlaca() + "\r\n" + "Modelo: " + TotalCarros[i].GetMarca() + "\r\n" + "Quantidade de vagas disponíveis: " + TotalCarros[i].GetCapacidadePassageiros() + "\r\n" + "\r\n");
                    }
                    txtCarros.AppendText("Quantidade de pessoas na viajem: " + quantidadePessoasViagem);
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("O Id deve ser um número inteiro.");
            }
        }
    }
}
