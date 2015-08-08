using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_2_certificação
{
    class Carro
    {
        private string _modelo;
        private string _marca;
        private string _placa;
        private int _id = 0;
        private int _capacidadePassageiros;

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

        public void SetCapacidadePassageiros(int capaPassageiros)
        {
            _capacidadePassageiros = capaPassageiros;
        }

        public int GetCapacidadePassageiros()
        {
            return _capacidadePassageiros;
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
