using System;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region declaracion de variables
            int cantidad;
            int valor;
            int contador = 0;
            int acumulador = 0;
            int promedio = 0;
            int minimo = 0;
            int maximo = 0;
            #endregion

            #region cantidad de ingresos
            Console.WriteLine("Ingrese la cantidad de ingresos");
            cantidad = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region iterar ingresos
            for (int n = 1; n <= cantidad; n++)
            {
                Console.WriteLine("Ingrese el valor");
                valor = Convert.ToInt32(Console.ReadLine());
                acumulador = acumulador + valor;
                if (n == 1)
                {
                    minimo = valor;
                    maximo = valor;
                }
                else
                {
                    if (valor < minimo)
                    {
                        minimo = valor;
                    }
                    if (valor > maximo)
                    {
                        maximo = valor;
                    }
                }
                if (valor != 0)
                {
                    contador++;
                }
            }
            #endregion

            #region contador calcular promedio
            if (contador != 0)
            {
                promedio = acumulador/contador;
            }
            #endregion

            #region mostrar informacion
            Console.WriteLine("Cantidad de numeros ingresados {0}",contador);
            Console.WriteLine("El promedio fue {0}", promedio);
            Console.WriteLine("El ingreso minimo fue {0}", minimo);
            Console.WriteLine("el ingreso maximo fue {0}", maximo);
            Console.ReadKey();
            #endregion
        }
    }
}
