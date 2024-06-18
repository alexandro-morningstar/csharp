// See https://aka.ms/new-console-template for more information
namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            doWhile();
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
                do
                { // Obliga al programa a ejecutarse una vez antes de tomar la condicion while, por lo que en esa primer ejecución "guess" ya habrá tomado un valor y continuará con normalidad.
                    attemps++;

                    Console.WriteLine("Adivina en que numero estoy pensando (del 1 al 100)");

                    try
                    {
                        guess = int.Parse(Console.ReadLine());
                    }

                    catch (Exception ex) when (ex.GetType() != typeof(FormatException)) // Estamos utilizando un filtro para que exceptuando un formatexception, capture cualquier error (algo general)
                    {
                        Console.WriteLine(ex.Message); // Mostrar la información detallada del error
                        Console.WriteLine("El dato ingresado no es un número o este no es válido y se tomará como 0. Revisa tus entradas posteriores.");
                        guess = 0; // Si no se asigna un valor después de un posible error o excepción, la variable nunca se habrá inicializado en dicha iteración, por lo que se crasheará el programa.
                    }

                    catch (FormatException ex) // Aqui unicamente capturará las excepciones de formato. NOTA: Si queremos obtener el mismo resultado, pero sin filtros, como en las ACLs debemos ir de lo mas especifico a lo mas general en cuanto a declaración de excepciones
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("El valor introducido es más grande de lo esperado y se tomará como 0. Revisa tus entradas posteriores.");
                        guess = 0;
                    }

                    //try
                    //{
                    //    guess = int.Parse(Console.ReadLine());
                    //}

                    //catch (FormatException ex) // Dentro del catch se pone el tipo de excepción que ocurre o puede ocurrir, y se le puede dar un nombre a la variable que contendrá dicha información
                    //{
                    //    Console.WriteLine(ex.Message); // Mostrar la información detallada del error
                    //    Console.WriteLine("El dato ingresado no es un número o este no es válido y se tomará como 0. Revisa tus entradas posteriores.");
                    //    guess = 0; // Si no se asigna un valor después de un posible error o excepción, la variable nunca se habrá inicializado en dicha iteración, por lo que se crasheará el programa.
                    //}

                    //catch (OverflowException ex) // Es posible encadenar multiples catch para un mismo bloque o línea de código que puede generar más de una excepción.
                    //{
                    //    Console.WriteLine(ex.Message);
                    //    Console.WriteLine("El valor introducido es más grande de lo esperado y se tomará como 0. Revisa tus entradas posteriores.");
                    //    guess = 0;
                    //}
                    
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