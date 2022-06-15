using System;

namespace ConsoleAppEjercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ordenamiento de 3 números");
            int mayor, menor, medio;

            Console.Write("Ingrese el primer número:");
            var numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número:");
            var numero2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer número:");
            var numero3 = int.Parse(Console.ReadLine());
            if (numero1 != numero2 && numero1 != numero3 && numero2 != numero3)
            {
                Console.Write("Seleccione el ordenamiento (a)scendente o (d)escendente:");
                var orden = Console.ReadLine();
                if (orden.ToUpper()=="A" || orden.ToUpper()=="D")
                {
                    if (numero1>numero2)
                    {
                        if (numero1>numero3)
                        {
                            mayor = numero1;
                            if (numero2>numero3)
                            {
                                medio = numero2;
                                menor = numero3;
                            }
                            else
                            {
                                medio = numero3;
                                menor = numero2;
                            }
                        }
                        else
                        {
                            mayor = numero3;
                            medio = numero1;
                            menor = numero2;
                        }
                    }
                    else
                    {
                        if (numero2>numero3)
                        {
                            mayor = numero2;
                            if (numero1>numero3)
                            {
                                medio = numero1;
                                menor = numero3;
                            }
                            else
                            {
                                medio = numero3;
                                menor = numero1;
                            }
                        }
                        else
                        {
                            mayor = numero3;
                            medio = numero2;
                            menor = numero1;
                        }
                    }

                    if (orden.ToUpper()=="A")
                    {
                        Console.WriteLine($"{menor} {medio} {mayor}");
                    }
                    else
                    {
                        Console.WriteLine($"{mayor} {medio} {menor}");
                    }
                }
                else
                {
                    Console.WriteLine("Selección de ordenamiento errónea... fin del proceso");
                }
            }
            else
            {
                Console.WriteLine("Alguno de los números son iguales... fin del proceso");
            }

            Console.ReadLine();
        }
    }
}
