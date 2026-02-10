//ohansel beltre 2025-1877

// Tipos de variables en C#:
int num = 10;
double decimalNum = 987654321.123456789;
float floatNum = 156.1295f;
decimal decimalNum2 = 123456789.1234567896882123m;
char letter = 'J';
string message = "hola mundo";
bool Student = true;

Console.WriteLine(message);
Console.WriteLine(num); 
Console.WriteLine(decimalNum);      
Console.WriteLine(floatNum);
Console.WriteLine(decimalNum2);
Console.WriteLine(letter);
Console.WriteLine(Student);

//Como se declara una constante en C#: Para declarar una constante en C# se utiliza la palabra clave const.
//Una constante es un valor que no puede cambiar durante la ejecución del programa.

const double PI = 3.14159;

Console.WriteLine(PI);

// Cambiando el valor de la variable PI 

PI = 3.14; // Esto generará un error de compilación, ya que PI es una constante y no se puede modificar.

// incrementando un entero:

int a = 12;
Console.WriteLine(a);

a++; // Incremento en 1
Console.WriteLine(a);

//operaciones con enteros:
a = 20;
int b = 10;

int sum = a + b; // Suma
int difference = a - b; // Resta
int product = a * b; // Multiplicación
int quotient = a / b; // División
int remainder = a % b; // Módulo

Console.WriteLine("Suma: " + sum);
Console.WriteLine("Resta: " + difference);
Console.WriteLine("Multiplicación: " + product);
Console.WriteLine("División: " + quotient);
Console.WriteLine("Módulo: " + remainder);

//Declarar un float con valor=10152466.25. Declara un byte que es igual a 5 + el float. 
float C = 10152466.25f;
byte X = C + 5;

// Hora del sistema:
DateTime Time = DateTime.Now;
Console.WriteLine("Hora actual: " + Time);

Console.ReadKey();



