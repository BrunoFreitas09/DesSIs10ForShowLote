using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesSIs10ForShowLote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double NaoEstu = 0;
            double valEst = 0;
            double valPessoas = 0;
            double totPrimLo = 0;
            double totSegmLo = 0;
            double totTercLo = 0;
            for (int a = 1; a <= 30; a++)
            {
                if (a <= 10) ;
                {
                    //preço do primeiro lote: 100

                    Console.WriteLine("Informe o valor deste lote: ");
                    double Val1Lot = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a quantidade de ingressos que serão vendidos neste lote: ");
                    double qtdpess = double.Parse(Console.ReadLine());
                    Console.WriteLine("quantidade de estudantes compraram ingressos: ");
                    double est = double.Parse(Console.ReadLine());
                    NaoEstu = qtdpess - est;
                    valEst = (Val1Lot / 2) * est;
                    valPessoas = Val1Lot * NaoEstu;
                    totPrimLo = valPessoas + valEst;
                    Console.WriteLine("Valor total arrecadado neste lote: " + totPrimLo);
                }
                if (a <= 20) ;
                {
                    //preço do segundo lote: 150

                    Console.WriteLine("Informe o valor deste lote: ");
                    double Val1Lot = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a quantidade de ingressos que serão vendidos neste lote: ");
                    double qtdpess = double.Parse(Console.ReadLine());
                    Console.WriteLine("quantidade de estudantes compraram ingressos: ");
                    double est = double.Parse(Console.ReadLine());
                    NaoEstu = qtdpess - est;
                    valEst = (Val1Lot / 2) * est;
                    valPessoas = Val1Lot * NaoEstu;
                    totSegmLo = valPessoas + valEst;
                    Console.WriteLine("Valor total arrecadado neste lote: " + totSegmLo);
                }
                if (a <= 30) ;
                {
                    //preço do primeiro terceiro: 200

                    Console.WriteLine("Informe o valor deste lote: ");
                    double Val1Lot = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a quantidade de ingressos que serão vendidos neste lote: ");
                    double qtdpess = double.Parse(Console.ReadLine());
                    Console.WriteLine("quantidade de estudantes compraram ingressos: ");
                    double est = double.Parse(Console.ReadLine());
                    NaoEstu = qtdpess - est;
                    valEst = (Val1Lot / 2) * est;
                    valPessoas = Val1Lot * NaoEstu;
                    totTercLo = valPessoas + valEst;
                    Console.WriteLine("Valor total arrecadado neste lote: " + totTercLo);
                }
                Console.ReadKey();
            }
        }
    }
}
