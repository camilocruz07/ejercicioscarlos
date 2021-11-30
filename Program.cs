using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ALGORITMOS
            //---------------------------------------------------------------------------

            int num1;
            int num2;
            int num3;

            Console.WriteLine("ingresa hasta que numero deseas realizar la busqueda de numeros perfectos: ");
            int numero_calcular = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= numero_calcular; contador++)
            {
                num1 = 0;
                num2 = contador / 2;

                for (int contadorr2 = 1; contadorr2 <= num2; contadorr2++)
                {
                    num3 = contador % contadorr2;
                    if (num3 == 0)
                    {
                        num1 = num1 + contadorr2;
                    }

                    if (num1 == contador)
                    {
                        Console.WriteLine("El numero " + contador + " es perfecto y sus divisores son : " + num2);
                    }

                }
            }
            Console.ReadKey();

            //---------------------------------------------------------------------------

            Console.WriteLine("Ingrese un numero decimal: ");
            int numero = Int32.Parse(Console.ReadLine());

            long binario = DecimalBinario(numero);
            Console.WriteLine("El numero decimal " + numero + " en binario es: " + binario);

            int binario_decimal = BinarioDecimal(binario);
            Console.WriteLine("El numero binario " + binario + " en decimal es: " + numero);

            Console.ReadLine();



            static int BinarioDecimal(long binario)
            {

                int numero = 0;
                int digito = 0;
                const int divisor = 10;

                for (long contador1 = binario, contador2 = 0; contador1 > 0; contador1 /= divisor, contador2++)
                {
                    digito = (int)contador1 % divisor;
                    if (digito != 1 && digito != 0)
                    {
                        return -1;
                    }

                    numero += digito * (int)Math.Pow(2, contador2);
                }
                return numero;
            }

            static long DecimalBinario(int numero)
            {
                long digito = 0;
                const int divisor = 2;
                long binario = 0;

                for (int contador1 = numero % divisor, contador2 = 0; numero > 0; numero /= divisor, contador1 = numero % divisor, contador2++)
                {
                    digito = contador1 % divisor;
                    binario += digito * (long)Math.Pow(10, contador2);
                }

                return binario;
            }

            //---------------------------------------------------------------------------

            int[] tamaño_lista = { 15, 8, 5, 12 };
            double suma1 = 0.0;
            int media1 = 0;
            int contador1;
            for (contador1 = 0; contador1 < tamaño_lista.Length; contador1++)
            {
                suma1 = suma1 + tamaño_lista[contador1];
                Console.WriteLine("Valor: " + Convert.ToString(tamaño_lista[contador1]) + '\n');
                media1++;
            }
            Console.WriteLine("La media de los " + contador1 + " numeros es: " + suma1 / (media1) + '\n');

            //---------------------------------------------------------------------------

            Console.WriteLine("Tamaño de la lista: ");
            int tamaño_lista2 = Convert.ToInt32(Console.ReadLine());
            int[] lista;
            lista = new int[tamaño_lista2 + 1];


            pedir_numero(lista);
            static void pedir_numero(Array lista)
            {
                int i;
                Console.WriteLine("Ingresa un numero: ");
                int multiplo = Convert.ToInt32(Console.ReadLine());

                for (i = 1; i < lista.Length; i++)
                {
                    resultado(multiplo, i);
                    static void resultado(int multiplo, int i)
                    {

                        Console.WriteLine(multiplo + " * " + i + " = " + (multiplo * i) + '\n');

                    }

                }

            }

            //---------------------------------------------------------------------------

            string[] lista_nombres = { "juan", "pedro", "carlos", "juliana", "tatiana", "camila" };
            Console.WriteLine("juan, pedro, carlos, juliana, tatiana, camila, presiona 100 para salir");
            int elemento = 0;
            while (elemento != 100)
            {
                Console.WriteLine("¿Que elemento deseas buscar? de 0-5: " + '\n');
                elemento = Convert.ToInt32(Console.ReadLine());
                switch (elemento)
                {
                    case 0:
                        Console.WriteLine(lista_nombres[0] + '\n');
                        break;

                    case 1:
                        Console.WriteLine(lista_nombres[1] + '\n');
                        break;

                    case 2:
                        Console.WriteLine(lista_nombres[2] + '\n');
                        break;

                    case 3:
                        Console.WriteLine(lista_nombres[3] + '\n');
                        break;

                    case 4:
                        Console.WriteLine(lista_nombres[4] + '\n');
                        break;

                    case 5:
                        Console.WriteLine(lista_nombres[5] + '\n');
                        break;

                }

            }

            //---------------------------------------------------------------------------
            Console.WriteLine("Tamaño de la lista: ");
            int tamaño_lista_numeros = Convert.ToInt32(Console.ReadLine());
            int[] lista2;
            lista2 = new int[tamaño_lista_numeros + 1];
            int contador2;
            int contador3;
            int numeroo;
            for (contador2 = 1; contador2 < lista2.Length; contador2++)
            {
                Console.WriteLine("Ingresa un numero: ");
                numeroo = (Convert.ToInt32(Console.ReadLine()));
                lista2[contador2] = numeroo;


            }

            for (contador3 = 1; contador3 < lista2.Length; contador3++)
            {

                Console.WriteLine("valor de la lista: " + (lista2[contador3]));
            }

            //--------------------------------------------------------------------------

            int[] promedio;
            int hasta = 20;
            promedio = new int[hasta + 1];
            int suma2 = 0;
            int contador4;
            int total = 0;
            for (contador4 = 1; contador4 < promedio.Length; contador4++)
            {
                Console.WriteLine("Ingrese una nota: ");
                int numero_nota = (Convert.ToInt32(Console.ReadLine()));
                promedio[contador4] = numero_nota;
                suma2 = suma2 + promedio[contador4];
                total = suma2 / hasta;
            }
            Console.WriteLine("El promedio de las notas es: " + total);

            //--------------------------------------------------------------------------

            Console.WriteLine("Numero a finalizar: ");
            int hasta_donde = Int32.Parse(Console.ReadLine());

            for (int a = 1; a <= hasta_donde; a++)
            {
                int sumar = a + 2;
                Console.WriteLine(a + "/" + sumar + "+");
            }
            Console.Read();

            //---------------------------------------------------------------------------------------

            string cadena44 = " ";
            int positivosactuales2 = 0;
            int cantidadpositivos2 = 1;
            for (int cont = 1; cont <= 10; cont++)
            {

                if (positivosactuales2 < cantidadpositivos2)
                {
                    cadena44 = cadena44 + " + " + cont;
                    positivosactuales2 = positivosactuales2 + 1;
                }

                else
                {
                    cadena44 = cadena44 + " - " + cont;
                    positivosactuales2 = 0;
                    cantidadpositivos2 = cantidadpositivos2 + 1;
                }
            }
            Console.WriteLine(cadena44);

            //--------------------------------------------------------------------------

            Console.WriteLine(" ejercicio 6: Imprimir cinco veces la palabra 'Sena'");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("sena");
            }
            Console.WriteLine('\n');

            //-----------------------------------------------------------------------------

            Console.WriteLine("ejercicio 7:  Leer el valor de N e imprimir los primeros N números naturales.");
            int suma = 0;
            for (int q = 1; q <= 11; q++)
            {
                Console.WriteLine(q);
                suma = suma + q;
            }
            Console.WriteLine("La suma de los numeros naturales es: " + suma + '\n');

            //-----------------------------------------------------------------------------

            Console.WriteLine("ejercicio 8:  Leer el valor de N, imprimir y sumar los números de 1 a N.");
            int sumar1 = 0;
            for (int y = 1; y <= 10; y++)
            {
                Console.WriteLine(y);
                sumar1 = sumar1 + y;
            }
            Console.WriteLine("La suma de los numeros es: " + suma1 + '\n');

            //-----------------------------------------------------------------------------

            Console.WriteLine("ejercicio 9:  Calcular la suma de los primeros N números pares.");
            int sumar2 = 0;
            for (int e = 2; e <= 10; e += 2)
            {
                Console.WriteLine(e);
                sumar2 = sumar2 + e;
            }
            Console.WriteLine("La suma de los numeros pares es: " + suma2 + '\n');

            //-----------------------------------------------------------------------------

            Console.WriteLine("ejercicio 10:  Imprimir la serie de los N primeros números impares y la suma de ellos.");
            int suma3 = 0;
            for (int o = 1; o <= 10; o += 2)
            {
                Console.WriteLine(o);
                suma3 = suma3 + o;
            }
            Console.WriteLine("La suma de los nnumeros imapres es de: " + suma3 + '\n');

            //-----------------------------------------------------------------------------

            Console.WriteLine("ejercicio 11:  calcular el factorial de un número");
            int factotial = 6;
            int valor = 10;
            for (int u = 1; u <= valor; u++)
            {
                Console.WriteLine(u);
                factotial = factotial * u;
            }
            Console.WriteLine("El factorial de" + valor + " es: " + factotial + '\n');

            //-----------------------------------------------------------------------------

            Console.WriteLine("ejercicio 12: generar e imprimir la serie y la suma los primero N números múltiplos de M.");
            int suma4 = 0;
            int valor2 = 10;
            int numero_multiplo = 5;
            for (int h = 1; h <= valor2; h++)
            {
                Console.WriteLine(numero_multiplo + " * " + h + " = " + numero_multiplo * h);
                suma4 = suma4 + (numero_multiplo * h);
            }
            Console.WriteLine("La suma de los multiplos de" + numero_multiplo + " es: " + suma4 + '\n');

            //-----------------------------------------------------------------------------

            Console.WriteLine("ejercicio 13: ------S = 1 – 2 + 3 – 4 + 5 – 6 … + n------ \n");
            bool positivo = true;
            string cadena = " ";
            int suma5 = 0;
            for (int p = 1; p <= 10; p++)
            {
                if (positivo)
                {
                    cadena = cadena + " + " + p;
                    positivo = false;
                    suma5 = suma5 + p;
                }

                else
                {
                    cadena = cadena + " - " + p;
                    positivo = true;
                    suma5 = suma5 - p;
                }
            }
            Console.WriteLine(cadena);
            Console.WriteLine("S = " + suma5 + '\n' + '\n');

            //-----------------------------------------------------------------------------

            Console.WriteLine("ejercicio 14: ------S = 1/1 + 1 / 3 + 1 / 5 + 1 / 7 + 1 / N---------\n");
            int suma6 = 0;
            string cadena2 = " ";
            for (int j = 1; j <= 10; j += 2)
            {
                cadena2 = cadena2 + "1/" + j + " + ";
                suma6 = suma6 + j;
            }
            Console.WriteLine(cadena2);
            Console.WriteLine("S = " + suma6 + '\n' + '\n');

            //-----------------------------------------------------------------------------

            Console.WriteLine("ejercicio 15: ------S = 1 + 2 – 3 + 4 + 5 – 6 + 7 + 8 – 9 + … + N-----\n");
            int suma7 = 0;
            string cadena3 = " ";
            int positivosactuales = 0;
            int cantidadpositivos = 2;
            for (int g = 1; g <= 10; g++)
            {

                if (positivosactuales < cantidadpositivos)
                {
                    cadena3 = cadena3 + " + " + g;
                    positivosactuales = positivosactuales + 1;
                    suma7 = suma7 + g;
                }

                else
                {
                    cadena3 = cadena3 + " - " + g;
                    positivosactuales = 0;
                    suma7 = suma7 - g;
                }
            }
            Console.WriteLine(cadena3);
            Console.WriteLine("S = " + suma7 + '\n' + '\n');

            //-----------------------------------------------------------------------------

            Console.WriteLine("ejercicio 16: ------S = 1 + 2 – 3 + 4 + 5 – 6 + 7 + 8 + 9 + … + N-----\n");
            int suma88 = 0;
            string cadenas44 = " ";
            int positivosactualess2 = 0;
            int cantidadpositivoss2 = 1;
            for (int cont = 1; cont <= 10; cont++)
            {

                if (positivosactualess2 < cantidadpositivoss2)
                {
                    cadenas44 = cadenas44 + " + " + cont;
                    positivosactuales2 = positivosactualess2 + 1;
                    suma88 = suma88 + cont;
                }

                else
                {
                    cadena44 = cadena44 + " - " + cont;
                    positivosactuales2 = 0;
                    suma88 = suma88 - cont;
                    cantidadpositivos2 = cantidadpositivos2 + 1;
                }
            }
            Console.WriteLine(cadena44);
            Console.WriteLine("S = " + suma88 + '\n' + '\n');

            //-----------------------------------------------------------------------------

            Console.WriteLine("ejercicio 17: numeros cuadrados");
            int valor3 = 10;
            string cadena4 = " ";
            double elevado = Math.Pow(valor3, 2);
            for (int n = 1; n <= valor3; n++)
            {
                cadena4 = cadena4 + " + " + n;

            }
            Console.WriteLine(cadena4);
            Console.WriteLine("La suma de los numeros cuadrados es: " + elevado + '\n');

            //-----------------------------------------------------------------------------

            Console.WriteLine("ejercicio 18: Generar e imprimir las primeras N tablas de multiplicar, desde el 1 hasta el 9.");
            int numero_tabla = 9;
            for (int h = 1; h <= numero_tabla; h++)
            {
                int multi_tabla = numero_tabla * h;
                Console.WriteLine(numero_tabla + " * " + h + " = " + multi_tabla + '\n');
            }

            //-----------------------------------------------------------------------------

            Console.WriteLine("ejercicio 19: ----S = 2/3 + 4/5 + 6/7 + 8/9 + …+(N*2)/(N*2 + 1)----\n");
            int suma8 = 0;
            string cadena5 = " ";
            int hasta_dondee = 15;
            for (int a = 2; a <= hasta_dondee; a++)
            {
                if ((a % 2) == 1)
                {
                    cadena5 = cadena5 + a + " + ";
                    suma8 = suma8 + a;
                }
                else
                {
                    cadena5 = cadena5 + a + "/";
                    suma8 = suma8 + a;
                }
            }
            Console.WriteLine(cadena5);
            Console.WriteLine("La suma definida de los numero es: " + suma8 + '\n' + '\n');

            //-----------------------------------------------------------------------------

            Console.WriteLine("ejercicio 20: -----S = 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, …, N.-----\n");
            int limite = 10;
            int numero1 = 0;
            int auxi;
            int numero2 = 1;
            string lista_fibbonaci = " ";
            for (int s = 0; s < limite; s++)
            {
                auxi = numero1 + numero2;
                num2 = numero1;
                num1 = auxi;
                lista_fibbonaci = lista_fibbonaci + auxi + ",";
            }
            Console.WriteLine(lista_fibbonaci);
        }
    }
}
