using questionarioOOP.Models;

var circulo = new Circulo();
var circuloPontos = new List<Ponto>
        {
            new Ponto(4, 8),
            new Ponto(14, 14),
        };

circulo.Pontos = circuloPontos;
Console.WriteLine($"Área do círculo: {circulo.obterArea()}");

var triangulo = new Triangulo();
var trianguloPontos = new List<Ponto>
        {
            new Ponto(-2, 2),
            new Ponto(8, 0),
            new Ponto(-5, 5),
        };

triangulo.Pontos = trianguloPontos;
Console.WriteLine($"Área do triângulo: {triangulo.obterArea()}");