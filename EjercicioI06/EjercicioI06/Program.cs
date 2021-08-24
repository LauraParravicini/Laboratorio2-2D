using System;

namespace EjercicioI06
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio,fin;
            Console.WriteLine("Ingrese año de inicio: ");
            if( int.TryParse(Console.ReadLine(), out inicio))
            {
                Console.WriteLine("Ingrese año de fin: ");
                if (int.TryParse(Console.ReadLine(), out fin))
                {
                    if(inicio > 0 && fin > 0 && fin > inicio)
                    {
                        int i = inicio;
                        while(i <= fin)
                        {)
                            if(i % 4 == 0 || (i % 100 != 0 && i % 400 == 0) )
                            {
                                Console.WriteLine("{0}",i);
                            }
                            i++;
                        }
                    }
                }
            }
        }
    }
}
