using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionarioOOP.Models
{
    public class Circulo :  formaDoisD
    {
        private List<Ponto> _pontos;
        
        public List<Ponto> Pontos
        {
            get { return _pontos; }
            set
            {
                if(value.Count() != 2)
                {
                    throw new InvalidOperationException("Valores de pontos inválidos.");
                }
                _pontos = value;
            }
        }

        public override float obterArea()
        {
            var centro = Pontos[0]; 
            var ponto = Pontos[1];

            var raio = Math.Sqrt(Math.Pow(ponto.X - centro.X, 2) + Math.Pow(ponto.Y - centro.Y, 2));
            var area = PI * Math.Pow(raio, 2);

            return (float)area;
            
        }
    }
}
