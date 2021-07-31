using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lentilha

{
    class Program
    {
        

        static void Main(string[] args)
        {

            //1) Valkiria é uma empreendedora que vende produtos naturais, ela está querendo fazer um mini programa para vender lentilha 
            //Faça um programa que calcule, o valor da lentilha vs o preço do peso.
            //Valor do peso da lentilha: 1,50 o KG
            //No final do programa, mostrar o valor total e quantos KG a pessoa selecionou, detalhe o pedido também pode ser vendido em gramas.

          
            Console.WriteLine("Quantos kilos de lentilha deseja?");
            double kilos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");

            double res = kilos * 1.50;

            Console.WriteLine("Você comprou " + kilos + "Kg de lentilha que dá R$ " + res+".");
            Console.Read();


          
            

        }
    }
}
