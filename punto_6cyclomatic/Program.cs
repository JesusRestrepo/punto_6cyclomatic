using System;

namespace punto_6cyclomatic
{
    class Program
    {
        static void Main(string[] args)
        {
            int HET = 0, HEE8 = 0, salario;
            Console.WriteLine("Ingrese nombre trabajador");
            String nombre_trabajador = Console.ReadLine();

            Console.WriteLine("Ingrese horas trabajadas");
            int horas_trabajo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese valor hora");
            int valor_hora = int.Parse(Console.ReadLine());

            if (horas_trabajo > 40)
            {
                HET = horas_trabajo - 40;
                if (HET > 8)
                {
                    HEE8 = HET - 8;
                    salario = 40 * valor_hora + 16 * valor_hora + HEE8 * 3 * valor_hora;
                }
                else
                {
                    salario = 40 * valor_hora + HET * 2 * valor_hora;
                }
            }
            else
            {
                salario = horas_trabajo * valor_hora;
            }
            Console.WriteLine("El trabajador " + nombre_trabajador + " devengo: $" + salario);
        }
    }
}
