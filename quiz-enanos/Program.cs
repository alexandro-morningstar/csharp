using System.Formats.Asn1;

namespace Quiz {
    class Program {
        static void Main() {
            Encuesta encuesta01 = new Encuesta();
            encuesta01.ScrollQuiz();
            // Console.WriteLine(encuesta01.getQuestions(0));
            // Console.WriteLine(encuesta01.getOptions(0));
        }
    }

    class Encuesta {

        // "propiedades"
        private List<Dictionary<string, string>> questions = new List<Dictionary<string, string>> { // Lista de reactivos y opciones.
            new Dictionary<string, string> {{"question", "1.- Para referirse a los enanos, usted utiliza el término: "}, {"options", "\na) Gente pequeña. \nb) Liliputiense. \nc) Enano puto. \nd) Amigo."}},
            new Dictionary<string, string> {{"question", "\n2.- ¿Podría usted tener una pareja enana?: "}, {"options", "\na) Sí, siempre que nos amemos. \nb) Sólo si tiene la altura exacta para practicarme sexo oral estando de pie. \nc) No, los enanos son todos putos. \nd) Sí, obvio."}},
            new Dictionary<string, string> {{"question", "\n3.- ¿Cúantos enanos cree que entran en un Fiat 600?: "}, {"options", "\na) Seis: dos adelante y cuatro atrás. \nb) Catorce: cuatro adelante, siete atrás y tres en la cajuela. \nc) Uno solo: los enanos son todos ortivas y nunca llevan a nadie. \nd) Una vez medio borracho subimos como a ocho."}},
            new Dictionary<string, string> {{"question", "\n4.- ¿Tiene usted amigos enanos?: "}, {"options", "\na) Sí, varios. \nb) Tuve uno pero nos peleamos porque le dije \"Leñador de Bonsai\". \nc) No, no creo en la amistad entre el hombre y los enanos. \nd) Sí, la mayoría."}},
            new Dictionary<string, string> {{"question", "\n5.- ¿Cuántas horas de tele mira por día?: "}, {"options", "\na) Menos de 2. \nb) Entre 2 y 4. \nc) Entre 4 y 6. \nd) Más de 6."}},
            new Dictionary<string, string> {{"question", "\n6.- Cuando un enano entra a la misma habitación que usted: "}, {"options", "\na) No se inmuta. \nb) Le apoya un vaso en la cabeza. \nc) Lo señala y grita: \"Enano puto\". \nd) Lo saluda."}},
            new Dictionary<string, string> {{"question", "\n7.- ¿Si un enano se cae en el medio de un bosque, y no hay nadie que lo escuche, podemos decir que este hace ruido? (¿existe ruido en ese momento?)"}, {"options", "\na) Sí, todas las cosas que se caen hacen ruido por más que nadie las escuche, al final el enano generará la suficiente perturbación en las ondas del aire para generar lo que nosotros concebimos como sonido. \nb) No, porque nadie lo escucha. \nc) No sé, pero siempre es gracioso ver cuando se cae un enano. \nd) No sé si hace ruido, pero seguramente le dolió."}},
            new Dictionary<string, string> {{"question", "\n8.- ¿Cree que en esta encuesta se repite demasiado la palabra \"enano\"?: "}, {"options", "\na) Sí, pero no me jode. \nb) Sí,  la verdad me rompe un poco las pelotas. \nc) Sí, dice muchas veces \"enano\" y muy pocas \"puto\". \nd) No, estoy acostumbrado."}}
        };

        private Dictionary<int, string> results = new Dictionary<int, string> {
            {1, "'Usted odia a los enanos. Podría decirse que usted es algo así como \"el Hitler de los enanos\". Seguramente usted usa bigote y en el próximo mundial va a apoyar a Alemania"},
            {2, "Usted discrimina moderadamente a los enanos; no los mataría, pero los haría sus esclavos."},
            {3, "Usted no discrimina a los enanos. De hecho, usted no discrimina a ningún ser vivo de este planeta. Seguramente está asociado a Greenpeace y si se encuentra una billetera por la calle la devuelve sin sacar plata."},
            {4, "Usted es un enano."}
        };

        private Dictionary<string, int> optionValue = new Dictionary<string, int> {{"a", 3}, {"b", 2}, {"c", 1}, {"d", 4}};

        List<string> validAnswers = new List<string> {"a", "b", "c", "d"}; // Únicas opciones válidas.

        List<string> answerSummary = new List<string> {}; // Resumen de respuestas.

        int score = 0;

        //Metodos

        private string quizResult(score) {
            if (score >= 4 && score < 11) { return results[1]; }
            else if (score >= 11 && score < 19) { return results[2]; }
            else if (score >= 19 && score < 26) { return results[3]; }
            else if (score >= 26 && score < 33) { return results[4]; }
            else { return "Pero que ha pasao?!";}
        }


        private void addScore(answer) { // Suma puntaje.
            score += optionValue[answer];
        }

        private string getAnswer() { // Solicita, captura, evalua y retorna la respuesta.
            Console.Write("Ingresa una opción: ");
            try {
                string answer = Console.ReadLine();
                if (validAnswers.Contains(answer)) {return answer;} // Si es válida (en formato y opción), retorna.
                else {
                    Console.WriteLine("Opción inválida, intentalo de nuevo");
                    return getAnswer(); // Si no, hace recursión de método.
                    }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Algo ha salido mal, intentalo de nuevo");
                return getAnswer();
            }
        }

        private string getOptions(int questionIndex) { // Obtiene las opciones
            return questions[questionIndex]["options"];
        }

        private string getQuestions(int questionIndex) { // Obtiene la pregunta
            return questions[questionIndex]["question"];
        }

        public void ScrollQuiz() { // Recorre la encuesta
            int index = 0;
            while (index <= 7) {
                Console.WriteLine(getQuestions(index));
                Console.WriteLine(getOptions(index));
                string answer = getAnswer(); // Guarda la respuesta en variable porque se utiliza dos veces.
                // ------------------------ extra -----------------------------
                Console.WriteLine(answer);
                answerSummary.Add($"La repuesta de la pregunta {index+1} fue {answer}"); // Agrega respuesta al resumen.
                // ------------------------------------------------------------
                addScore(answer);
                index++;
            }
            Console.WriteLine(answerSummary);
            Console.WriteLine($"Tu resultado es: {quizResult(score)}");
        }
    }
}

// new Dictionary<string, string> {{"question", ""}, {"options", ""}}