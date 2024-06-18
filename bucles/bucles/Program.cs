// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

namespace Bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            While();
            Random();
            doWhile();
        }

        static void While()
        {
            Console.WriteLine("Este es un metodo While");
            Console.WriteLine("Deseas iniciar el While?");
            string answer = Console.ReadLine();
            int counter = 0;

            if (answer != "no") {
                while (answer != "no")
                {
                    counter++;
                    Console.WriteLine($"Esta es la iteración no.{counter}. ¿Deseas continuar?");
                    answer = Console.ReadLine();
                }
                Console.WriteLine($"Las iteraciones han terminado, el programa se ejecutó {counter} veces");
            }
            else
            {
                Console.WriteLine("Bueno, adios");
            }
        }

        static void Random()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            
            Console.WriteLine("Deseas iniciar el Juego?");
            string answer = Console.ReadLine();
            int guess = 101; // La variable se debe iniciar desde fuera con un valor fuera del rango posible generado aleatoriamente para que pueda iniciar la condicion del while 
            int attemps = 0;

            if (answer != "no")
            {
                while (guess != randomNumber)
                {
                    attemps++;

                    Console.WriteLine("Adivina en que numero estoy pensando (del 1 al 100)");
                    guess = int.Parse(Console.ReadLine());

                    int diference = Math.Abs(guess - randomNumber);
                    Console.WriteLine("Diferencia: " + diference);
                    Console.WriteLine("Numero: " + randomNumber);

                    if (diference == 0 && (guess == randomNumber))
                    {
                        Console.WriteLine($"Felicidades, adivinaste el número y solo te tomó {attemps} intentos.");
                    }
                    else if (diference == 1)
                    {
                        Console.WriteLine("Estás a 1 de atinarle");
                    }
                    else if (diference < 5)
                    {
                        Console.WriteLine("Estás muy cerca");
                    }
                    else if (diference < 10)
                    {
                        Console.WriteLine("Estás cerca");
                    }
                    else if (diference < 20)
                    {
                        Console.WriteLine("Estás acercandote");
                    }
                    else if (diference < 30)
                    {
                        Console.WriteLine("Estás mas o menos lejos");
                    }
                    else if (diference < 40)
                    {
                        Console.WriteLine("Estás muy lejos");
                    }
                    else if (diference < 45)
                    {
                        Console.WriteLine("Estás muy muy lejos");
                    }
                    else
                    {
                        Console.WriteLine("Estás hasta su puta madre de lejos parthner");
                    }
                }
            }
            else
            {
                Console.WriteLine("Bueno, adios");
            }

        }

        static void doWhile()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);

            Console.WriteLine("Deseas iniciar el Juego?");
            string answer = Console.ReadLine();
            int guess; // No debemos iniciar la variable, ya que al menos una vez se ejecutará el while gracias a Do
            int attemps = 0;

            if (answer != "no")
            {
                do { // Obliga al programa a ejecutarse una vez antes de tomar la condicion while, por lo que en esa primer ejecución "guess" ya habrá tomado un valor y continuará con normalidad.
                    attemps++;

                    Console.WriteLine("Adivina en que numero estoy pensando (del 1 al 100)");
                    guess = int.Parse(Console.ReadLine());

                    int diference = Math.Abs(guess - randomNumber);
                    Console.WriteLine("Diferencia: " + diference);
                    Console.WriteLine("Numero: " + randomNumber);

                    if (diference == 0 && (guess == randomNumber))
                    {
                        Console.WriteLine($"Felicidades, adivinaste el número y solo te tomó {attemps} intentos.");
                    }
                    else if (diference == 1)
                    {
                        Console.WriteLine("Estás a 1 de atinarle");
                    }
                    else if (diference < 5)
                    {
                        Console.WriteLine("Estás muy cerca");
                    }
                    else if (diference < 10)
                    {
                        Console.WriteLine("Estás cerca");
                    }
                    else if (diference < 20)
                    {
                        Console.WriteLine("Estás acercandote");
                    }
                    else if (diference < 30)
                    {
                        Console.WriteLine("Estás mas o menos lejos");
                    }
                    else if (diference < 40)
                    {
                        Console.WriteLine("Estás muy lejos");
                    }
                    else if (diference < 45)
                    {
                        Console.WriteLine("Estás muy muy lejos");
                    }
                    else
                    {
                        Console.WriteLine("Estás hasta su puta madre de lejos parthner");
                    }
                } while (guess != randomNumber);
            }
            else
            {
                Console.WriteLine("Bueno, adios");
            }
        }
    }
}
