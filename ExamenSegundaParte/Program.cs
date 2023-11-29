using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSegundaParte
{
    public class Program : CLASECHIDA
    {
        public Program(string variable1, string variable2) : base(variable1, variable2)
        {
            Variable1 = variable1;
            Variable2 = variable2;
        }

        static void Main(string[] args)
        {
            Program program = new Program("dsflksgkdmls", "sdlkmflskd");
            program.Arreglo = new string[] { "Manzana", "Pera", "Guayaba" };
            Console.WriteLine(program.Arreglo);
        }
    }
    public class CLASECHIDA
    {
        public string Nombre
        {
            set
            {
                Nombre = "Leonardo";
            }
        }
        public string Variable1 { get; set; }
        public string Variable2 { get; set; }
        protected string[] Arreglo { get; set;}

        protected static string metodo(string nombre, string variable1, string variable2)
        {
            //CLASECHIDA cLASECHIDA = new CLASECHIDA("","","");
            return "";
        }
        public string metodo(string nombre, string variable1, string variable2, int a)
        {
            return "";
        }
        public CLASECHIDA(string variable1, string variable2)
        {
            Variable1 = variable1;
            Variable2 = variable2;
        }
    }
}