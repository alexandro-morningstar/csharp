// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Sintaxis_basica // Los nombres de identificadores solo deben usar letras, numeros y guiones bajos / Deben comenzar por unaletra o guión bajo / No deben utilizar palabras reservadas.
{
    class Program
    {
        public static void Another_main() // Comentarios
        {
            Console.WriteLine("Hello, World!");

            // Esto es un comentario de una linea

            /* Esto es un comentario
             de varias lineas */
        }
    }
    class Tipos
    {
        public static void Not_main()
        {
            /* Convenciones (buenas practicas) al momento de declarar variables
            - No comenzar cel nombre de la variable con un guion bajo.
            - No crear mas de una varibale que se diferencien solo por una letra
            - Comenzar el nombre de la variable con letra minuscula.
            - Si el nombre de la variable esta compuesto de más de una palabra, comenzar la segunda con mayúscula (CamelCase) (edadAlumno)
            - No utilizar notación hungara (bedad = byteedad).*/

            // Para declarar una variable: se debe indicar el tipo de dato que va almacenar en su interior y a continuación el nombre de la variable:

            // Se puede hacer en dos acciones, inicializandola al inicio y luego asignarle un valor mucho despues:
            int edad;
            edad = 25;

            // O inicializarla y asignarle el valor al mismo tiempo:
            int age = 25;
            Console.Write(age);
        }
    }

    class Operadores
    {
        public static void Another_Another_Main()
        {
            // Suma = +
            // Resta = -
            // Multiplicacion = *
            // Division = /
            // Residuo o Módulo = %
            // Incremento = ++ o +=1
            // Decremento = -- o -=1

            Console.WriteLine(7/5); // Devuelve un entero (como si hiciera un floor de JS
            Console.WriteLine(7.0 / 5.0); // Devuelve un decimal
            Console.WriteLine(7 / 5.0); // Devuelve un decimal

            // CONCATENACIÓN:
            string birthdate = "28 de junio de 1998";
            Console.WriteLine("Tu fecha de nacimiento es: " + birthdate);

            // INTERPOLACIÓN
            Console.WriteLine($"Tu fecha de nacimiento es: {birthdate}");

            // INCREMENTO:
            int number = 10;
            Console.WriteLine($"El número en el que estoy pensando es: {number}");
            number++;
            Console.WriteLine($"El número en el que estoy pensando es: {number}");
            Console.WriteLine($"El número en el que estoy pensando es: {number++}"); // Primero lee e imprime number y luego hace el incremento ya que se lee de izquierda a derecha, por lo que no se ve reflejado el incremento en pantalla
            Console.WriteLine($"El número en el que estoy pensando es: {++number}"); // Primero realiza el incremento y luego realiza la impresion, porque se usó como prefijo de la variable
            number += 2;
            Console.WriteLine($"El número en el que estoy pensando es: {number}");

            // DECLARACIÓN DE VARIABLES:
            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27;

            Console.WriteLine(edadPersona3);
            // Lo siguiente no es correcto, no es com Python: int edadPersona1, edadPersona2, edadPersona3, edadPersona4 = 27; / Este caso únicamente la ultima variable se iniciaria con el valor de 27

            // DECLARACIÓN IMPLICITA DE VARIABLES / se utiliza var y se asigna en tiempo real el tipo de dato
            var saludo = "Hola Mundo"; // No se puede declarar en iniciar en diferentes lineas, todo debe ser en una misma
            var year = "1998";
            // No se puede volver a reasignar el valor a la variable, como si fuera una const de JS
        }
    }

    class ConversionesAndConstantes
    {
        public static void circulo()
        {
            // CONVERSION EXPLICITA
            double temperatura = 34.9;
            int temperaturaCDMX;

            temperaturaCDMX = (int)temperatura;

            // CONVERSION IMPLICITA
            int habitantesCDMX = 10000000;
            long habitantesCDMX2024 = habitantesCDMX;

            float pesoMaterial = 5.78F; // Para los float siempre se pone la F al final del numero para especificar el tipo de valor
            double pesoMaterialPreciso = pesoMaterial;
            // NOTA: Para mas información de que valor puede pasar a cual con cada tipo de conversión, se puede buscar "Tabla de conversiones numericas C#"

            // El texto es considerado un objeto
            // CONVERSION DE TEXTO A NUMERO
            // INPUT DE USUARIO
            Console.WriteLine("Introduce un número: ");
            int num1 = int.Parse(Console.ReadLine()); // ReadLine siempre retorna un string / string to int no puede hacerse de forma implicita, para eso se usa int.parse() para convertir string a int
            Console.WriteLine("Introduce otro número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"La suma de los dos números es: {num1 + num2}");

            // EJERCICIO CONSTANTES
            const double PI = 3.1416;
            Console.WriteLine("Introduce la medida del radio: ");
            double circleRadio = float.Parse(Console.ReadLine());
            double area = Math.Pow(circleRadio, 2) * PI;
            Console.WriteLine("El área del circulo con un radio de {0} es: {1}", circleRadio, area);
        }
    }
}

namespace Metodos
{
    class Metodos
    {
        public int SumaNumeros() // Esto es un método (yo lo interpreto como una función dentro de una clase, para que algún objeto realice alguna acción) / Todos los métodos deben ir dentro de una clase (¿no hay metodos globales?)
        {
            Console.WriteLine("Introduce el primer numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());
            return num1 + num2;
        }

        Console.WriteLine(SumaNumeros());

        void SumaNumerosSinRetorno() // Void significa que no se nos retornará ningún valor
        {
            Console.WriteLine("Introduce el primer numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write($"La suma de {num1} y {num2} es: {num1+num2}");
            // Un método con void nunca llevará un return.
        }
    }
}