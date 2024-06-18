// See https://aka.ms/new-console-template for more information

using System.Net.Security;

namespace Ejercicio_Metodos
{
    class Metodos
    {
        static string saludo = "Hello World!";

        static void Main() // Todo programa en C# debe llevar un método main.
        {
            mensajeEnPantalla();

            Console.WriteLine("Mensaje desde Main, tecnicamente debería salir despues de la llamada a MensajeEnPantalla()");

            SumaDosNumerosPredefinidos(7, 3);

            Console.WriteLine(sumaReturn(10, 5));

            Console.WriteLine(divisionReturnArrow(10, 3));

            metodoConVariablesDeClase();

            int parametro1 = 10;
            double parametro2 = 5;
            double parametro3 = 5;

            Console.Write(sumaParametrosOpcionales(parametro1, parametro2));
            Console.Write(sumaParametrosOpcionales(parametro1, parametro2, parametro3));
        }

        static void mensajeEnPantalla() // Hasta ahora solo sabemos que debe ser static para poder ser llamado por Main.
        {
            Console.WriteLine("Este es un mensaje desde un método staic void llamado desde Main en C#");
        }

        static void SumaDosNumerosPredefinidos(int num1, int num2) => Console.WriteLine($"La suma de {num1} y {num2} es: {num1 + num2}");

        static int sumaReturn (int num1, int num2)
        {
            return num1 + num2;
        }

        static double divisionReturnArrow (double num1, double num2) => num1 / num2; // Como en JS, se puede usar la arrow function, no es necesario usar return, es implicito la usar este tipo de metodo y solo es válido para cundo solo hay una linea

        static void metodoConVariablesDeClase()
        {
            // Una variable que se de clara desde dentro de un método estará limitado a ese scope (Alcance / Contexto / Ambito)
            // Al igual que en Python o JS podemos declarar variables fuera de los metodos (o funciones) pero permaneciendo dentro de la clase
            Console.WriteLine(saludo);
        }

        static double sumaParametrosOpcionales(int n1, double n2, double n3 = 0) // Si no se le asigna un valor al tercer parámetro en la llamada del método, este por defecto tomará el valor de 0
        {
            return n1 + n2 + n3;
        }
    }
}