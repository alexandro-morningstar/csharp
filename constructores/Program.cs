// See https://aka.ms/new-console-template for more information
namespace UsoCoches {

    // Un constructor define el estado inicial de un objeto.
    // Un método que tiene el mismo nombre de la clase, no devuelve nada y no es bool.
    
    class Program {

        static void Main() {
            Car car01 = new Car(); // Crear instancia de tipo Car y darle un estado inicial al coche (con ayuda del constructor y lo definido dentro de él.)
            Console.WriteLine(car01.getInfoCar());

            Car car02 = new Car(3600, 2000);
            Console.WriteLine(car02.getInfoCar());
        }
    }

    class Car{

        // Constructor por defecto(metodo)
        public Car(){
            numWheels = 4;
            lenght = 2300.5;
            width = 1800.0;
        }

        // Constructor sobrecargado para definir propiedades diferentes.
        public Car(double lenghtCar, double widthCar) {
            numWheels = 4;
            lenght = lenghtCar;
            width = widthCar;
        }

        // Propiedades
        private int numWheels;
        private double lenght;
        private double width;
        private bool airConditioner;
        private string typeTapestry;

        // Metodos

        public String getInfoCar() { // Metodos getting para acceder a información encapsulada y que no se pueda modificar
            // Por convención estos metodos inician con get.
            return $"Información del coche:\n Ruedas: {numWheels} Largo: {lenght} Ancho: {width}";
        }
    }
}