using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte i, numA;
            double calificacion, sumaCalif = 0, promedio;

            Console.Write("Ingresa el numero de alumnos: ");
            numA = Convert.ToByte(Console.ReadLine());

            for (i = 1; i <= numAlumnos; i++)
            {
                Console.Write("Ingresa la calificacion: ");
                calificacion = Convert.ToDouble(Console.ReadLine());

                sumaCalif += calificacion;
            }

            promedio = sumaCalif / numA;
            Console.WriteLine("El promedio es {0}", promedio);
        }
    }
}
