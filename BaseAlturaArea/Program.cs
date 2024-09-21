using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAlturaArea
{
    public class Program
    {
        static void Main(string[] args)
        {
            int cantidadtriangulos = 0;
            int triangulosgrande = 0;
            double basetriangulo = 0;
            double alturatriangulo = 0;
            double area = 0;

              
            try
            {
                Console.WriteLine("ingrese la cantidad de triangulos a precesar: ");
                cantidadtriangulos = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < triangulosgrande; i++)
                {
                    Console.WriteLine($"ingrese la base del triangulo {i + 1}: ");
                    basetriangulo += Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"ingrese la altura del triangulo {i + 1}:");
                    alturatriangulo = Convert.ToDouble(Console.ReadLine());

                }

                area = (basetriangulo * alturatriangulo) / 2;

                Console.WriteLine($"triangulo {i + 1}: base = {basetriangulo}, altura = {alturatriangulo}, area = {area}");

                if (area > 12)
                {
                    triangulosgrande++;
                }

                Console.WriteLine($"cantidad de triangulos con area superior a 12 unidades cuadradas: {triangulosgrande}");


            }
            catch (Exception)
            {
                Console.WriteLine("error: ingreso un valor no valido. por favo, ingrese numeros correctos:");
                
            }

        }
    }
}
