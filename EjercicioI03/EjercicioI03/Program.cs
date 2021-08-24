using System;

namespace EjercicioI03
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingreso;
            int numero;
            
            bool esPrimo = true;
            do
            {
                Console.WriteLine("Ingrese numero a calcular primos: ");
                //Da true si pudo asignar y lo asigna
                
                if (int.TryParse(Console.ReadLine(), out numero)){
                  
                    int i = 2;
                    while (i < numero)
                    {
                        esPrimo = true;
                        for (int j = 2; j < i; j++)
                        {
                            if(i % j == 0) {
                                esPrimo = false;
                                break;
                            }
                        }
                        if (esPrimo)
                        {
                            Console.WriteLine("{0} ",i);
                        }
                        i++;
                    }
                }
                else
                {                 
                    Console.WriteLine("Error al ingresar");
                }
                Console.WriteLine("Salir?: ");
                ingreso = Console.ReadLine();
            } while (ingreso != "salir");
        }
    }
}
