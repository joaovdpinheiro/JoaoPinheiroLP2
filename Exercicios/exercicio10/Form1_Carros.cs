using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio10
{
    public partial class Form1 : Form     
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        List<Carro> Cars = new List<Carro>();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Carro carros = new Carro();
            try
            {
                double capacidadeTanque = double.Parse(txtCapaTanque.Text);
                double kilometragem = Convert.ToDouble(txtKilometragem.Text);
                double potencia = Convert.ToDouble(txtPotencia.Text);
                int ano = Convert.ToInt32(txtAno.Text);
                string placa = txtPlaca.Text;
                string marca = txtMarca.Text;
                string modelo = txtModelo.Text;

                carros.SetPlaca(placa);
                carros.SetModelo(modelo);
                carros.SetMarca(marca);
                carros.SetCapacidadeTanque(capacidadeTanque);
                carros.SetKilometragem(kilometragem);
                carros.SetPotencia(potencia);
                carros.SetAno(ano);

                carros.GetPlaca();
                carros.GetModelo();
                carros.GetMarca();
                carros.GetCapacidadeTanque();
                carros.GetKilometragem();
                carros.Getpotencia();
                carros.GetAno();


                Cars.Add(carros);

                txtAno.Clear();
                txtCapaTanque.Clear();
                txtKilometragem.Clear();
                txtMarca.Clear();
                txtModelo.Clear();
                txtPlaca.Clear();
                txtPotencia.Clear();
            }
                
            catch (FormatException Ex)
            {
                MessageBox.Show("Pelo menos um dos valores informados está em formato inválido.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;

            while (i < Cars.Count)
            {

                if (txtPlaca.Text.ToString() == Cars[i].GetPlaca())
                {
                    MessageBox.Show("Informações do carro solicitado " + "\r\n" + "\r\n" + "Marca: " + Cars[j].GetMarca() + "\r\n" + "Modelo: " + Cars[j].GetModelo() + "\r\n" + "Potência: " + Cars[j].Getpotencia() + "\r\n" + "Kilometragem: " + Cars[j].GetKilometragem() + "\r\n" + "Capacidade do tanque: " + Cars[j].GetCapacidadeTanque() + "\r\n" + "Ano: " + Cars[j].GetAno());
                    break;
                }

                else
                {
                    j++;
                }
                i++;

            }

            if (j == Cars.Count)
            {
                MessageBox.Show("O carro solicitado não está registrado.");
            }
        } 
   }

}
