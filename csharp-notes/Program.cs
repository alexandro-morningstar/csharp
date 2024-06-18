// --------- LISTAS ---------
// Array de numeros
int[] numeros = {32, 666, 333, 402}; //Cuando definimos un array, no puede variar de cantidad de elementos
Console.WriteLine($"{numeros[0]} {numeros[3]}");


// Lista dinamica de numeros
List<int> numbers = new List<int> {23, 45, 12, 120, 190}; // Esta es una lista de longitud dinámica
Console.WriteLine($"{numbers[2]}"); // Imprimir elementos especificos
Console.WriteLine(string.Join("-", numbers)); // Imprimir toda la lista definiendo como van a ir separados


// Lista de strings
string[] animales = {"gato", "puma", "ocelote", "pantera"};
List<string> bestAnimals = new List<string> {"Dragon", "Panda", "Gato"};


// Listas de datos dinamicos
dynamic[] datosMixtos = {"Esto es un string", 2000, true, animales};
List<dynamic> mixData = new List<dynamic> {"Esto es un string", 2000, true, animales};
Console.WriteLine(mixData[0]);


// Listas anidadas
List<List<string>> listasAnidadas = new List<List<string>>
{
    new List<string> { "gato", "puma" },
    new List<string> { "dragon", "panda" }
};


// Acceder e imprimir elementos de las listas anidadas
string puma = listasAnidadas[0][1];
Console.WriteLine(puma);

foreach (var animal in listasAnidadas[0]) // Imprime solo los elementos de la primer lista
{
    Console.WriteLine(animal);
}

foreach (var animalList in listasAnidadas) // Imprime todos los datos de todas las listas
{
    foreach (var animal in animalList)
    {
        Console.WriteLine(animal);
    }
}

// Listas anidadas dinamicas
List<List<dynamic>> games = new List<List<dynamic>> {
    new List<dynamic> {"RE7:Biohazard", "RE:Village", "RE:Remake"},
    new List<dynamic> {10, 10, 10}
};

foreach (var game in games[1]) {
    Console.WriteLine(game);
};

// --------- Diccionarios ---------


// Diccionarios
Dictionary<int, string> players = new Dictionary<int, string> {
    {1, "cholondrina"},
    {2, "flawless"},
    {3, "michel"},
    {4, "alexandros"}
};

Console.WriteLine(players[2]);

foreach (KeyValuePair<int, string> player in players) {
    Console.WriteLine($"Key: {player.Key}, Value: {player.Value}");
};


// Diccionarios anidados
Dictionary<string, Dictionary<int, string>> playerPowers = new Dictionary<string, Dictionary<int, string>> {
    {"besodelesbiana", new Dictionary<int, string> {{1, "Encularse a lo pendejo"}, {2, "Configurar routers"}, {3, "Administrar red"}}},
    {"alexandros", new Dictionary<int, string> {{1, "Encularse a lo pendejo"}, {2, "Programar Web"}, {3, "Hackeo etico"}}}
};
// Acceder e imprimir un valor especifico
string poder_3_Alexandros = playerPowers["alexandros"][3];
Console.WriteLine(poder_3_Alexandros);
// Iterar e imprimir todos los elementos de diccionario anidado
foreach (var player in playerPowers) {
    Console.WriteLine($"Llave externa (jugador): {player.Key}");
    foreach (var power in player.Value) {
        Console.WriteLine($"Llave interna (identificador de poder): {power.Key}, Valor (poder): {power.Value}");
    }
};