using Laboratorio1BelquizTatianaCruzMartinez.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1BelquizTatianaCruzMartinez.Negocio
{
    public class ClsPersona
    {
        public void calcularIMC(Persona info)
        {
            double pro = info.Peso / Math.Pow(info.Altura, 2);
            if (pro < 24)
            {
                Console.WriteLine("Su peso es ideal.");
            }
            else
            {
                Console.WriteLine("Usted tiene sobre peso.");
            }
        }
        public void esMayorDeEdad(Persona info)
        {
            int Edad = info.Edad;
            if (Edad > 18)
            {
                Console.WriteLine("Usted es mayor de edad.");
            }
            else
            {
                Console.WriteLine("Usted es menor de edad.");
            }
        }
    }
}
