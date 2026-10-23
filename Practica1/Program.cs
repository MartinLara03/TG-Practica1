using System;

namespace Practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. SUMA DE NÚMEROS PARES
            Console.WriteLine("1. SUMA DE NÚMEROS PARES");

            int sumaPares = sumarPares();

            Console.WriteLine("La suma de los números pares del 1 al 100 es: " + sumaPares);

            Console.WriteLine();


            // 2. NÚMERO MAYOR Y MENOR
            Console.WriteLine("2. NÚMERO MAYOR Y MENOR");

            Console.Write("Ingresa el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            mayorMenor(numero1, numero2);

            Console.WriteLine();


            // 3. FACTORIAL
            Console.WriteLine("3. FACTORIAL");

            Console.Write("Ingresa un número positivo: ");
            int numeroFactorial = int.Parse(Console.ReadLine());

            calcularFactorial(numeroFactorial);

            Console.WriteLine();


            // 4. PAR O IMPAR
            Console.WriteLine("4. PAR O IMPAR");

            Console.Write("Ingresa un número: ");
            int numeroParImpar = int.Parse(Console.ReadLine());

            parImpar(numeroParImpar);

            Console.WriteLine();


            // 5. DIVISIBLE POR 2, 3, 5 O 7



            Console.WriteLine("5. DIVISIBILIDAD");
            Console.Write("Ingresa un número: ");

            int numeroDivisible = Convert.ToInt32(Console.ReadLine());

            string mensaje = string.Empty;
            verificarDivisible(numeroDivisible, ref mensaje);

            Console.WriteLine(mensaje);


          
            // 6. IMPRESIÓN DE MENSAJES
            Console.WriteLine("6. FIZZBUZZ");

            string resultadoFizzBuzz = fizzBuzz();

            Console.WriteLine(resultadoFizzBuzz);
        }


        //1.  Sumar números pares del 1 al 100
        static int sumarPares()
        {
            int suma = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    suma = suma + i;
                }
            }

            return suma;
        }



        //2.  Determinar número mayor y menor
        static void mayorMenor(int numero1, int numero2)
        {
            if (numero1 > numero2)
            {
                Console.WriteLine("Número mayor: " + numero1);
                Console.WriteLine("Número menor: " + numero2);
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine("Número mayor: " + numero2);
                Console.WriteLine("Número menor: " + numero1);
            }
            else
            {
                Console.WriteLine("Los dos números son iguales.");
            }
        }



        //3.  Calcular factorial
        static void calcularFactorial(int numero)
        {
            int factorial = 1;

            if (numero >= 0)
            {
                for (int i = 1; i <= numero; i++)
                {
                    factorial = factorial * i;
                }

                Console.WriteLine("El factorial de " + numero + " es: " + factorial);
            }
            else
            {
                Console.WriteLine("El número debe ser positivo.");
            }
        }



        // 4. Determinar si un número es par o impar
        static void parImpar(int numero)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine("El número " + numero + " es par.");
            }
            else
            {
                Console.WriteLine("El número " + numero + " es impar.");
            }
        }



        //5. Parámetro por referencia
        static void verificarDivisible(int numero, ref string mensaje)
        {
            if (numero % 2 == 0)
            {
                mensaje = "El número " + numero + " es divisible entre 2.";
            }
            else if (numero % 3 == 0)
            {
                mensaje = "El número " + numero + " es divisible entre 3.";
            }
            else if (numero % 5 == 0)
            {
                mensaje = "El número " + numero + " es divisible entre 5.";
            }
            else if (numero % 7 == 0)
            {
                mensaje = "El número " + numero + " es divisible entre 7.";
            }
            else
            {
                mensaje = "El número no es divisible por 2, 3, 5 o 7.";
            }
        }


            // 6. Fizz-Buzz del 1 al 100
            static string fizzBuzz()
            {
                string resultado = "";

                for (int i = 1; i <= 100; i++)
                {
                    string mensaje = "";

                    if (i % 15 == 0)
                    {
                        mensaje = "FizzBuzz";
                    }
                    else if (i % 3 == 0)
                    {
                        mensaje = "Fizz";
                    }
                    else if (i % 5 == 0)
                    {
                        mensaje = "Buzz";
                    }

                    resultado = resultado + i + " " + mensaje + "\n";
                }

                return resultado;
            }
        }
    }
