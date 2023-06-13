using System;

namespace TPFinal_EscalanteMaximiliano
{
    class Program
    {
        static void Main(string[] args)
        {
            //TRABAJO FINAL C# UNIDAD Nº 1:

            // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero.
            // A partir de dichos datos informar:

            // a. El mayor de los números pares.
            // b. La cantidad de números impares.
            // c. El menor de los números primos.

            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva
            // true o false según corresponda

            int n, acuPares = 0, mayorPares = 0, conImpares = 0, menorPrimo = 0;
            
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            menorPrimo = n;

            while(n != 0)
            {
                //Punto A:
                if (n % 2 == 0){
                    acuPares += n;
                    if (acuPares > mayorPares){
                        acuPares = mayorPares;
                        mayorPares = n;
                    }
                //Punto B:
                }else{
                    conImpares++;
                }
                // Punto C:
                if(primos(n)){
                    if(n <= menorPrimo){
                        menorPrimo = n;
                    }
                }
                Console.WriteLine("Ingrese otro numero: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" El Mayor de los Numeros Pares es: " + mayorPares);
            Console.WriteLine(" La Cantidad de Numeros Impares es: " + conImpares);
            Console.WriteLine(" El Menor de los Numeros Primos es: " + menorPrimo);
        }
        //Nota: Funcion Num Primos.
        static bool primos(int a){
            int con = 0;
            for (int x = 1; x <= a; x++)
            {
                if(a % x == 0){
                    con++;
                }
            }
            if(con == 2){
                return true;
            }else{
                return false;
            }
        }
    }
}
