// See https://aka.ms/new-console-template for more information

/*
namespace OOP {
    class Coche { // Una clase es un modelo donde se redactan las caracteríßticas comunes de un grupo de objetos
        // La clase puede definirse como una plantilla, a partir de la cual se instancia o construyen los objetos
        Console.WriteLine("Hello, World!");

    }

    // Un objeto tiene propiedades (atributos) y un comportamiento (¿qué es capaz de hacer?)
    // Renault.color = "rojo" // NombreObjeto.método = "valor"
}
*/

namespace OOP {

    class Program{
        static void Main(string[] args) {
            /*
            Circle firstCircle(); // Instancia de objeto (objeto) de tipo Circle. (solo declaración)
            firstCircle = new Circle(); // Iniciación de objeto Cirlcle.
            */

            Circle secondCircle = new Circle(); // Instanciación, declaración e iniciación.
            Console.WriteLine(secondCircle.CalcArea(5)); // Acceso a metodo

            Circle thirdCircle = new Circle();
            Console.WriteLine(thirdCircle.CalcArea(10));


            ConversorMxnUsd conversor = new ConversorMxnUsd();
            conversor.UpdateMxn(-17);
            Console.WriteLine(conversor.convert(10));

        }
    }

    class Circle {
        // Propiedades
        private const double pi = 3.1416; // Una propiedad de la clase círculo. Campo de clase. No se puede modidicar porque es una constante tipo double
        // pi no es necesaria fuera de su ambito, no tiene porque accederse a ella desde fuera de su clase. Se debe encapsular.
        // private encapsula y la hace visible solo desde la misma clase a la que pertenece.
        // Para identificadores diferentes de public (like private) se utiliza camelCase (convención).

        // Metodos
        public double CalcArea(int radio) { // Un método de clase (Comportamiento, lo que puede hacer un objeto de clase circulo)
        // Para identificadores public, utiliar PascalCase (convención).
            return pi * Math.Pow(radio, 2);
        }
    }

    class ConversorMxnUsd {
        private double mxn = 18.1;

        public double convert(double quantity) {
            return quantity * mxn;
        }

        public void UpdateMxn(double newValue){
            if (newValue < 0) {
                Console.WriteLine("Valor incorrecto");
            } else {
                mxn = newValue;
            }
        }
    }
}
