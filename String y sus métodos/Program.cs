//Linea de texto de una sola línea
string texto = "Esto es el lenguaje C#";

//Linea de texto de multiples líneas
string textoM = """Este es un texto con multiples lineas""";

//Imprimimos la primera linea
Console.WriteLine(texto);

//Imprimimos la segunda linea
Console.WriteLine(textoM);






//Concatenación 

string variable = "Hola Mundo :)";

//Forma #1 
Console.WriteLine("Mi primer" + variable);

//Forma #2 
Console.WriteLine(string.Format("La frase {0} tiene {1} letras", variable, variable.Length));

//Forma #3 y la más fácil

Console.WriteLine($"La frase {variable} tiene {variable.Length}");




//Creamos variable texto

string text = "Hola, ESTO es un Texto";

Console.WriteLine(text.ToUpper()); // Convierte el texto a mayúsculas

Console.WriteLine(text.ToLower()); // Convierte el texto todo en minúsculas

Console.WriteLine(text.Count()); // Para contar cuantos elemantos hay

// Hay muchos mas métodos si pones un  punto despues de la palabra text te darás cuenta que hay muchos métodos.


//Métodos de Console Explicados 

Console.Write("Hola"); // Imprime el texto y mantiene el cursor en la misma línea

Console.WriteLine("Hola Mundo "); //Imprime el texto y lleva el cursor a la siguiente linea 

Console.Read(); // Toma un ingreso simple de tipo string y devuelve el valor ASCII de ese ingreso 

Console.ReadLine(); // Toma un ingreso string o integer y lo devuelve como valor de salida 

Console.ReadKey(); // Toma un ingreso simple de tipo string y devuelve la información de tecla 

Console.ForegroundColor = ConsoleColor.Cyan; // Cambia el color de texto de consola 

Console.BackgroundColor = ConsoleColor.White; // Cambia el color de fondo de la consola 

Console.Clear(); // Sirve para limpiar la consola



