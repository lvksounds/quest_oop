using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionarioOOP.Models
{
    public class Triangulo : formaDoisD
    {
        private List<Ponto> _pontos;

        public List<Ponto> Pontos
        {
            get { return _pontos; }

            set
            {
                if(value.Count() != 3)
                {
                    throw new InvalidOperationException("Numero de pontos Invalido");
                }
                _pontos = value;
            }
        }

        public override float obterArea()
        {
            var ponto1 = Pontos[0];
            var ponto2 = Pontos[1];
            var ponto3 = Pontos[2];

            var matrizLinha1 = ponto1.X * (ponto2.Y - ponto3.Y);
            var matrizLinha2 = ponto2.X * (ponto3.Y - ponto1.Y);
            var matrizLinha3 = ponto3.X * (ponto1.Y - ponto2.Y);
            var determinante = matrizLinha1 + matrizLinha2 + matrizLinha3;

            return Math.Abs(determinante / 2);
        }
    }
}
