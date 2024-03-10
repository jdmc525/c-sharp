using System;

/************************************/
//IMPRIMIR EN CONSOLA
/************************************/
Console.WriteLine(" Hola genteeeeee ");


/************************************/
//TIPOS DE VARIABLES
/************************************/
int entero = 5;
long numeroLargo = 1000000004000000000;
double numeroLargoDecimales = 10000.55444;
decimal decimales = 100.4555m;
string str = "Hola como estas";
char tipoChar = 'b';
bool booleano = true;

Console.WriteLine(numeroLargoDecimales);
Console.WriteLine(numeroLargo);
Console.WriteLine(entero);
Console.WriteLine(str);
Console.WriteLine(tipoChar);
Console.WriteLine(booleano);

//OJO con el decimal ya que debe poner m al final siempre
decimales = 5/6m;
Console.WriteLine(decimales);


Console.WriteLine("\n");


/************************************/
            //Entradas de usuario
/************************************/

Console.WriteLine("¿Cuál es tu nombre?");
string nombre = Console.ReadLine();
Console.WriteLine("Hola mi bro " + nombre + " eres un crack");


Console.WriteLine("\n");


/************************************/
            //METODOS
/************************************/


//Metodo en vacio
//que no devuelve ningun valor sino que solo ejecuta la accion dentro cuando se le manda a llamar

int vInicial = 0;
int vFinal = 10;

Contador(vInicial, vFinal);


void Contador(int inicio, int final) {
        for (int i = inicio; i <= final; i++){
            Console.WriteLine(i);
            
        }
}


Console.WriteLine("\n");


//METODO CON RETURN
//devuelve un valor cuando se le manda a llamar


//Esto es para convertir datos de entrada de String a Int
Console.WriteLine("Dame un numero");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Dame un numero");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("El resultado es " + Validar(num1,num2));

int Validar(int a, int b){
    return a + b;

};

Console.WriteLine("\n");


/************************************/
//Arreglos
/************************************/

//Se puede declarar asi solo el espacio que ocupara
long[] arrLong = new long[4];

//Se puede inicializar con valores
int[] arr1 = new int[] {11,22,33,44};

//Imprimir arreglo
for (int i = 0; i < 4; i++){   
    Console.WriteLine(arr1[i]);
    arrLong[i] = arr1[i];
    Console.WriteLine(arrLong[i]);
}





//Esto es para que el programa espere una entrada del usuario para poder dar por terminado el programa
Console.ReadKey();

