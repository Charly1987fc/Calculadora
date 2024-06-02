using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProgra2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, dividendo, divisor, bae, altura, lado1, lado2, tri;
            int sumar, restar, areatri, dividir, areacua;
            double bas, exponente, potencia;
            string op="";

            while (op!="Salir")
            {

                Console.WriteLine("Menu");
                Console.WriteLine("Sumar");
                Console.WriteLine("Restar");
                Console.WriteLine("Dividir");
                Console.WriteLine("Potencia");
                Console.WriteLine("Triangulo");
                Console.WriteLine("Cuadrado");
                Console.WriteLine("Salir");
                Console.WriteLine("Ingrese la opcion deseada");
                op= Console.ReadLine();
                switch (op)
                {
                    case "Sumar":
                        Console.WriteLine("Ingrese el primer valor");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor");
                        num2 = int.Parse(Console.ReadLine());
                        sumar=num1 + num2;
                        Console.WriteLine("El resultado de la suma es "+sumar);
                        break;
                    case "Restar":
                        Console.WriteLine("Ingrese el primer valor");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor");
                        num2 = int.Parse(Console.ReadLine());
                        restar=num1 - num2;
                        Console.WriteLine("El resultado de la resta es "+restar);
                        break;
                    case "Dividir":
                        Console.WriteLine("Ingrese el dividendo");
                        dividendo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el divisor");
                        divisor = int.Parse(Console.ReadLine());
                        dividir=dividendo / divisor;
                        Console.WriteLine("El resultado de la division es "+dividir);
                        if (divisor>dividendo)
                        {
                            Console.WriteLine(+divisor+" El divisor es mayor al dividendo "+dividendo);
                        }
                        break;
                    case "Potencia":
                        Console.WriteLine("Ingrese la base");
                        bas = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el exponente");
                        exponente = int.Parse(Console.ReadLine());
                        potencia = Math.Pow(bas, exponente);
                        Console.WriteLine("El resultado de la potencia es "+potencia);
                        break;
                    case "Triangulo":
                        Console.WriteLine("Ingrese la base");
                        bae = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la altura");
                        altura = int.Parse(Console.ReadLine());
                        tri = 2;
                        areatri=(bae * altura/tri);
                        Console.WriteLine("El area del triangulo es "+areatri);
                        break;
                    case "Cuadrado":
                        Console.WriteLine("Ingrese el lado");
                        lado1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el lado");
                        lado2 = int.Parse(Console.ReadLine());
                        areacua=lado1 * lado2;


                        Console.WriteLine("El area del cuadrado es "+areacua);
                        break;
                    case "Salir":
                        Console.WriteLine("Salir");
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion correcta");
                        break;
                }

            }
            Console.ReadKey();
        }
    }
}
