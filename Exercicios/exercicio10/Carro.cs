using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio10
{
    class Carro
    {
       private string _placa;
        private string _modelo;
        private string _marca;
        private int _ano;
        private double _kilometragem;
        private double _capacidadeTanque;
        private double _potencia;

        public void SetPlaca(string placa)
        {           
           this._placa = placa;             
        }

        public void SetModelo(string modelo)
        {
            this._modelo = modelo;          
        }

        public void SetMarca(string marca)
        {     
            this._marca = marca;
        }

        public void SetKilometragem(double kilometragem)
        {
                this._kilometragem = kilometragem;
        }

        public void SetCapacidadeTanque(double capacidadeTanque)
        {
                    this._capacidadeTanque = capacidadeTanque;
            }

        public void SetPotencia(double potencia)
        {
                this._potencia = potencia;
        }

        public void SetAno(int ano)
        {
            this._ano = ano;
        }

        public int GetAno()
        {
            return _ano;
        }

        public string GetPlaca()
        {
            return _placa;
        }

        public string GetModelo()
        {
            return _modelo;
        }

        public string GetMarca()
        {
            return _marca;
        }

        public double GetKilometragem()
        {
            return _kilometragem;
        }

        public double GetCapacidadeTanque()
        {
            return _capacidadeTanque;
        }

        public double Getpotencia()
        {
            return _potencia;
        }
    }
}
