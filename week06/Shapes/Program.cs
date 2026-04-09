using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> listaDeFiguras = new List<Shape>();

        Square cuadrado = new Square("Rojo", 3);
        Rectangle rectangulo = new Rectangle("Azul", 4, 5);
        Circle circulo = new Circle("Verde", 6);

        listaDeFiguras.Add(cuadrado);
        listaDeFiguras.Add(rectangulo);
        listaDeFiguras.Add(circulo);

        foreach (Shape figura in listaDeFiguras)
        {
            string color = figura.GetColor();
            double area = figura.GetArea();

            Console.WriteLine($"La figura es de color {color} y su área es de {area}");
        }
    }
}