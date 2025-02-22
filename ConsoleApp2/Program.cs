// QUiz 0 //
// Adrian Monge Mairena | 202380088 //
// Algoritmo y Estructura de Datos I | 1S 2025 | Jose Isaac Ramirez Herrera //
using System;

// 1. CLASE: Es una plantilla que define la estructura y el comportamiento de los objetos.
class Auto
{
    // 2. OBJETO: Es una instancia de una clase. Contiene atributos (datos) y métodos (acciones).
    public string Marca { get; set; }
    public int Velocidad { get; set; }

    public void Acelerar()
    {
        Velocidad += 10;
        Console.WriteLine($"El auto {Marca} aceleró a {Velocidad} km/h");
    }
}

// 3. ABSTRACCIÓN: Se ocultan los detalles innecesarios y se muestran solo las características esenciales.
abstract class Figura
{
    public abstract void Dibujar(); // Método abstracto obliga a las clases derivadas a implementarlo
}

class Circulo : Figura
{
    public override void Dibujar()
    {
        Console.WriteLine("Dibujando un círculo");
    }
}

// 4. ENCAPSULAMIENTO: Se ocultan los detalles internos de una clase y solo se exponen métodos controlados.
class CuentaBancaria
{
    private decimal saldo; // La variable es privada, no puede modificarse directamente desde fuera

    public void Depositar(decimal cantidad)
    {
        if (cantidad > 0)
        {
            saldo += cantidad;
            Console.WriteLine($"Depósito exitoso. Saldo actual: {saldo}");
        }
    }

    public decimal ObtenerSaldo() // Método para acceder al saldo
    {
        return saldo;
    }
}

// 5. HERENCIA: Permite que una clase derive de otra, reutilizando código.
class Animal
{
    public void Comer()
    {
        Console.WriteLine("El animal está comiendo");
    }
}

class Perro : Animal // Perro hereda de Animal
{
    public void Ladrar()
    {
        Console.WriteLine("El perro está ladrando");
    }
}

// 6. POLIMORFISMO: Permite que un mismo método se comporte de diferentes maneras según el objeto.
class FiguraGeometrica
{
    public virtual void Dibujar()
    {
        Console.WriteLine("Dibujando una figura");
    }
}

class Cuadrado : FiguraGeometrica
{
    public override void Dibujar()
    {
        Console.WriteLine("Dibujando un cuadrado");
    }
}

class Program
{
    static void Main()
    {
        // Ejemplo de Objeto y Clase
        Auto miAuto = new Auto { Marca = "Toyota", Velocidad = 0 };
        miAuto.Acelerar();

        // Ejemplo de Abstracción
        Figura figura = new Circulo();
        figura.Dibujar();

        // Ejemplo de Encapsulamiento
        CuentaBancaria cuenta = new CuentaBancaria();
        cuenta.Depositar(1000);
        Console.WriteLine("Saldo disponible: " + cuenta.ObtenerSaldo());

        // Ejemplo de Herencia
        Perro perro = new Perro();
        perro.Comer(); // Método heredado de Animal
        perro.Ladrar(); // Método propio de Perro

        // Ejemplo de Polimorfismo
        FiguraGeometrica figura1 = new Cuadrado();
        figura1.Dibujar(); // Llama al método específico de Cuadrado
    }
}
