using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
//Clase para calcular indice de maa corporal

class imc
    {

    //metodo principal

    static void Main(System.String[] args)
    {
        // Escribe tu nombre
        Console.WriteLine("Hola ¿Cuál es tu nombre?:");

        // Cree una variable de texto y obtiene la entrada del usuario y lo guarda en la variable
        string nombre = Console.ReadLine();

        // imprime la variable -nombre
        Console.WriteLine("Bienvenid@ a la calculadora de IMC (índice de masa corporal) " + nombre);
        Console.WriteLine("Si su IMC es menos de 18.5, se encuentra dentro del rango de peso insuficiente.\r\nSi su IMC es entre 18.5 y 24.9, se encuentra dentro del rango de peso normal o saludable.\r\nSi su IMC es entre 25.0 y 29.9, se encuentra dentro del rango de sobrepeso.\r\nSi su IMC es 30.0 o superior, se encuentra dentro del rango de obesidad.");
        Console.WriteLine("__________________________________________");
        double peso = 18.6 ; //Peso en libras
        double estatura = 1.89; //Estatura en metros
        Console.WriteLine("-Tu estatura en metros es: " + estatura);
        Console.WriteLine("__________________________________________");
        const double kilogramos = 0.453592;
        

        //Convertir el peso libras en kilogramos
        double peso_kilogramos = peso * kilogramos;
        Console.WriteLine("-Tu peso en Kg es: " + peso_kilogramos);
        Console.WriteLine("__________________________________________");

        //Calcular IMC------- IMC=peso/altura^2
        double imc = peso / (Math.Pow(estatura, 2));

        Console.WriteLine("-Tu peso IMC es: " + imc);
        Console.WriteLine("__________________________________________");

        if (imc < 18.5) {
            Console.WriteLine("Peso Insuficiente");
        }else if(imc >= 18.5 && imc < 24.9)
        {
            Console.WriteLine("Peso Saludable");
        }else if (imc >= 24.9 && imc < 29.9)
        {
            Console.WriteLine("SOBREPESO");
        }
        else
        {
            Console.WriteLine("OBESIDAD");
        }


        /*//si El IMC es menor que 18.5 Imprimir “Peso insuficiente”
        Console.WriteLine("-¿Su IMC es menor que 18.5?  " + (imc < 18.5));
        Console.WriteLine(" -Tu peso IMC es mayor que 18.5, por lo tanto NO tienes peso insuficiente");

        Console.WriteLine("__________________________________________");

        //si El IMC es mayor o igual que 18.5 y menor que 24.9 Imprimir “Peso saludable”
        Console.WriteLine("-¿Su IMC es mayor o igual que 18.5?  " + (imc >= 18.5));
        Console.WriteLine(" -Tu peso IMC es mayor o igual que 18.5 por lo tanto = Tienes peso insuficiente");*/
    }







}
