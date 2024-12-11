
# using System;

// Clase que representa un círculo
public class Circulo
{
    // Propiedad que almacena el radio del círculo
    public double Radio { get; set; }

    // Constructor que inicializa el radio
    public Circulo(double radio)
    {
        // Validación para asegurarse de que el radio sea positivo
        if (radio <= 0)
        {
            throw new ArgumentException("El radio debe ser un número positivo");
        }
        Radio = radio;
    }

    // CalcularArea es una función que devuelve un valor double, se utiliza para calcular el área de un círculo
    public double CalcularArea()
    {
        return Math.PI * Radio * Radio; // Fórmula: π * radio^2
    }

    // CalcularPerimetro es una función que devuelve un valor double, se utiliza para calcular el perímetro de un círculo
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * Radio; // Fórmula: 2 * π * radio
    }
}

// Clase que representa un cuadrado
public class Cuadrado
{
    // Propiedad que almacena el lado del cuadrado
    public double Lado { get; set; }

    // Constructor que inicializa el lado
    public Cuadrado(double lado)
    {
        // Validación para asegurarse de que el lado sea positivo
        if (lado <= 0)
        {
            throw new ArgumentException("El lado debe ser un número positivo");
        }
        Lado = lado;
    }

    // CalcularArea es una función que devuelve un valor double, se utiliza para calcular el área de un cuadrado
    public double CalcularArea()
    {
        return Lado * Lado; // Fórmula: lado^2
    }

    // CalcularPerimetro es una función que devuelve un valor double, se utiliza para calcular el perímetro de un cuadrado
    public double CalcularPerimetro()
    {
        return 4 * Lado; // Fórmula: 4 * lado
    }
}

// Clase que representa un rectángulo
public class Rectangulo
{
    // Propiedades que almacenan la base y la altura del rectángulo
    public double Base { get; set; }
    public double Altura { get; set; }

    // Constructor que inicializa la base y la altura
    public Rectangulo(double baseRectangulo, double altura)
    {
        // Validación para asegurarse de que la base y la altura sean positivas
        if (baseRectangulo <= 0 || altura <= 0)
        {
            throw new ArgumentException("La base y la altura deben ser números positivos");
        }
        Base = baseRectangulo;
        Altura = altura;
    }

    // CalcularArea es una función que devuelve un valor double, se utiliza para calcular el área de un rectángulo
    public double CalcularArea()
    {
        return Base * Altura; // Fórmula: base * altura
    }

    // CalcularPerimetro es una función que devuelve un valor double, se utiliza para calcular el perímetro de un rectángulo
    public double CalcularPerimetro()
    {
        return 2 * (Base + Altura); // Fórmula: 2 * (base + altura)
    }
}

// Clase principal que contiene el método Main
class Program
{
    static void Main(string[] args)
    {
        // Crear un objeto de la clase Circulo con un radio de 5
        Circulo circulo = new Circulo(5);
        Console.WriteLine("Área del círculo: " + circulo.CalcularArea());
        Console.WriteLine("Perímetro del círculo: " + circulo.CalcularPerimetro());

        // Crear un objeto de la clase Cuadrado con un lado de 4
        Cuadrado cuadrado = new Cuadrado(4);
        Console.WriteLine("Área del cuadrado: " + cuadrado.CalcularArea());
        Console.WriteLine("Perímetro del cuadrado: " + cuadrado.CalcularPerimetro());

        // Crear un objeto de la clase Rectangulo con una base de 6 y una altura de 3
        Rectangulo rectangulo = new Rectangulo(6, 3);
        Console.WriteLine("Área del rectángulo: " + rectangulo.CalcularArea());
        Console.WriteLine("Perímetro del rectángulo: " + rectangulo.CalcularPerimetro());
    }
}
