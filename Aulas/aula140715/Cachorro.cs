using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula140715
{
    class Cachorro
    {
        private string _nome;
        private double _peso;
        public double tamanhoCm;

        public void SetNome(string nome)
        {
            _nome = nome;
        }
        public void SetPeso(double peso)
        {
            _peso = peso;
        }
        public double RacaoDiariaKg()
        {
            return (_peso / ((tamanhoCm/100) * (tamanhoCm/100))) / 10;
        }
        public string GetNome() 
        {
            return _nome;
        }
        public double GetPeso()
        {
            return _peso;
        }
    }
}
