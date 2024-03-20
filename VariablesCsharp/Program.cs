using System; 

class Program
{
    public static void Main(String[] args)
    {
        //Variables de numeros
        //Numeros enteros
        int numeroEntero = 10; // 20, 23, etc
        //Numeros punto flotante
        float numeroFloat = 4.5f; // 34.5f, 55.5f etc (Recuerda poner al final del numero la letra F o f ya que es un float)
        double numeroDouble = 23.3d; // 1.3d, 4,5d, 3,5d, (Recuerda poner al final del numero la letra D o d ya que es un double)
        decimal numeroDecimal = 6.4m; // 2.3m, 4.5m, (Recuerda poner al final del numero la letra M o M ya que es un decimal)
        long numeroLong = 12312323123; //239999, etc (Los numeros long son numeros largos o grandes, se utiliza para cifras grandes)
        //Cadenas de texto
        string cadenaTexto = "Joel Anaya"; // Csharp, Aprendiendo Csharp, etc (Recuerda que las cadenas de texto o string van dentro de comillas dobles
        char soloCaracter = 'C'; // M, J , A etc (El char solo puede tener un solo caracter y van dentro de comillas simples a diferencia del string
        //Booleanos
        bool Verdadero = true;
        bool Falso = false;  //Los booleanos solo llevan true y false, es como de logicas si o no.


        //Vamos a imprimir todo esto en pantalla 
        Console.WriteLine($"Número Entero: {numeroEntero}");
        Console.WriteLine($"Número Float: {numeroFloat}");
        Console.WriteLine($"Número Double: {numeroDouble}");
        Console.WriteLine($"Número Decimal: {numeroDecimal}");
        Console.WriteLine($"Número Long: {numeroLong}");
        Console.WriteLine($"String: {cadenaTexto}");
        Console.WriteLine($"Char: {soloCaracter}");
        Console.WriteLine($"Bool Verdadero: {Verdadero}");
        Console.WriteLine($"Bool Falso: {Falso}");


    }
}