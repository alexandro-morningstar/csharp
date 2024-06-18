// See https://aka.ms/new-console-template for more information
using System.Collections.Concurrent;

namespace Condicionales
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");
            comprobarEdad();
            Carnet();
            Media();
            Ifelse();
            Switch();
        }

        //Operadores Lógicos:
        //    == -> igual que
        //    != -> diferente de
        //    < -> Menor que
        //    > -> mayor que
        //    <= -> menor o igual que
        //    >= -> mayor o igual que
        //    || -> OR
        //    && -> AND

        static void comprobarEdad()
        {
            int edad01 = 15;
            int edad02 = 20;
            int mayoriaDeEdad = 18;

            if (edad02 <= mayoriaDeEdad) { Console.WriteLine("Alv chamaco"); }
            else { Console.WriteLine("Pase usted anciano"); }

            if (edad01 >= mayoriaDeEdad && edad02 >= mayoriaDeEdad) { Console.WriteLine("pueden pasar ambos"); }
            else { Console.WriteLine("Uno se debe quedar afuera"); }

            if (edad01 >= mayoriaDeEdad || edad02 >= mayoriaDeEdad) 
            {
                Console.WriteLine("pueden pasar ambos pero cuida al pequeñín");
            }
            else
            {
                Console.WriteLine("Ninguno de los dos es mayor de edad");
            }
        }

        static void Carnet()
        {
            Console.WriteLine("Vamos a evaluar si tienes lo necesario para conducir.");
            Console.WriteLine("¿Cuál es tu edad?: ");
            int edad = int.Parse(Console.ReadLine());
            if (edad <= 18) { Console.WriteLine("No puedes conducir"); }
            else
            {
                Console.WriteLine("Tienes licencia de conducir?");
                string licencia = Console.ReadLine();
                int compare = String.Compare(licencia, "si", true); // Compara si la string y el valor a evaluar son iguales / Compare regresa 0 o 1 (0 == son iguales, 1 == son diferentes) / true == no case sensitive, false == case sensitive
                if (compare == 0) { Console.WriteLine("Felicidades, tienes lo necesario para conducir"); }
                else { Console.WriteLine("No cumples con los requisitos completos"); }
            }
        }

        static void Media()
        {
            Console.WriteLine("Esto es un IF");
            // Al menos 8 para pasar
            Console.WriteLine("Introduce la calificación del parcial 1: ");
            float c1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la calificación del parcial 2: ");
            float c2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la calificación del parcial 3: ");
            float c3 = int.Parse(Console.ReadLine());
            float media = (c1 + c2 + c3) / 3;
            if ((c1 >= 8 && c2 >= 8 && c3 >= 8) || media >= 8)
            {
                Console.WriteLine($"Felicidades, haz aprobado con: {media}");
            }
            else
            {
                Console.WriteLine("Suerte para la proxima");
            }
        }

        static void Ifelse()
        {
            Console.WriteLine("Esti es un ELSE IF");
            Console.WriteLine("Cual es tu edad?");
            int edad = int.Parse(Console.ReadLine());
            if (edad < 13)
            {
                Console.WriteLine("Eres un niño");
            }
            else if (edad < 18)
            {
                Console.WriteLine("Eres adolescente");
            }
            else if (edad < 35)
            {
                Console.WriteLine("Eres adulto joven");
            }
            else if (edad < 60)
            {
                Console.WriteLine("Eres adulto maduro");
            }
            else if (edad < 85)
            {
                Console.WriteLine("Aguacates");
            }
            else
            {
                Console.WriteLine("wtf");
            }

        }

        static void Switch()
        {
            Console.WriteLine("Esto es un switch");
            Console.WriteLine("Para que tareas utilizarás la computadora? (Programación/Gaming/Ofimatica)");
            string answer = Console.ReadLine();

            switch (answer) // No admite double o float
            {
                case "programacion": // En los case, siempre van valores constantes y únicos para cada uno
                    Console.WriteLine("Necesitarás mucho CPU y RAM, el SSD no es esencial pero se recomienda");
                    break; // Siempre se termina con un break, es posible usar return o throw

                case "gaming":
                    Console.WriteLine("Necesitarás mucha GPU y RAM, el SSD es fundamental para cargar rápido mapas");
                    break;

                case "ofimatica":
                    Console.WriteLine("Necesitarás un monitor (opcional)");
                    break;

                default:
                    Console.WriteLine("No tengo una recomendación para ti");
                    break;
            }
        }
    }
}