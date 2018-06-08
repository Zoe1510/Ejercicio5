using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Ejercicio5_DFDaCSharp
{
    /*5. Ejercicio de vectores: 
	Menú, subprogramas y vectores que realice lo siguiente:
    1.	Sumar dos vectores
    2.	Multiplicar dos vectores
    3.	Multiplicar por escalar
    4.	Definir cuál de los dos vectores es mayor, menor o igual, por medio su magnitud 
    5.	Salir del programa
    
    * Al capturar el tamaño de los vectores solo se debe permitir números positivos y mayores a uno. 
    * El tamaño lo define el usuario. 
    
         
    NOTA: Se puede utilizar cualquier función necesaria de C#.
 
     */
    class Program
    {
        private static int[] A;//Declaramos un vector A
        private static int[] B;//Declaramos un vector B
        private static int[] C;//Declaramos un vector C
        static void Main(string[] args)
        {
            Console.Title = "CALCULADORA DE MULTIPLICACIONES"; //lo que aparecerá en la barra superior de la ventana
            Console.SetWindowSize(75, 18); //establece columnas y filas

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Menu();

        }

        public static void Menu()
        {
            int opcion = 0, c = 0, d = 0, j = 0, k = 0;
            string n = "", n2 = "", n3 = "", n4 = "";
            bool esNumero = false, esNumero2 = false, c1 = false, c2 = false;
            int nro1 = 0, nro2 = 0, i = 0, m = 0;
            long res = 0;
            while (opcion < 1 | opcion > 3)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" _________________________________________________________________________ ");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|---------------------SELECCIONE UNA DE LAS OPCIONES----------------------|");
                Console.WriteLine("|_________________________________________________________________________|");
                Console.WriteLine("|_________________________________________________________________________|");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|---------------- PRESIONE 1 PARA: SUMAR DOS VECTORES --------------------|");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|---------------- PRESIONE 2 PARA: MULTIPLICAR DOS VECTORES --------------|");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|---------------- PRESIONE 3 PARA: MULTIPLICAR POR UN ESCALAR ------------|");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|---------------- PRESIONE 4 PARA: MAGNITUD ENTRE 2 VECTORES -------------|");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|---------------- PRESIONE 5 PARA: SALIR DEL PROGRAMA --------------------|");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|_________________________________________________________________________|");
                Console.WriteLine("                                                                           ");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                n = Console.ReadLine();
                esNumero = int.TryParse(n, out opcion);
                if (esNumero == false)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" _________________________________________________________________________ ");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|---------DATO INVÁLIDO. PRESIONE CUALQUIER TECLA PARA CONTINUAR----------|");
                    Console.WriteLine("|_________________________________________________________________________|");
                    Console.WriteLine("                                                                           ");

                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("                                                                           ");
                    Console.ReadKey();
                    Console.Clear();

                }
                else
                {
                    if (opcion < 1 | opcion > 5)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" _________________________________________________________________________ ");
                        Console.WriteLine("|                                                                         |");
                        Console.WriteLine("|---------DATO INVÁLIDO. PRESIONE CUALQUIER TECLA PARA CONTINUAR----------|");
                        Console.WriteLine("|_________________________________________________________________________|");
                        Console.WriteLine("                                                                           ");

                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("                                                                           ");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (opcion == 5)
                    {
                        //salir
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" _________________________________________________________________________ ");
                        Console.WriteLine("|                                                                         |");
                        Console.WriteLine("|----------------- PRESIONE CUALQUIER TECLA PARA SALIR -------------------|");
                        Console.WriteLine("|_________________________________________________________________________|");
                        Console.WriteLine("                                                                           ");
                        Console.ReadKey();
                    }
                    else
                    {
                        if (opcion == 1)
                        {
                            //sumar dos vectores
                            SumaVectores();
                        }
                        else if (opcion == 2)
                        {
                            //multiplicar dos vectores
                            multiplicar();
                        }
                        else if (opcion == 3)
                        {
                            //multiplicar por un escalar
                            multiplicarxEscalar();
                        }
                        else if (opcion == 4)
                        {
                            //evaluar magnitud entre dos vectores
                        }
                    }
                   
                }
               
            }
        }

        private static void SumaVectores()
        {
            /*---------ingresar datos--------------*/
            string linea;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine(" _________________________________________________________________________ ");
            Console.WriteLine("|                                                                         |");
                Console.Write("|-----------------Ingrese la longitud de los vectores a sumar: "); 
            linea = Console.ReadLine();
            Console.WriteLine("|_________________________________________________________________________|");
            Console.WriteLine("                                                                           ");
            
            int n = int.Parse(linea);
            A = new int[n];
            B = new int[n];
            C = new int[n];
            Console.WriteLine("|--------------------Ingresando valores al vector A-----------------------|");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("|--------------------Ingrese componente [" + (i + 1) + "]: ");
                linea = Console.ReadLine();
                A[i] = int.Parse(linea);
            }
            Console.WriteLine("|--------------------Ingresando valores al vector B-----------------------|");
            for (int j = 0; j < B.Length; j++)
            {
                Console.Write("|--------------------Ingrese componente [" + (j + 1) + "]: ");
                linea = Console.ReadLine();
                B[j] = int.Parse(linea);
            }
            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i] + B[i];
            }

            /*---------cálculos hechos--------------*/
            Console.WriteLine(" _________________________________________________________________________ ");
            Console.WriteLine("|                                                                         |");
            Console.WriteLine("|--------------------LA SUMA DE LOS VECTORES ES: -----------------------|");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("  [" + C[i] + "] ");
            }
            Console.WriteLine("|_________________________________________________________________________|");
            Console.WriteLine("                                                                           ");
            Console.ReadLine();
        }

        private static void multiplicar()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Clear();
            Console.WriteLine(" _________________________________________________________________________ ");
            Console.WriteLine("|                                                                         |");
            Console.Write("|-----------------Ingrese la longitud de los vectores a multiplicar: ");
            string linea = Console.ReadLine();
            Console.WriteLine("|_________________________________________________________________________|");
            Console.WriteLine("                                                                           ");

            int n = int.Parse(linea);

            int[] v1 = new int[n];
            int[] v2 = new int[n]; //Matriz 2 
            int[] M = new int[n];

            Console.WriteLine("|--------------------Ingresando valores al vector A-----------------------|");
            for (int i = 0; i < v1.Length; i++)
            {
                Console.Write("|--------------------Ingrese componente [" + (i + 1) + "]: ");
                linea = Console.ReadLine();
                v1[i] = int.Parse(linea);
            }
            Console.WriteLine("|--------------------Ingresando valores al vector B-----------------------|");
            for (int j = 0; j < v2.Length; j++)
            {
                Console.Write("|--------------------Ingrese componente [" + (j + 1) + "]: ");
                linea = Console.ReadLine();
                v2[j] = int.Parse(linea);
            }
            for (int i = 0; i < v1.Length; i++)
            {
                M[i] = v1[i] * v2[i];
            }
            /*---------cálculos hechos--------------*/
            Console.WriteLine(" _________________________________________________________________________ ");
            Console.WriteLine("|                                                                         |");
            Console.WriteLine("|----------- LA MULTIPLICACION DE LOS VECTORES ES: -----------------------|");
            for (int i = 0; i < v1.Length; i++)
            {
                Console.Write("  [" + M[i] + "]");
            }

            Console.WriteLine("                                                                           ");
            Console.WriteLine("|_________________________________________________________________________|");
            Console.WriteLine("                                                                           ");
            Console.ReadLine();

        }

        private static void multiplicarxEscalar()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Clear();
            Console.WriteLine(" _________________________________________________________________________ ");
            Console.WriteLine("|                                                                         |");
            Console.Write("|-----------------Ingrese la longitud del vector a multiplicar: ");
            string linea = Console.ReadLine();
            Console.WriteLine("|_________________________________________________________________________|");
            Console.WriteLine("                                                                           ");

            int n = int.Parse(linea);
            int[] M = new int[n];

            int[] v1 = new int[n];
            Console.WriteLine(" _________________________________________________________________________ ");
            Console.WriteLine("|                                                                         |");
            Console.Write("|-----------------Ingrese el escalar: ");
            linea = Console.ReadLine();
            Console.WriteLine("|_________________________________________________________________________|");
            Console.WriteLine("                                                                           ");
            int n1 = int.Parse(linea);

            int v2 =n1; //Matriz 2 
            Console.WriteLine("|--------------------Ingresando valores al vector A-----------------------|");
            for (int i = 0; i < v1.Length; i++)
            {
                Console.Write("|--------------------Ingrese componente [" + (i + 1) + "]: ");
                linea = Console.ReadLine();
                v1[i] = int.Parse(linea);
            }

            for (int i = 0; i < v1.Length; i++)
            {
                M[i] = v1[i] * v2;
            }
            /*---------cálculos hechos--------------*/
            Console.WriteLine(" _________________________________________________________________________ ");
            Console.WriteLine("|                                                                         |");
            Console.WriteLine("|----------- LA MULTIPLICACION DEL VECTOR & EL ESCALAR ES: ---------------|");
            for (int i = 0; i < v1.Length; i++)
            {
                Console.Write("  [" + M[i] + "]");
            }

            Console.WriteLine("                                                                           ");
            Console.WriteLine("|_________________________________________________________________________|");
            Console.WriteLine("                                                                           ");
            Console.ReadLine();
        }

        private static void evaluarMagnitud()
        {

        }
    }
}
