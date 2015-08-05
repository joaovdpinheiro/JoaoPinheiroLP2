using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio11
{
    class Carro
    {
        private string _modelo;
        private string _marca;
        private string _placa;
        private int _id = 0;
        private int _numeroPassageiros;

        public void SetModelo(string modelo)
        {
            this._modelo = modelo;
        }

        public string GetModelo()
        {
            return _modelo;
        }

        public void SetMarca(string marca)
        {
            this._marca = marca;
        }

        public string GetMarca()
        {
            return _marca;
        }

        public void SetPlaca(string placa)
        {
            this._placa = placa;
        }

        public string GetPlaca()
        {
            return _placa;
        }

        public void SetNumeroPassageiros(int numPassageiros)
        {
            this._numeroPassageiros = numPassageiros;
        }

        public int GetNumeroPassageiros()
        {
            return _numeroPassageiros;
        }

        public void SetValueToId()
        {
            _id = _id + 1;
        }

        public int GetId()
        {
            return _id;
        }
    }
}
