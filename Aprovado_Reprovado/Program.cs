using System;

namespace Aprovado_Reprovado
{
    class Program
    {
        static void Main(string[] args)
        {

            float n1,n2,n3,n4,res; // usei float para mostrar numeros reais
            
            res=n1=n2=n3=n4=0;

            string resultado="Reprovado";


            Console.Write("Digite nota 1: ");
            n1=float.Parse(Console.ReadLine());

            Console.Write("Digite nota 2: ");
            n2=float.Parse(Console.ReadLine());

            Console.Write("Digite nota 3: ");
            n3=float.Parse(Console.ReadLine());

            Console.Write("Digite nota 4: ");
            n4=float.Parse(Console.ReadLine());

            res=(n1+n2+n3+n4)/4;

            if((res) >= 60){
                resultado = "Aprovado";
            }

            Console.WriteLine("Nota: {0} - Resultado: {1}", res, resultado);
            Console.ReadLine();
                                   
        }
    }
}
